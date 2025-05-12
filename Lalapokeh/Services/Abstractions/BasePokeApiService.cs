using Lalapokeh.Models.API.Common;
using Lalapokeh.Models.API.Interfaces;
using System.Net.Http.Json;

namespace Lalapokeh.Services.Abstractions
{
  /// <summary>
  /// Base class for services which querry data from PokeAPI.
  /// </summary>
  /// <typeparam name="TApiData">Type of the querried api data</typeparam>
  /// <param name="httpClient">Client to use for querrying</param>
  /// <param name="resourceBaseUrl">Url of the api resource endpoint, e.g. 'pokemon'</param>
  public abstract class BasePokeApiService<TApiData> where TApiData : class, IIndexApiResource, INameApiResource
  {
    private readonly HttpClient _httpClient;
    private readonly string _resourceBaseUrl;
    private readonly string _logId;
    private readonly int _pageSize;
    private readonly ILogger<BasePokeApiService<TApiData>> _logger;

    private static List<NamedApiResource> _cachedNamedApiResourceList = new();
    private static readonly Dictionary<int, TApiData> _cacheEntryById = new();
    private static readonly Dictionary<string, TApiData> _cacheEntryByName = new();

    public BasePokeApiService(
      HttpClient httpClient,
      string resourceBaseUrl,
      ILogger<BasePokeApiService<TApiData>> logger,
      int pageSize = 1000
    )
    {
      _httpClient = httpClient;
      _resourceBaseUrl = resourceBaseUrl;
      _logId = $"ApiService[{resourceBaseUrl}]";
      _pageSize = pageSize;
      _logger = logger;
    }

    #region Public methods
    /// <summary>
    /// Get a list of <see cref="NamedApiResource"/> of type <typeparamref name="TApiData"/>.
    /// <br/>
    /// <paramref name="skip"/> and <paramref name="count"/> can be used to control the range of entries
    /// returned.
    /// If <paramref name="skip"/>/<paramref name="count"/> equals <see langword="0"/>,
    /// the parameter isn't applied.
    /// </summary>
    /// <param name="skip">The amount of entries to skip. Default: 0</param>
    /// <param name="count">The max. amount of entries to querry. Default: 0</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The list of <see cref="NamedApiResource"/> of type <typeparamref name="TApiData"/>.</returns>
    public async Task<List<NamedApiResource>?> GetNamedResourceListAsync(
      int skip = 0,
      int count = 0,
      CancellationToken cancellationToken = default
    )
    {
      if (_cachedNamedApiResourceList.Count == 0)
      {
        _cachedNamedApiResourceList = await GetNamedResourceListAsyncInternal(cancellationToken) ?? [];
      }

      if (_cachedNamedApiResourceList.Count != 0)
      {
        return [..
          _cachedNamedApiResourceList
          .Skip(skip)
          .Take(count == 0 ? _cachedNamedApiResourceList.Count : count)
        ];
      }

      return [];
    }

    /// <summary>
    /// Get a specific entry by name.
    /// </summary>
    /// <param name="name">The name of the entry</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The entry found</returns>
    /// <exception cref="ArgumentException"><paramref name="name"/> is null, empty or whitespace</exception>
    /// <exception cref="HttpRequestException">If the request failed</exception>
    public async Task<TApiData?> GetByNameAsync(string name, CancellationToken cancellationToken = default)
    {
      ArgumentException.ThrowIfNullOrEmpty(name);
      ArgumentException.ThrowIfNullOrWhiteSpace(name);

      var sanitizedName = SanitizeInput(name);

      if (_cacheEntryByName.TryGetValue(sanitizedName, out var cachedEntry))
      {
        return cachedEntry;
      }

      var data = await SafeRequest<TApiData>(
        $"{_resourceBaseUrl}/{sanitizedName}",
        $"Failed to fetch '{sanitizedName}'",
        cancellationToken
      );

      if (data is not null)
      {
        _cacheEntryById[data.Id] = data;
        _cacheEntryByName[sanitizedName] = data;
      }

      return data;
    }

    /// <summary>
    /// Get a specific entry by ID.
    /// </summary>
    /// <param name="id">The ID of the entry</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The entry found</returns>
    /// <exception cref="ArgumentOutOfRangeException"><paramref name="id"/> less than 0</exception>
    /// <exception cref="HttpRequestException">If the request failed</exception>
    public async Task<TApiData?> GetByIdAsync(int id, CancellationToken cancellationToken = default)
    {
      ArgumentOutOfRangeException.ThrowIfLessThan(id, 0);

      if (_cacheEntryById.TryGetValue(id, out var cachedEntry))
      {
        return cachedEntry;
      }

      var data = await SafeRequest<TApiData>(
        $"{_resourceBaseUrl}/{id}",
        $"Failed to fetch entry with id '{id}'",
        cancellationToken
      );

      if (data is not null)
      {
        _cacheEntryById[id] = data;
        _cacheEntryByName[data.Name] = data;
      }

      return data;
    }
    #endregion

    #region Private methods
    async private Task<List<NamedApiResource>?> GetNamedResourceListAsyncInternal(
      CancellationToken cancellationToken = default
    )
    {
      var next = $"{_resourceBaseUrl}?limit={_pageSize}";
      List<NamedApiResource> resourceList = [];

      while (next is not null)
      {
        var pagedResourceList = await SafeRequest<PagedResourceList<NamedApiResource>>(
          next,
          "Failed to fetch resource list",
          cancellationToken
        );

        if (pagedResourceList is not null)
        {
          resourceList.AddRange(pagedResourceList.Results);
        }

        next = pagedResourceList?.Next;
      }

      return resourceList;
    }

    async private Task<TReturn?> SafeRequest<TReturn>(
      string url,
      string errorMsg = "Failed to fetch",
      CancellationToken cancellationToken = default
    )
    {
      var response = await _httpClient.GetAsync(url, cancellationToken);

      if (response is null)
      {
        _logger.LogError($"{_logId}: {errorMsg}");
        throw new HttpRequestException($"{_logId}: {errorMsg}");
      }

      if (!response.IsSuccessStatusCode)
      {
        _logger.LogError($"{_logId}: {errorMsg} - Status Code: {response.StatusCode}");
        throw new HttpRequestException($"{_logId}: {errorMsg}", null, response.StatusCode);
      }

      return await response.Content.ReadFromJsonAsync<TReturn>(cancellationToken: cancellationToken);
    }

    private static string SanitizeInput(string name)
    {
      return name.Trim()
        .Replace(" ", "-")
        .Replace("/", "")
        .Replace("\\", "")
        .Replace("?", "")
        .Replace("&", "")
        .Replace("#", "")
        .ToLower();
    }
    #endregion
  }
}

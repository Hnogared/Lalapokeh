using Lalapokeh.Models.API.Common;
using System.Net.Http.Json;

namespace Lalapokeh.Services.Abstractions
{
  /// <summary>
  /// Base class for services which querry data from PokeAPI.
  /// </summary>
  /// <typeparam name="TApiData">Type of the querried api data</typeparam>
  /// <param name="httpClient">Client to use for querrying</param>
  /// <param name="resourceBaseUrl">Url of the api resource endpoint, e.g. 'pokemon'</param>
  public abstract class BasePokeApiService<TApiData>(HttpClient httpClient, string resourceBaseUrl)
  {
    protected readonly HttpClient _httpClient = httpClient;
    protected readonly string _resourceBaseUrl = resourceBaseUrl;
    private readonly string _logId = $"ApiService[{resourceBaseUrl}]";

    private static readonly int _pageSize = 100;

    /// <summary>
    /// Get a list of <see cref="NamedApiResource"/> of the specified <typeparamref name="TApiData"/>
    /// and a given <paramref name="limit"/>.
    /// <br/>
    /// If <paramref name="limit"/> equals 0, all the entries are querried. More entries than the
    /// specified <paramref name="limit"/> can be returned, do to the paginated querrying.
    /// </summary>
    /// <param name="limit">The max. amount of entries to querry. Default: 0</param>
    /// <returns>A list of <see cref="NamedApiResource"/> of the specified <typeparamref name="TApiData"/>.</returns>
    public async Task<List<NamedApiResource>?> GetNamedResourceListAsync(int limit = 0)
    {
      var usedLimit = limit != 0 ? Math.Min(_pageSize, limit) : _pageSize;
      var next = $"{_resourceBaseUrl}?limit={usedLimit}";
      List<NamedApiResource> resourceList = [];

      while (next is not null && (limit == 0 || resourceList.Count < limit))
      {
        var pagedResourceList = await _httpClient.GetFromJsonAsync<PagedResourceList<NamedApiResource>>(next);
        if (pagedResourceList is not null)
        {
          resourceList.AddRange(pagedResourceList.Results);
        }
        next = pagedResourceList?.Next;
      }

      return resourceList;
    }

    /// <summary>
    /// Get a specific entry by name.
    /// </summary>
    /// <param name="name">The name of the entry</param>
    /// <returns>The entry found</returns>
    public async Task<TApiData?> GetByNameAsync(string name)
    {
      ArgumentException.ThrowIfNullOrEmpty(name);
      ArgumentException.ThrowIfNullOrWhiteSpace(name);

      var response = await _httpClient.GetAsync($"{_resourceBaseUrl}/{name}");

      if (response is null)
      {
        throw new HttpRequestException($"{_logId}: Failed to fetch {name}.");
      }

      if (!response.IsSuccessStatusCode)
      {
        throw new HttpRequestException($"{_logId}: Failed to fetch {name}. Code: {response.StatusCode}");
      }

      return await response.Content.ReadFromJsonAsync<TApiData>();
    }

    /// <summary>
    /// Get a specific entry by ID.
    /// </summary>
    /// <param name="id">The ID of the entry</param>
    /// <returns>The entry found</returns>
    public async Task<TApiData?> GetByIdAsync(int id)
    {
      ArgumentOutOfRangeException.ThrowIfLessThan(id, 0);

      var response = await _httpClient.GetAsync($"{_resourceBaseUrl}/{id}");

      if (response is null)
      {
        throw new HttpRequestException($"{_logId}: Failed to fetch entry with id {id}.");
      }

      if (!response.IsSuccessStatusCode)
      {
        throw new HttpRequestException($"{_logId}: Failed to fetch entry with id {id}. Code: {response.StatusCode}");
      }

      return await response.Content.ReadFromJsonAsync<TApiData>();
    }
  }
}
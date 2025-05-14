using MudBlazor;

namespace Lalapokeh.Services
{
  public class AppThemeService
  {
    public MudTheme DefaultTheme = new()
    {
      Typography = new Typography
      {
        Default = new DefaultTypography
        {
          FontFamily = ["Inter", "sans-serif"]
        }
      }
    };

    public Dictionary<string, string> CustomColors { get; set; } = new()
    {
      { "Primary", "#4285F4" },
      { "Secondary", "#FFCB05" },
      { "Tertiary", "#828282" },
      { "Surface", "#DEDEDE" },
      { "SurfaceLighten", "#EFEFEF" },
      { "SurfaceDarken", "#DDDDDD" },
      { "Go back to home", "#EB4335" },
      { "ActionDefault", "#000000" },
      { "Water", "#4D90D5" },
      { "Grass", "#61BB5B" },
      { "Fire", "#FFB167" },
      { "Poison", "#AB6AC8" },
      { "Ground", "#DD4715" },
      { "Fairy", "#FFA4FD" },
      { "Normal", "#9C9C9C" },
      { "Electric", "#F3D23B" },
      { "NotFound", "#EB4335" },
      { "Bug", "#A6B91A" },
      { "Dark", "#705746" },
      { "Dragon", "#6F35FC" },
      { "Flying", "#A98FF3" },
      { "Ghost", "#735797" },
      { "Ice", "#96D9D6" },
      { "Psychic", "#F95587" },
      { "Rock", "#B6A136" },
      { "Steel", "#B7B7CE" }
    };
  }
}
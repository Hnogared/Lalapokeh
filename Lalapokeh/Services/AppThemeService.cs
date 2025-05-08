namespace Lalapokeh.Services
{
	public class AppThemeService
	{
		public Dictionary<string, string> CustomColors { get; set; } = new()
		{
			{ "Primary", "#ff5733" },
			{ "Secondary", "#3498db" },
			{"Tertiay", "#828282" },
			{" ActionDefault", "#000000" },
			{"Water", "#4D90D5"},
			{"Grass", "#61BB5B" },
			{"Fire", "#FFB167" },
			{"Poisen", "#AB6AC8" },
			{"Ground" , "#DD4715"},
			{"Fairy", "#FFA4FD" },
			{"Normal", "#9C9C9C" },
			{"Electric", "#F3D23B"},
			{"Not Found", "#EB4335" },
			{"Go back to home", "#EB4335"},
		};
	}
}

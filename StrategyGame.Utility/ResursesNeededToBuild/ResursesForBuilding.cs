namespace StrategyGame.Utility.ResursesNeededToBuild
{
	public static class ResursesForBuilding
	{
		/// <summary>
		/// This`s price (resurses) per level 1 building 
		/// </summary>
		static Dictionary<string, Dictionary<string, int>> resursesNeededBuildings = new Dictionary<string, Dictionary<string, int>>
		{
			{ "house" , new Dictionary<string, int>
			{
				{"wood" , 100 },
				{"stone" , 100 }
			} },
			{ "lumber" , new Dictionary<string, int>
			{
				{"wood" , 100 },
				{"stone" , 100 }
			} },
			{ "fishery" , new Dictionary<string, int>
			{
				{"wood" , 100 },
				{"stone" , 100 }
			} },
			{ "grainFarm" , new Dictionary<string, int>
			{
				{"wood" , 100 },
				{"stone" , 100 }
			} },
			{ "ironMine" , new Dictionary<string, int>
			{
				{"wood" , 100 },
				{"stone" , 500 }
			} },
			{ "stoneMine" , new Dictionary<string, int>
			{
				{"wood" , 100 },
				{"stone" , 100 }
			} },
			{ "castle" , new Dictionary<string, int>
			{
				{"wood" , 100 },
				{"stone" , 500 }
			} },
			{ "weaponFactory" , new Dictionary<string, int>
			{
				{"wood" , 100 },
				{"stone" , 500 }
			} },
			{ "armorFactory" , new Dictionary<string, int>
			{
				{"wood" , 100 },
				{"stone" , 500 }
			} },
			{ "warehouse" , new Dictionary<string, int>
			{
				{"wood" , 100 },
				{"stone" , 500 }
			} },
		};
	};
}


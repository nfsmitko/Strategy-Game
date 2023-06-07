using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StrategyGame.DataAccess.Models.Entity;

namespace StrategyGame.DataAccess.Models.Config
{
	internal class BuildingConfig : IEntityTypeConfiguration<Building>
	{
		public void Configure(EntityTypeBuilder<Building> builder)
		{
			builder.HasData(BuildingsAdd());
		}

		private Building[] BuildingsAdd()
		{
			Building[] buildings = new Building[9];

			buildings[0] = new Building()
			{
				Id = new Guid("e0e0e9b9-13c6-439a-bca8-8323cdea4774"),
				Name = "House",
				Level = 1,
				ResoursePerTurn = 50,
			};

			buildings[1] = new Building()
			{
				Id = new Guid("c5b08d8f-6723-4cf2-b2fe-43a282a10f57"),
				Name = "Lumber",
				Level = 1,
				ResoursePerTurn = 20,
			};

			buildings[2] = new Building()
			{
				Id = new Guid("11ae501f-d6e6-42ab-96b5-95d2e2468dd0"),
				Name = "Fishery",
				Level = 1,
				ResoursePerTurn = 20,
			};

			buildings[3] = new Building()
			{
				Id = new Guid("105925a6-8909-4805-8fa8-914e7f73c84a"),
				Name = "GrainFarm",
				Level = 1,
				ResoursePerTurn = 20,
			};

			buildings[4] = new Building()
			{
				Id = new Guid("21ea3a61-3661-40f8-92e6-f4fff53587df"),
				Name = "StoneМine",
				Level = 1,
				ResoursePerTurn = 20,
			};

			buildings[5] = new Building()
			{
				Id = new Guid("f9ebfd5b-08c3-4adf-80f5-c643e41230ab"),
				Name = "Castle",
				Level = 1,
				ResoursePerTurn = 100,
			};

			buildings[6] = new Building()
			{
				Id = new Guid("5f766a6a-76bf-462d-8f10-339f7d057c1f"),
				Name = "IronМine",
				Level = 1,
				ResoursePerTurn = 20,
			};

			buildings[7] = new Building()
			{
				Id = new Guid("afd25e70-615a-495d-bc77-ddb898853be4"),
				Name = "WeaponFactory",
				Level = 1,
				ResoursePerTurn = 1,
			};

			buildings[8] = new Building()
			{
				Id = new Guid("beccbc4a-4561-4384-91c9-4478235d2fa8"),
				Name = "ArmorFactory",
				Level = 1,
				ResoursePerTurn = 1,
			};

			buildings[8] = new Building()
			{
				Id = new Guid("438139cb-b988-41ca-98a5-5fed24136200"),
				Name = "Warehouse",
				Level = 1,
				ResoursePerTurn = 500,
			};

			return buildings;
		}
	}
}

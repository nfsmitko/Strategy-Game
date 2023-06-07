using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StrategyGame.DataAccess.Models.Entity;

namespace StrategyGame.DataAccess.Models.Config
{
	public class ResursesConfig : IEntityTypeConfiguration<Resurse>
	{
		public void Configure(EntityTypeBuilder<Resurse> builder)
		{
			builder.HasData(ResursesAdd());
		}

		private Resurse[] ResursesAdd()
		{
			Resurse[] resursesToAdd = new Resurse[7];

			resursesToAdd[0] = new Resurse()
			{
				Id = new Guid("2973d2c8-aed7-475e-89ef-dc0a36bce242"),
				Name = "wood",
				Quantity = 200
			};

			resursesToAdd[1] = new Resurse()
			{
				Id = new Guid("6d6f3d33-e20f-4db9-bd95-fde91836f5eb"),
				Name = "stone",
				Quantity = 200
			};

			resursesToAdd[2] = new Resurse()
			{
				Id = new Guid("32a4dace-1615-4a01-88f3-a76bda8098eb"),
				Name = "fish",
				Quantity = 200
			};

			resursesToAdd[3] = new Resurse()
			{
				Id = new Guid("fceb31fe-063c-41c1-acb3-75babdc015f3"),
				Name = "grain",
				Quantity = 200
			};

			resursesToAdd[4] = new Resurse()
			{
				Id = new Guid("37f2cf7c-39b1-419e-9e8b-0dab974ba07a"),
				Name = "iron",
				Quantity = 50
			};

			resursesToAdd[5] = new Resurse()
			{
				Id = new Guid("b9079d09-b756-4662-8307-6402d68726d6"),
				Name = "weapon",
				Quantity = 0
			};

			resursesToAdd[6] = new Resurse()
			{
				Id = new Guid("860a6987-498b-43ee-82cb-62a005ec30db"),
				Name = "armor",
				Quantity = 0
			};
			return resursesToAdd;
		}
	}
}

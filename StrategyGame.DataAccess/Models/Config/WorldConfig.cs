using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StrategyGame.DataAccess.Models.Entity;

namespace StrategyGame.DataAccess.Models.Config
{
	public class WorldConfig : IEntityTypeConfiguration<World>
	{
		public void Configure(EntityTypeBuilder<World> builder)
		{
			builder.HasData(WorldAdd());
		}

		private World WorldAdd()
		{
			
		}
	}
}

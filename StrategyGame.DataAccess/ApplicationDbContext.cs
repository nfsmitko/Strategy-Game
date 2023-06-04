using Duende.IdentityServer.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using StrategyGame.DataAccess.Models.Entity;
using static StrategyGame.Utility.EntityConstants.UserConstants.UserConstntsDbContext;

namespace StrategyGame.DataAccess
{
	public class ApplicationDbContext : ApiAuthorizationDbContext<AppUser>
    {
        public ApplicationDbContext(DbContextOptions options, IOptions<OperationalStoreOptions> operationalStoreOptions)
            : base(options, operationalStoreOptions)
        {

        }

		public DbSet<Army> Armies { get; set; } = null!;
		public DbSet<Aliance> Aliances { get; set; } = null!;
		public DbSet<Building> Buildings { get; set; } = null!;
		public DbSet<Resurse> Resurses { get; set; } = null!;
		public DbSet<World> Worlds { get; set; } = null!;
		public DbSet<ResursToBuild> ResursesToBuild { get; set; } = null!;

		protected override void OnModelCreating(ModelBuilder builder)
		{
			builder.Entity<AppUser>()
			   .Property(x => x.UserName)
			   .HasMaxLength(NameMaxLenght)
			   .IsRequired();

			builder.Entity<AppUser>()
				.Property(x => x.Email)
				.HasMaxLength(EmailMaxLenght)
			.IsRequired();

			base.OnModelCreating(builder);
		}
	}
}
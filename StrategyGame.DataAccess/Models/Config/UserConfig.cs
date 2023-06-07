using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StrategyGame.DataAccess.Models.Entity;

namespace StrategyGame.DataAccess.Models.Config
{
	internal class UserConfig : IEntityTypeConfiguration<AppUser>
	{
		public void Configure(EntityTypeBuilder<AppUser> builder)
		{
			builder.HasData(AddUser());
		}

		PasswordHasher<AppUser> hasher = new PasswordHasher<AppUser>();
		private AppUser AddUser()
		{
			return new AppUser()
			{
				Id = "f9d24dc0-7d91-46e4-bf5f-62519bb1c7bb",
				UserName = "Admin",
				NormalizedUserName = "ADMIN",
				Email = "admin@abv.bg",
				NormalizedEmail = "ADMIN@ABV.BG",
				PasswordHash = hasher.HashPassword(null, "123456"),
				EmailConfirmed = true,
				FirstName = "Admin",
				LastName = "Admin"
			};
		}
	}
}

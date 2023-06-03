using Microsoft.AspNetCore.Identity;

namespace StrategyGame.DataAccess.Models.Entity
{
	public class AppUser : IdentityUser
	{
        public bool IsDeleted { get; set; }	= false;

        public List<World> Worlds { get; set; } = new List<World>();
    }
}

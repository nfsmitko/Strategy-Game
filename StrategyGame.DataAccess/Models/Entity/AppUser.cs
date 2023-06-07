using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using static StrategyGame.Utility.EntityConstants.UserConstants.UserConstntsDbContext;

namespace StrategyGame.DataAccess.Models.Entity
{
	public class AppUser : IdentityUser
	{
        [StringLength(NameMaxLenght)]
        public string FirstName { get; set; } = null!;

		[StringLength(NameMaxLenght)]
		public string LastName { get; set; } = null!;
        public bool IsDeleted { get; set; }	= false;

        public List<World> Worlds { get; set; } = new List<World>();
    }
}

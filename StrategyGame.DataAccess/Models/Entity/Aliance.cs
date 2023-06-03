using System.ComponentModel.DataAnnotations;
using static StrategyGame.Utility.EntityConstants.EntityConstants.AllianceConstants;

namespace StrategyGame.DataAccess.Models.Entity
{
	public class Aliance
	{
        [Key]
        public Guid Id { get; set; }

        [StringLength(NameMinLenght)]
        public string Name { get; set; } = string.Empty;
    }
}

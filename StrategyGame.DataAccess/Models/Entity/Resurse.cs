using System.ComponentModel.DataAnnotations;
using static StrategyGame.Utility.EntityConstants.EntityConstants.ResurseConstants;

namespace StrategyGame.DataAccess.Models.Entity
{
	public class Resurse
	{
		[Key]
		public Guid Id { get; set; }

		[Required]
		[StringLength(NameMaxLenght)]
		public string Name { get; set; } = null!;

		[Required]
		[Range(typeof(double), "0.0", "1.7976931348623157E+308", ConvertValueInInvariantCulture = true)]
		public double Quantity { get; set; }
    }
}

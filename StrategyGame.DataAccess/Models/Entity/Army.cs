using System.ComponentModel.DataAnnotations;
using static StrategyGame.Utility.EntityConstants.EntityConstants.ArmyConstants;

namespace StrategyGame.DataAccess.Models.Entity
{
	public class Army
	{
        [Key]
		public Guid Id { get; set; }

        [Required]
        [StringLength(NameMaxLenght)]
		public string Name { get; set; } = null!;

        [Required]
		[Range(typeof(double), "0.0", "1.7976931348623157E+308", ConvertValueInInvariantCulture = true)]
		public double Attack { get; set; }

		[Required]
		[Range(typeof(double), "0.0", "1.7976931348623157E+308", ConvertValueInInvariantCulture = true)]
		public double Defence { get; set; }

		[Required]
		[Range(typeof(double), "0.0", "1.7976931348623157E+308", ConvertValueInInvariantCulture = true)]
		public double Health { get; set; }

		[Required]
		[Range(0 , int.MaxValue)]
        public int Quantity { get; set; }
    }
}

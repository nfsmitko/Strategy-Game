using System.ComponentModel.DataAnnotations;
using static StrategyGame.Utility.EntityConstants.EntityConstants.BuildingConstants;

namespace StrategyGame.DataAccess.Models.Entity
{
	public class Building
	{
		[Key]
		public Guid Id { get; set; }

		[Required]
		[StringLength(NameMaxLenght)]
		public string Name { get; set; } = null!;

		[Required]
		public int Level { get; set; }

		[Required]
        public double ResoursePerTurn { get; set; }

		public ICollection<ResursToBuild> ResursesToBuild { get; set; } = new List<ResursToBuild>();
    }
}

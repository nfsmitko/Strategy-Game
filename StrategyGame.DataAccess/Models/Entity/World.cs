using System.ComponentModel.DataAnnotations;
using static StrategyGame.Utility.EntityConstants.EntityConstants.WorldConstants;

namespace StrategyGame.DataAccess.Models.Entity
{
	public class World
	{
		[Key]
		public Guid Id { get; set; }

		[Required]
		[StringLength(NameMaxLenght)]
		public string Name { get; set; } = null!;
		public int CityLevel { get; set; } = 1;

		public ICollection<Building> Buildings { get; set; } = new List<Building>();
		public ICollection<Resurse> Resurses { get; set; } = new List<Resurse>();
		public ICollection<Army> Armyes { get; set; } = new List<Army>();
		public ICollection<Aliance> Aliances { get; set; } = new List<Aliance>();
	}
}

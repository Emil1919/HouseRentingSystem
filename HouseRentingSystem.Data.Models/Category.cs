using System.ComponentModel.DataAnnotations;

namespace HouseRentingSystem.Data.Models
{
	public class Category
	{
		[Key]
        public int Id { get; set; }
		[Required]
		[MinLength(Common.Constants.Category.NameMaxLength)]
		public string Name { get; set; } = null!;

		public ICollection<House> Houses { get; set; } = new HashSet<House>();

    }
}
using System.ComponentModel.DataAnnotations;

namespace HouseRentingSystem.Data.Models
{
	public class Agent
	{
		[Key]
        public Guid Id { get; set; }=Guid.NewGuid();
		[Required]
		[MaxLength(15)]
        public string PhoneNumber { get; set; } = null!;
		[Required]
        public Guid UserId { get; set; }
		public virtual User User { get; set; } = null!;
		public virtual ICollection<House> OwnHouses { get; set; } = new HashSet<House>();
    }
}
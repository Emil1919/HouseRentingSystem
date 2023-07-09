

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HouseRentingSystem.Data.Models
{
	public class House
	{
        [Key]
        public Guid Id { get; set; }=Guid.NewGuid();
        [Required]
        [MinLength(10)]
        [MaxLength(50)]
        public string Title  { get; set; }=null!;

        [Required]
        [MinLength(30)]
        [MaxLength(150)]
        public string Address { get; set; } = null!;
        [Required]
        [MinLength(50)]
        [MaxLength(500)]
        public string Description { get; set; } = null!;
        [Required]
        [MaxLength (2048)]
        public string ImageUrl { get; set; } = null!;

        [Required]
        [Range(0,2000)]
        public decimal PricePerMonth { get; set; }
        [Required]
        public int CategoryId { get; set; }
        public Category Category { get; set; } = null!;
        [Required]
        public Guid AgentId { get; set; }
        [ForeignKey(nameof(AgentId))]
        public Agent Agent { get; set; } = null!;
        public Guid? RenterId { get; set; }
        public User? Renter { get; set; }




        //	Id – a unique integer, Primary Key
        //• Title – a string with min length 10 and max length 50 (required)
        //• Address – a string with min length 30 and max length 150 (required)
        //• Description – a string with min length 50 and max length 500 (required)
        //• ImageUrl – a string (required)
        //• PricePerMonth – a decimal with min value 0 and max value 2000 (required)
        //• CategoryId – an integer(required)
        //• Category – a Category object
        //• AgentId – an integer(required)
        //• Agent – an Agent object
        //• RenterId – a string

    }
}

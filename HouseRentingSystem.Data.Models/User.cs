using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseRentingSystem.Data.Models
{
	public class User:IdentityUser<Guid>
	{
		public virtual ICollection<House> RentedHouses { get; set; } = new HashSet<House>();
    }

}

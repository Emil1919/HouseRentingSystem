using HouseRentingSystem.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HouseRentingSystem.Data.Configurations
{
	public class CategoryEntityConfigoration: IEntityTypeConfiguration<Category>
	{
		public void Configure(EntityTypeBuilder<Category> builder)
		{
			builder.HasData(this.GeneratedCategories());
		}
		private Category[] GeneratedCategories()
		{
			ICollection<Category> categories = new HashSet<Category>();
			Category category = new Category()
			{
				Id = 1,
				Name = "Cottage"
			};
			categories.Add(category);
			category = new Category()
			{
				Id = 2,
				Name = "Single-Family"
			};
			categories.Add(category);
			category = new Category()
			{
				Id = 3,
			    Name = "Duplex"
			};
			categories.Add(category);

			return categories.ToArray();
		}
	}
}

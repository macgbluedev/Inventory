using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities
{
	public class CategoryEntity
	{
		[Key]
		[StringLength(50)]
		public string CategoryId { get; set; }

		[Required]
		[StringLength(100)]
		public string CategoryName { get; set; }

		//Relationship with Product 1:n
		public ICollection<ProductEntity> Products { get; set; }
	}
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities
{
	public class StorageEntity
	{
		[Key]
		[StringLength(50)]
		public string StorageId { get; set; }

		[Required]
		public DateTime LastUpdate { get; set; }

		[Required]
		public string StockStorage { get; set; }

		//Relationship with Product n:1
		public string ProductId { get; set; }
		public ProductEntity Product { get; set; }

		//Relationship with Wharehouse n:1
		public string WarehouseId { get; set; }
		public CategoryEntity Warehouse { get; set; }


		//Relationship with Operation 1:n
		public ICollection<OperationEntity> Operations { get; set; }
	}
}

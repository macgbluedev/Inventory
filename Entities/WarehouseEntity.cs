using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities
{
	public class WarehouseEntity
	{
		[Key]
		[StringLength(50)]
		public string WarehouseId { get; set; }

		[Required]
		public string WarehouseName { get; set; }

		[Required]
		[StringLength(100)]
		public string WarehouseAdress { get; set; }

		//Relationship with Storage 1:n
		public ICollection<StorageEntity> Storages { get; set; }
	}
}

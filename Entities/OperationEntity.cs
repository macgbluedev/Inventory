using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities
{
	public class OperationEntity
	{
		[Key]
		[StringLength(50)]
		public string OperationId { get; set; }

		[Required]
		public DateTime OperationDate { get; set; }

		[Required]
		public int Quantity { get; set; }

		[Required]
		public bool IsInput { get; set; }

		//Relationship with Storage n:1
		public string StorageId { get; set; }
		public StorageEntity Storage { get; set; }
	}
}

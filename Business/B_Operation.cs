using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccess;
using Entities;

namespace Business
{
	public class B_Operation
	{
		public List<OperationEntity> OperationList()
		{
			using (var db = new InventaryContext())
			{
				return db.Operations.ToList();
			}
		}

		public void CreateOperation(OperationEntity oOperation)
		{
			using (var db = new InventaryContext())
			{
				db.Operations.Add(oOperation);
				db.SaveChanges();
			}
		}

		public void UpdateOperation(OperationEntity oOperation)
		{
			using (var db = new InventaryContext())
			{
				db.Operations.Update(oOperation);
				db.SaveChanges();
			}
		}
	}
}

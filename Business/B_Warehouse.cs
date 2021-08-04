using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccess;
using Entities;

namespace Business
{
	public class B_Warehouse
	{
		public List<WarehouseEntity> WarehousetList()
		{
			using (var db = new InventaryContext())
			{
				return db.Warehouses.ToList();
			}
		}

		public void CreateWarehouse(WarehouseEntity oWarehouse)
		{
			using (var db = new InventaryContext())
			{
				db.Warehouses.Add(oWarehouse);
				db.SaveChanges();
			}
		}

		public void UpdateWarehouse(WarehouseEntity oWarehouse)
		{
			using (var db = new InventaryContext())
			{
				db.Warehouses.Update(oWarehouse);
				db.SaveChanges();
			}
		}
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccess;
using Entities;


namespace Business
{
	public class B_Storage
	{
		public List<StorageEntity> StoragetList()
		{
			using (var db = new InventaryContext())
			{
				return db.Storages.ToList();
			}
		}

		public void CreateStorage(StorageEntity oStorage)
		{
			using (var db = new InventaryContext())
			{
				db.Storages.Add(oStorage);
				db.SaveChanges();
			}
		}

		public void UpdateStorage(StorageEntity oStorage)
		{
			using (var db = new InventaryContext())
			{
				db.Storages.Update(oStorage);
				db.SaveChanges();
			}
		}
	}
}

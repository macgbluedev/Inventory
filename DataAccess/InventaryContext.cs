using Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccess
{
	class InventaryContext : DbContext
	{
		public DbSet<ProductEntity> Products { get; set; }
		public DbSet<StorageEntity> Storages { get; set; }
		public DbSet<OperationEntity> Operations { get; set; }
		public DbSet<CategoryEntity> Categories { get; set; }
		public DbSet<WarehouseEntity> Wharehouses { get; set; }
	}
}

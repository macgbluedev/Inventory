using Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace DataAccess
{
	class InventaryContext : DbContext
	{
		public DbSet<ProductEntity> Products { get; set; }
		public DbSet<StorageEntity> Storages { get; set; }
		public DbSet<OperationEntity> Operations { get; set; }
		public DbSet<CategoryEntity> Categories { get; set; }
		public DbSet<WarehouseEntity> Warehouses { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder options)
		{
			if (!options.IsConfigured)
			{
				options.UseSqlServer("Server=localhost\\SQLEXPRESS; Database=InventoryDb;Trusted_Connection=True");
			}
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);

			modelBuilder.Entity<CategoryEntity>().HasData(
				new CategoryEntity
				{
					CategoryId = "ASH",
					CategoryName = "Aseo Hogar"
				},
				new CategoryEntity
				{
					CategoryId = "HGR",
					CategoryName = "Hogar"
				},
				new CategoryEntity
				{
					CategoryId = "SLD",
					CategoryName = "Salud"
				},
				new CategoryEntity
				{
					CategoryId = "VDJ",
					CategoryName = "Videojuegos"
				}
				);

			modelBuilder.Entity<WarehouseEntity>().HasData(
				new WarehouseEntity
				{
					WarehouseId = Guid.NewGuid().ToString(),
					WarehouseName = "Almacén Central",
					WarehouseAdress = "Calle 8 con 23, MAD"
				},
				new WarehouseEntity
				{
					WarehouseId = Guid.NewGuid().ToString(),
					WarehouseName = "Almacén A",
					WarehouseAdress = "Calle 14, MAD"
				}
				);

		}
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ServiceBook.Core.Entities;

namespace ServiceBook.DataAccess;

internal class AppDbContext : DbContext
{
	public DbSet<Vehicle> Vehicles => Set<Vehicle>();
	public DbSet<ConsumableItem> ConsumableItems => Set<ConsumableItem>();
	public DbSet<VehicleConsumable> VehicleConsumables => Set<VehicleConsumable>();

	protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
	{
		optionsBuilder.UseSqlite("Filename=app.db");
	}

	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		//Vehicle
		modelBuilder.Entity<Vehicle>()
			.HasKey(v => v.Id);

		//VehicleConsumable
		modelBuilder.Entity<VehicleConsumable>()
			.HasKey(vc => vc.Id);

		modelBuilder.Entity<VehicleConsumable>()
			.HasOne(vc => vc.Vehicle)
			.WithMany(v => v.Consumables)
			.HasForeignKey(vc => vc.VehicleId);

		modelBuilder.Entity<VehicleConsumable>()
			.HasOne(vc => vc.Consumable)
			.WithMany()
			.HasForeignKey(vc => vc.ConsumableId);

		modelBuilder.Entity<VehicleConsumable>()
			.Ignore(vc => vc.IsActive);

		//ConsumableItem
		modelBuilder.Entity<ConsumableItem>()
			.HasKey(i => i.Id);

		modelBuilder.Entity<ConsumableItem>()
			.HasOne(i => i.ConsumableType)
			.WithMany()
			.HasForeignKey(i => i.ConsumableTypeId);

		//ConsumableType
		modelBuilder.Entity<ConsumableType>()
			.HasKey(ct => ct.Id);
	}
}

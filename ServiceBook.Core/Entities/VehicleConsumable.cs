using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceBook.Core.Entities;

public class VehicleConsumable
{
	public Guid Id { get; set; }
	public Guid VehicleId { get; set; }
	public Vehicle? Vehicle { get; set; }
	public Guid ConsumableId { get; set; }
	public ConsumableItem? Consumable { get; set; }

	public long InstalledAtMilleage { get; set; }
	public long? RemovedAtMilleage { get; set; }
	public bool IsActive => !RemovedAtMilleage.HasValue;
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceBook.Core.Contracts;

namespace ServiceBook.Core.Entities;

public class Vehicle : IAggregationRoot
{
	public Guid Id { get; set; }
	public string Make { get; set; }
	public string Model { get; set; }
	public string? Number { get; set; }
	public string? Vin { get; set; }
	public string? Name { get; set; }
	public long Mileage { get; set; }

	public ICollection<VehicleConsumable> Consumables { get; set; }
}

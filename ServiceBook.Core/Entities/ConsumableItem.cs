using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceBook.Core.ValueObjects;

namespace ServiceBook.Core.Entities;

public class ConsumableItem
{
	public Guid Id { get; set; }
	public string Name { get; set; }
	public string Description { get; set; }
	public decimal Price { get; set; }
	public TimeSpan Mileage { get; set; }

	public Guid ConsumableTypeId { get; set; }
	public ConsumableType? ConsumableType { get; set; }
}

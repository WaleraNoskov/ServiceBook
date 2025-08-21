using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceBook.Core.Dto;

public record BriefVehicleDto(Guid? id, long Mileage, string Make, string Model, string? Number, string? Vin, string? Name);
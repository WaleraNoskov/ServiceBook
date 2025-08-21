using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceBook.Core.ValueObjects;

namespace ServiceBook.Core.Dto;

public record GetAllVehiclesDto(string? Filter, MileageRange MileageRange);

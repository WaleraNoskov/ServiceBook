using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpFunctionalExtensions;
using MediatR;
using ServiceBook.Core.Contracts;
using ServiceBook.Core.Dto;

namespace ServiceBook.Core.Commands.VehiclesManagement;

public record GetAllVehiclesQuery(GetAllVehiclesDto dto) : IRequest<Result<PaginationResult<BriefVehicleDto>>>;

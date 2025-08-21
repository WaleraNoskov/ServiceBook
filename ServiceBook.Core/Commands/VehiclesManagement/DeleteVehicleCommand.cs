using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpFunctionalExtensions;
using MediatR;

namespace ServiceBook.Core.Commands.VehiclesManagement;

public record DeleteVehicleCommand(Guid id) : IRequest<Result>;

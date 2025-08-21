using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace ServiceBook.DataAccess;

public static class DependencyInjection
{
	public static IServiceCollection AddDataAccessServices(this IServiceCollection services)
	{
		services.AddDbContext<AppDbContext>();

		return services;
	}
}

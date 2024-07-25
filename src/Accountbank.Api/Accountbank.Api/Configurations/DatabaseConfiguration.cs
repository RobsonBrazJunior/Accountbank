using Accountbank.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace Accountbank.Api.Configurations;

public static class DatabaseConfiguration
{
	public static void AddDatabaseConfiguration(this IServiceCollection services, IConfiguration configuration)
	{
		if (services is null) throw new ArgumentNullException(nameof(services));

		services.AddDbContext<ApplicationContext>(options => options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));
	}
}

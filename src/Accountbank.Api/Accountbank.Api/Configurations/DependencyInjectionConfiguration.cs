using Accountbank.Application.Interfaces;
using Accountbank.Application.Services;
using Accountbank.Infra.Data.Repository.Interfaces;
using Accountbank.Infra.Data.Repository.Repositories;

namespace Accountbank.Api.Configurations;

public static class DependencyInjectionConfiguration
{
	public static void AddDependencyInjectionConfiguration(this IServiceCollection services)
	{
		if (services == null) throw new ArgumentNullException(nameof(services));

		services.AddScoped<IUnitOfWork, UnitOfWork>();
		services.AddScoped<ITransactionService, TransactionService>();
	}
}

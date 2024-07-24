using Accountbank.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Accountbank.Infra.Data.Context;

public class ApplicationContext(DbContextOptions<ApplicationContext> options) : DbContext(options)
{
	public DbSet<Transaction> Transactions { get; set; }

	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationContext).Assembly);
	}
}

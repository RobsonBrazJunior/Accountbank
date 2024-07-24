using Microsoft.EntityFrameworkCore;

namespace Accountbank.Infra.Data.Context;

public class ApplicationContext(DbContextOptions<ApplicationContext> options) : DbContext(options)
{
	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		throw new NotImplementedException();
	}
}

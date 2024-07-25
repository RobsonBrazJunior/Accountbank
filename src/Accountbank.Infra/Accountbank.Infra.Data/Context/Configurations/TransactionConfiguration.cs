using Accountbank.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Accountbank.Infra.Data.Context.Configurations;

public class TransactionConfiguration : IEntityTypeConfiguration<Transaction>
{
	public void Configure(EntityTypeBuilder<Transaction> builder)
	{
		builder.ToTable("Transactions");
		builder.HasKey(x => x.Id);
		builder.Property(x => x.Date).HasDefaultValueSql("GETDATE()").ValueGeneratedOnAdd().IsRequired();
		builder.Property(x => x.TransactionType).HasConversion<int>().IsRequired();
		builder.Property(x => x.Amount).IsRequired();
		builder.Property(x => x.UserId).IsRequired().HasDefaultValueSql("NEWID()");
	}
}

using Accountbank.Domain.Models;

namespace Accountbank.Shared.Interfaces;

public interface IPdfGenerator
{
	byte[] GeneratePdf(List<Transaction> transactions);
}

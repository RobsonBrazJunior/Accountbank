using Accountbank.Domain.Models;

namespace Accountbank.Application.Interfaces;

public interface ITransactionService : IDisposable
{
	Transaction GetById(Guid id);
	IEnumerable<Transaction> GetAll();
	void Add(Transaction transaction);
	void Update(Transaction transaction);
	void Remove(Transaction transaction);
	byte[] GeneratePdfReport(Guid userId, int days);
    IEnumerable<Transaction> Transactions(Guid userId, int days);
}

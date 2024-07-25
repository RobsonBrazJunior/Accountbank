using Accountbank.Domain.Models;

namespace Accountbank.Application.Interfaces;

public interface ITransactionService : IDisposable
{
	Transaction GetById(Guid id);
	IEnumerable<Transaction> GetAll();
	void Add(Transaction transaction);
	void Update(Transaction transaction);
	void Remove(Transaction transaction);
	IEnumerable<Transaction> GetTransactionsFiltered(Guid userId, int days);
}

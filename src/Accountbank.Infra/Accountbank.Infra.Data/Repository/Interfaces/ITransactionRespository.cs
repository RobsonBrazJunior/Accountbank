using Accountbank.Domain.Models;

namespace Accountbank.Infra.Data.Repository.Interfaces;

public interface ITransactionRespository : IGenericRepository<Transaction>
{
	IQueryable<Transaction> GetTransactions(Guid userId);
}

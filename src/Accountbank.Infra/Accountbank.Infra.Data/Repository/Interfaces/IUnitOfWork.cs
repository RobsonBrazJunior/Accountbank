namespace Accountbank.Infra.Data.Repository.Interfaces;

public interface IUnitOfWork : IDisposable
{
	ITransactionRespository TransactionRespository { get; }
	int Save();
}

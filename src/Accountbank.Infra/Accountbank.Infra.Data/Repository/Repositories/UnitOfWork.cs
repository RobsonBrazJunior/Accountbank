using Accountbank.Infra.Data.Context;
using Accountbank.Infra.Data.Repository.Interfaces;

namespace Accountbank.Infra.Data.Repository.Repositories
{
	public class UnitOfWork(ApplicationContext context) : IUnitOfWork
	{
		private ITransactionRespository _transactionRespository;

		public ITransactionRespository TransactionRespository
		{
			get
			{
				return _transactionRespository ??= new TransactionRepository(context);
			}
		}

		public int Save()
		{
			return context.SaveChanges();
		}

		public void Dispose()
		{
			context.Dispose();
			GC.SuppressFinalize(this);
		}
	}
}

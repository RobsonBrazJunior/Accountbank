using Accountbank.Domain.Models;
using Accountbank.Infra.Data.Context;
using Accountbank.Infra.Data.Repository.Interfaces;

namespace Accountbank.Infra.Data.Repository.Repositories;

public class TransactionRepository(ApplicationContext context) : GenericRepository<Transaction>(context), ITransactionRespository
{
}

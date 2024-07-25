using Accountbank.Application.Interfaces;
using Accountbank.Domain.Models;
using Accountbank.Infra.Data.Repository.Interfaces;

namespace Accountbank.Application.Services;

public class TransactionService(IUnitOfWork unitOfWork) : ITransactionService
{
	private readonly IUnitOfWork _unitOfWork = unitOfWork;

	public Transaction GetById(Guid id)
	{
		return _unitOfWork.TransactionRespository.GetById(id);
	}

	public IEnumerable<Transaction> GetTransactionsFiltered(Guid userId, int days)
	{
		var startDate = DateTime.Now.AddDays(-days);
		return _unitOfWork.TransactionRespository.GetTransactions(userId).Where(t => t.Date >= startDate).ToList();
	}

	public IEnumerable<Transaction> GetAll()
	{
		return _unitOfWork.TransactionRespository.GetAll();
	}

	public void Add(Transaction transaction)
	{
		_unitOfWork.TransactionRespository.Add(transaction);
		_unitOfWork.Save();
	}

	public void Update(Transaction transaction)
	{
		_unitOfWork.TransactionRespository.Update(transaction);
		_unitOfWork.Save();
	}

	public void Remove(Transaction transaction)
	{
		_unitOfWork.TransactionRespository.Remove(transaction);
		_unitOfWork.Save();
	}

	public void Dispose()
	{
		GC.SuppressFinalize(this);
	}
}

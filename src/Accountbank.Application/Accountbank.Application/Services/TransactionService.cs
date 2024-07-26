using Accountbank.Application.Interfaces;
using Accountbank.Domain.Models;
using Accountbank.Infra.Data.Repository.Interfaces;
using Accountbank.Shared.Interfaces;

namespace Accountbank.Application.Services;

public class TransactionService(IUnitOfWork unitOfWork, IPdfGenerator pdfGenerator) : ITransactionService
{
	private readonly IUnitOfWork _unitOfWork = unitOfWork;
	private readonly IPdfGenerator _pdfGenerator = pdfGenerator;

	public Transaction GetById(Guid id)
	{
		return _unitOfWork.TransactionRespository.GetById(id);
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

    public IEnumerable<Transaction> Transactions(Guid userId, int days)
    {
        var startDate = DateTime.Now.AddDays(-days);
        return _unitOfWork.TransactionRespository.GetTransactions(userId).Where(t => t.Date >= startDate).ToList();
    }

    public byte[] GeneratePdfReport(Guid userId, int days)
	{
		var startDate = DateTime.Now.AddDays(-days);
		var transactions = _unitOfWork.TransactionRespository.GetTransactions(userId).Where(t => t.Date >= startDate).ToList();
		return _pdfGenerator.GeneratePdf(transactions);
	}

	public void Dispose()
	{
		GC.SuppressFinalize(this);
	}
}

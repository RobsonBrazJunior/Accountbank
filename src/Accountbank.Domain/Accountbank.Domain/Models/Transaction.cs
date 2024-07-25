using Accountbank.Domain.Enums;

namespace Accountbank.Domain.Models;

public class Transaction
{
	public Guid Id { get; set; }
	public DateTime Date { get; set; }
	public TransactionType TransactionType { get; set; }
	public decimal Amount { get; set; }
	public Guid UserId { get; set; }
}

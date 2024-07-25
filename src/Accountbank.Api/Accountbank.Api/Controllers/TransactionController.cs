using Accountbank.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Accountbank.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class TransactionController(ITransactionService transactionService) : ControllerBase
{
	private readonly ITransactionService _transactionService = transactionService;

	[HttpGet("export")]
	public IActionResult ExportTransactions(Guid userId, int days)
	{
		var pdfBytes = _transactionService.GeneratePdfReport(userId, days);
		return File(pdfBytes, "application/pdf", "extrato.pdf");
	}
}

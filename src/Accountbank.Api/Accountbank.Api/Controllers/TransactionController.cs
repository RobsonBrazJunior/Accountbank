using Accountbank.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Accountbank.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class TransactionController(ITransactionService transactionService) : ControllerBase
{
	private readonly ITransactionService _transactionService = transactionService;

    [HttpGet()]
    public IActionResult GetTransactions(int days)
    
    {
        var result= _transactionService.Transactions(Guid.NewGuid(), days);
        return new JsonResult(result);
    }

    [HttpGet("export")]
	public IActionResult ExportTransactions(int days)
	{
		var pdfBytes = _transactionService.GeneratePdfReport(Guid.NewGuid(), days);
		return File(pdfBytes, "application/pdf", "extrato.pdf");
	}
}

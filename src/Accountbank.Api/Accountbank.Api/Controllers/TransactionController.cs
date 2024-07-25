using Accountbank.Application.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Accountbank.Api.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class TransactionController(ITransactionService transactionService) : ControllerBase
	{
		private readonly ITransactionService _transactionService = transactionService;

		[HttpGet("get-transactions-filtered/{id:guid}/{days:int}")]
		public IActionResult GetTransactionsFiltered(Guid id, int days)
		{
			return Ok(_transactionService.GetTransactionsFiltered(id, days));
		}
	}
}

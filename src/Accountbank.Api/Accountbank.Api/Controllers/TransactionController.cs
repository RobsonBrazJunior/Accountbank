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

		[HttpGet("get-by-id/{id:guid}")]
		public IActionResult GetById(Guid id)
		{
			return Ok(_transactionService.GetById(id));
		}
	}
}

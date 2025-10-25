using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TestIDS_Lawryan.Data;
using TestIDS_Lawryan.Models;

namespace TestIDS_Lawryan.Controllers
{
    [ApiController]
    [Route("api/transactions")]
    public class TransactionController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public TransactionController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllData()
        {
            var transactions = await _context.TrTransaction.ToListAsync();

            var statuses = await _context.MsStatus.ToListAsync();

            var response = new TransactionResponse
            {
                Data = transactions,
                Status = statuses
            };

            return Ok(response);
        }
    }
}
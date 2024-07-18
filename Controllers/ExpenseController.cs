using Microsoft.AspNetCore.Mvc;

namespace HaveFun02.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ExpenseController : ControllerBase
    {
          private readonly ExpenseContext _context, ILogger<ExpenseController> _logger;


        public EmployeesController(ExpenseContext context,ILogger<ExpenseController> logger)
        {
            _context = context;
             _logger = logger;
        }

       
        public ExpenseController()
        {
           
        }

        [HttpGet(Name = "GetExpense")]
        public IEnumerable<Expense> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new Expense
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}

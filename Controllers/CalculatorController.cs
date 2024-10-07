using Microsoft.AspNetCore.Mvc;
using ToDoListAPI.Interfaces;

namespace ToDoListAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CalculatorController : ControllerBase
    {
        private readonly ICalculatorService _calculatorService;

        public CalculatorController(ICalculatorService calculatorService)
        {
            _calculatorService = calculatorService;
        }

        [HttpGet("add")]
        public ActionResult<double> Add(double a, double b) => _calculatorService.Add(a, b);

        [HttpGet("subtract")]
        public ActionResult<double> Subtract(double a, double b) => _calculatorService.Subtract(a, b);

        [HttpGet("multiply")]
        public ActionResult<double> Multiply(double a, double b) => _calculatorService.Multiply(a, b);

        [HttpGet("divide")]
        public ActionResult<double> Divide(double a, double b)
        {
            if (b == 0) return BadRequest("Cannot divide by zero.");
            return _calculatorService.Divide(a, b);
        }
    }
}

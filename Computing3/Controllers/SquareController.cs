using Computing3.Formula.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Computing3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SquareController : ControllerBase
    {
        private readonly ICalculateSquare calculateSquare;

        public SquareController(ICalculateSquare calculateSquare)
        {
            this.calculateSquare = calculateSquare;
        }

        [HttpGet("{number}")]
        public IActionResult GetSquare(int number)
        {
            int square = calculateSquare.Square(number);
            return Ok(square);
        }
    }
}

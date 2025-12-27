using Microsoft.AspNetCore.Mvc;

namespace HomeWork.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CalculatorController : Controller
{
    [HttpGet("add")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public IActionResult Add([FromQuery] double a, [FromQuery] double b)
    {
        return Ok(a + b);
    }

    [HttpPost("subtract")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public IActionResult Subtract([FromQuery] double a,[FromQuery] double b)
    {
        return Ok(a - b);
    }

    [HttpPut("multiply/{a}/{b}")]
    [ProducesResponseType(StatusCodes.Status300MultipleChoices)]
    public IActionResult Multiply(double a, double b)
    {
        return StatusCode(StatusCodes.Status300MultipleChoices, a * b);
    }

    [HttpPatch("divide/{a}/{b}")]
    [ProducesResponseType(StatusCodes.Status300MultipleChoices)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public IActionResult Divide(double a, double b)
    {
        if (b == 0)
        {
            return BadRequest("На нуль делить нельзя");
        }

        return StatusCode(StatusCodes.Status300MultipleChoices, a / b);
    }
}
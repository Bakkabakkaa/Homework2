using Microsoft.AspNetCore.Mvc;

namespace HomeWork.Controllers;

[ApiController]
[Route("api/[controller]")]
public class СalculatorController : Controller
{
    [HttpGet("add")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public IActionResult Add([FromQuery] double a, [FromQuery] double b)
    {
        return Ok(a + b);
    }

    [HttpPost("substract")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public IActionResult Substract([FromQuery] double a,[FromQuery] double b)
    {
        return Ok(a - b);
    }
}
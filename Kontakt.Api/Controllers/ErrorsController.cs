using Microsoft.AspNetCore.Mvc;

namespace Kontakt.Api.Controllers;

public class ErrorsController : ControllerBase
{
    [Route("error")]
    public IActionResult Error()
    {
        return Problem();
    }
}
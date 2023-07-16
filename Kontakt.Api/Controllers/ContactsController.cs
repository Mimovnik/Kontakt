using Microsoft.AspNetCore.Mvc;

namespace Kontakt.Api.Controllers;

[Route("[controller]")]
public class ContactsController : ApiController
{
    [HttpGet]
    public IActionResult ListContacts()
    {
        return Ok(Array.Empty<string>());
    }
}
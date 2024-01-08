using Microsoft.AspNetCore.Mvc;

namespace sayHelloEndPoint.Controllers;

[ApiController]
[Route("api/[controller]")]
public class SayHelloController : ControllerBase
{
    [HttpGet]
    [Route("GetName/{userInput}")]

    public string GetName(string userInput)
    {
        return ("Salut " + userInput);
    }

}

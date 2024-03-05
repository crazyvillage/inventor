using CrazyVillage.Inventor.Infrastructure;
using Microsoft.AspNetCore.Mvc;

namespace CrazyVillage.Inventor.API.Controllers;

[ApiController]
[Route("hello-world")]
public class HelloWorldController(HelloWorldContext context) : ControllerBase
{
    [HttpGet]
    public string Get()
    {
        return context.Labels.Single().Text;
    }
}
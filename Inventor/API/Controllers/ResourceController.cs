using Microsoft.AspNetCore.Mvc;
using CrazyVillage.Inventor.API.Application.Views;

namespace CrazyVillage.Inventor.API.Controllers;

[ApiController]
[Route("resource")]
public class ResourceController : ControllerBase
{
    [HttpGet]
    public List<ResourceSummary> ListResources()
    {
        return new List<ResourceSummary>();
    }
}
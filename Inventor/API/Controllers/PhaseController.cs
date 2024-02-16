using Microsoft.AspNetCore.Mvc;
using Inventor.API.Application.Views;

namespace Inventor.API.Controllers;

[ApiController]
[Route("phase")]
public class PhaseController : ControllerBase
{
    [HttpGet]
    public List<PhaseSummary> ListPhases()
    {
        return new List<PhaseSummary>();
    }
}
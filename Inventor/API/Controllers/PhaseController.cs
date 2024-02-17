using Microsoft.AspNetCore.Mvc;
using CrazyVillage.Inventor.API.Application.Views;

namespace CrazyVillage.Inventor.API.Controllers;

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
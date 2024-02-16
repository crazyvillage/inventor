using Microsoft.AspNetCore.Mvc;
using CrazyVillage.Inventor.API.Application.Views;

namespace CrazyVillage.Inventor.API.Controllers;

[ApiController]
[Route("game")]
public class GameController : ControllerBase
{
    [HttpGet]
    public List<GameSummary> ListGames()
    {
        return new List<GameSummary>();
    }
}
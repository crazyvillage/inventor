using Microsoft.AspNetCore.Mvc;
using Inventor.API.Application.Views;

namespace Inventor.API.Controllers;

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
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TeamPulse.Data;

namespace TeamPulse.Controllers;

[ApiController]
[Route("api/setup")]
public class SetupController : ControllerBase
{
    private readonly TeamPulseDbContext _context;

    public SetupController(
        TeamPulseDbContext context)
    {
        _context = context;
    }

    [HttpGet("teams")]
    public async Task<IActionResult> GetTeams()
    {
        var teams = await _context.Teams
            .OrderBy(x => x.TeamName)
            .ToListAsync();

        return Ok(teams);
    }

    [HttpGet("categories")]
    public async Task<IActionResult> GetCategories()
    {
        var categories = await _context.Categories
            .OrderBy(x => x.CategoryName)
            .ToListAsync();

        return Ok(categories);
    }
}
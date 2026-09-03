using Microsoft.EntityFrameworkCore;
using TeamPulse.Models;

namespace TeamPulse.Data;

public class TeamPulseDbContext : DbContext
{
    public TeamPulseDbContext(
        DbContextOptions<TeamPulseDbContext> options)
        : base(options)
    {
    }

    public DbSet<Team> Teams { get; set; }

    public DbSet<Category> Categories { get; set; }

    public DbSet<Interruption> Interruptions { get; set; }
}
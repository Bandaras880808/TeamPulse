using TeamPulse.Models;

namespace TeamPulse.Data;

public static class SeedData
{
    public static async Task SeedAsync(
        TeamPulseDbContext context)
    {
        if (!context.Teams.Any())
        {
            context.Teams.AddRange(

                new Team { TeamName = "Retail", Emoji = "🛍️" },
                new Team { TeamName = "Ecomm", Emoji = "🛒" },
                new Team { TeamName = "Omni", Emoji = "🔀" },
                new Team { TeamName = "Money", Emoji = "💰" },
                new Team { TeamName = "SCL", Emoji = "🚚" },
                new Team { TeamName = "Integration", Emoji = "🔗" },
                new Team { TeamName = "Stores", Emoji = "🏬" }
            );
        }

        if (!context.Categories.Any())
        {
            context.Categories.AddRange(

                new Category { CategoryName = "Executive", Emoji = "👑" },
                new Category { CategoryName = "Project Manager", Emoji = "📋" },
                new Category { CategoryName = "Portfolio Manager", Emoji = "📊" },
                new Category { CategoryName = "Support Team", Emoji = "🎧" },
                new Category { CategoryName = "External To IT", Emoji = "🌐" },
                new Category { CategoryName = "Developer", Emoji = "💻" },
                new Category { CategoryName = "QA", Emoji = "🐞" }

            );
        }

        await context.SaveChangesAsync();
    }
}
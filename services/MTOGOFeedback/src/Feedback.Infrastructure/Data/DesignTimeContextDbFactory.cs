using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Feedback.Infrastructure.Data;

public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<ReviewContext>
{
    public ReviewContext CreateDbContext(string[] args)
    {
        //TODO: Move connection string to appsettings.json
        var optionsBuilder = new DbContextOptionsBuilder<ReviewContext>();
        optionsBuilder.UseSqlServer("Server=mssql-restaurant;Database=MTOGOReviews;User Id=sa;Password=thisIsSuperStrong1234;TrustServerCertificate=True");

        return new ReviewContext(optionsBuilder.Options);
    }
}
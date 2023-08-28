using Microsoft.EntityFrameworkCore;

namespace Practice.DataLayer;

public class EfCoreContext: DbContext
{
    protected void OnConfiguration(DbContextOptionsBuilder optionsBuilder) =>
                    optionsBuilder.UseNpgsql("");
}
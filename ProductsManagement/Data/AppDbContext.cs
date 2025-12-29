using Microsoft.EntityFrameworkCore;

namespace ProductsManagement.Data
{
    public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
    {
    }
}

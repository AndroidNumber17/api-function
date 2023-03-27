using Microsoft.EntityFrameworkCore;
using ServerlessApi.Models;

namespace ServerlessApi.Database;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
        
    }
    
    public DbSet<Car> Car { get; set; }
}
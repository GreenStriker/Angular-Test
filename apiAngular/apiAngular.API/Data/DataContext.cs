using apiAngular.API.Models;
using Microsoft.EntityFrameworkCore;

namespace apiAngular.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) :base (options) {}
        
        public DbSet<Value> Value { set; get;}
    }
}
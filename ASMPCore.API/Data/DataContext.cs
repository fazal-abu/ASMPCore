using ASMPCore.API.Models;
using Microsoft.EntityFrameworkCore;

namespace ASMPCore.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Value> Values { get; set; }
    }
}
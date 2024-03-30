using Crud_EntityFramework.Models;
using Microsoft.EntityFrameworkCore;

namespace Crud_EntityFramework.DAL
{
    public class InfnetDbContext : DbContext
    {
        public InfnetDbContext(DbContextOptions options ): base(options) { 
        
        }
        public DbSet<Computadores> Computadores { get; set;}
       
    }
}

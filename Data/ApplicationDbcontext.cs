using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Data
{
    public class ApplicationDbcontext: DbContext 

    {
        public DbSet<Employee>Employees { get; set; }  
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=.\\SQLEXPRESS;database= mvc1;trusted_connection=true;TrustServercertificate=True");
        }
    }
}

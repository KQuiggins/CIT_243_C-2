using Microsoft.EntityFrameworkCore;
using MVC_APP.Models;

namespace MVC_APP.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)  : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }


    }
}

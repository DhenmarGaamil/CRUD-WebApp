using Microsoft.EntityFrameworkCore;
using Group1Pro.Models;

namespace Group1Pro.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {


        }
        public DbSet<Subject> Subjects { get; set; }
    }
}

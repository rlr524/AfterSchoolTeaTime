using AfterSchoolTeaTimeWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace AfterSchoolTeaTimeWeb.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {
        }
        // The ? makes Category nullable, which is the equivalent to making a type an Optional in Swift
        public DbSet<Category> Categories { get; set; }
    }
}


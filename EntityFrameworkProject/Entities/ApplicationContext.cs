using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkProject.Entities
{
    public class ApplicationContext: DbContext
    {
        public ApplicationContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Student> Students { get; set; }
    }
}

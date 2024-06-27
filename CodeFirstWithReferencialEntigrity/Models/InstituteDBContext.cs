using Microsoft.EntityFrameworkCore;

namespace CodeFirstWithReferencialEntigrity.Models
{
    public class InstituteDBContext:DbContext
    {
        public InstituteDBContext()
        {
            
        }

        public InstituteDBContext(DbContextOptions options):base (options)
        {
            
        }

        public DbSet<Course> CoursesTable { get; set; }
        public DbSet<Topic> TopicsTable { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=CDACLAB-127;Initial Catalog=InstituteDB;Integrated Security=True");
            base.OnConfiguring(optionsBuilder);
        }
    }
}

using Computing3.Models.Student;
using Microsoft.EntityFrameworkCore;


namespace Computing3.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Student> students {  get; set; }       
    }
}

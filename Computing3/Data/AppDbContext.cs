using Computing3.Models.Student;
using Microsoft.EntityFrameworkCore;


namespace Computing3.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Student> Students {  get; set; }       
        public DbSet<Bill> Bills {  get; set; }       
        public DbSet<BookRent> BookRents {  get; set; }       
        public DbSet<Teacher> Teachers {  get; set; }       
    }
}

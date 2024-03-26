using Computing3.Data;
using Computing3.Models.Student;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Computing3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly AppDbContext dbContext;

        public StudentController(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpPost]
        public async Task<IActionResult> CreateStudent(Student request)
        {
            var AddStudent = new Student()
            {
                Name = request.Name,
                Hobby = request.Hobby
            };

            await dbContext.students.AddAsync(AddStudent);
            await dbContext.SaveChangesAsync();

            return Ok(AddStudent);
        }
    }
}

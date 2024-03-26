using Computing3.Data;
using Computing3.Models.DTO;
using Computing3.Models.Student;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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
        public async Task<IActionResult> CreateStudent(StudentDto request)
        {
            //mapping DTO to Student Class
            var AddStudent = new Student()
            {
                Name = request.Name,
                Hobby = request.Hobby
            };
            
            await dbContext.Students.AddAsync(AddStudent);
            await dbContext.SaveChangesAsync();

            return Ok(AddStudent);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllStudent()
        {
            var a = await dbContext.Students.ToListAsync();            

            return Ok(a);
        }
    }
}

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

        [HttpPost("Register")]
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
            //Returns all students
            var a = await dbContext.Students.ToListAsync();

            //Returns student that has name Ram
            var b = await dbContext.Students.Where(x => x.Name == "Ram").ToListAsync();

            //Returns students apart from that specific LMUID and Orders by Name in Ascending 
            var c = await dbContext.Students.Where(x => x.LMUID != 19030694).OrderBy(x=> x.Name).ToListAsync();
            return Ok(a);
        }
        
    }
}

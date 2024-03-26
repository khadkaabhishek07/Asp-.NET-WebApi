using System.ComponentModel.DataAnnotations;

namespace Computing3.Models.Student
{
    public class BookRent
    {
        [Key]
        public int BookId { get; set; }
        public string Title { get; set; }
        public DateOnly Rented_Date { get; set; }
        public int StudentId { get; set; }
        public Student Student { get; set; }
    }
}

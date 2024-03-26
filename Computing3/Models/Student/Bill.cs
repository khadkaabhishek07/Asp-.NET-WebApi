using System.ComponentModel.DataAnnotations;

namespace Computing3.Models.Student
{
    public class Bill
    {
        [Key]
        public int Bill_ID { get; set; }        
        public DateOnly Issued_Date { get; set; }
        public int StudentId { get; set; }
        public Student Student { get; set; }
    }
}

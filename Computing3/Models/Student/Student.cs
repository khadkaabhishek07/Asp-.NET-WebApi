using System.ComponentModel.DataAnnotations;

namespace Computing3.Models.Student
{
    public class Student
    {
        [Key]
        public int LMUID { get; set; }
        [Required]
        public string Name { get; set; }
        public string Hobby { get; set; }    
        public Bill Bill { get; set; }
        public List<BookRent> BookRents { get; set; }
        public List<Teacher> Teachers { get; set; }

    }
}

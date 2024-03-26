using System.ComponentModel.DataAnnotations;

namespace Computing3.Models.Student
{
    public class Student
    {
        [Key]
        public int LMUID { get; set; }
        public string Name { get; set; }
        public string Hobby { get; set; }        

    }
}

using System.ComponentModel.DataAnnotations;

namespace StudentManagementAPI.Models
{
    public class Student
    {
        public int id { get; set; }

        [Required] public string name { get; set; } = " ";
        
        [Range(18,60)] public int age { get; set; }
        
        [Required] public string major { get; set; } = " ";
        
        [Range(0,4)] public double GPA { get; set; }
    }
}

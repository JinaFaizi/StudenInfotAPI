using Microsoft.AspNetCore.Mvc;
using StudentManagementAPI.Models;

namespace StudentManagementAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class StudentsController : ControllerBase
{
    
    private static List<Student> students = new()
    {
        new Student
        {
            id = 1,
            name = "Jina1",
            age = 21,
            major = "Computer Engineering",
            GPA = 3.8
        },
        
        new Student
        {
            id = 2,
            name = "Jina2",
            age = 22,
            major = "Computer Sience",
            GPA = 3.9
            
        }

    };
    [HttpGet("{id}")]
    public ActionResult<Student> GetStudent(int id)
    {
        var student = students.FirstOrDefault(s => s.id == id);

        if (student == null)
        {
            return NotFound();
        }

        return Ok(student);
    }
}



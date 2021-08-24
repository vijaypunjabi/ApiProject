using ApiProject.Models;
using ApiProject.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ApiProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentServices _studentServices;

        public StudentController(IStudentServices studentServices)
        {
            _studentServices = studentServices;
        }

        [HttpGet]
        [Route("Get")]
        [Produces(typeof(IEnumerable<Student>))]
        public async Task<IActionResult> GetStudents()
        {
            IEnumerable<Student> students = await _studentServices.GetStudents();
            return Ok(students);
        }

        [HttpGet]
        [Route("GetById/{Id}")]
        [Produces(typeof(Student))]
        public async Task<IActionResult> GetStudentById (int Id)
        {
            Student student = await _studentServices.GetStudentById(Id);
            return Ok(student);
        }

        [HttpPost]
        [Route("Add")]
        [Produces(typeof(Student))]
        public IActionResult AddStudent (Student student)
        {
            Student _student = _studentServices.AddStudent(student);
            return Ok(_student);
        }

        [HttpPut]
        [Route("Update")]
        [Produces(typeof(Student))]
        public async Task<IActionResult> UpdateStudent (Student student)
        {
            Student _student = await _studentServices.UpdateStudent(student);
            return Ok(_student);
        }

        [HttpDelete]
        [Route("Delete/{id}")]
        [Produces(typeof(bool))]
        public async Task<IActionResult> DeleteStudent(int id)
        {
            bool isDeleted = await _studentServices.DeleteStudent(id);
            return Ok(isDeleted);
        }


    }
}

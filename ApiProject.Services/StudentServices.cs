using ApiProject.Database.Repositories;
using ApiProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiProject.Services
{
    public interface IStudentServices
    {
        Task<IEnumerable<Student>> GetStudents();
        Task<Student> GetStudentById(int id);
        Task<bool> DeleteStudent(int id);
        Task<Student> UpdateStudent(Student student);
        Student AddStudent(Student student);
    }
    public class StudentServices : IStudentServices
    {
        private readonly IStudentRepository _studentRepository;
         public StudentServices(IStudentRepository studentRepository)
         {
            _studentRepository = studentRepository;
         }
    
    
        public Student AddStudent(Student student)
        {
            _studentRepository.Add(student);
            return student;
        }

        public async Task<bool> DeleteStudent(int id)
        {
            Student student = await GetStudentById(id);
            if(student != null)
            {
                _studentRepository.Delete(student);
                return true;
            }
            return false;
        }

        public async Task<Student> GetStudentById(int id)
        {
             return await _studentRepository.GetById(id);
        }

        public async Task<IEnumerable<Student>> GetStudents()
        {
            return await _studentRepository.Get();
        }

        public async Task<Student> UpdateStudent(Student student)
        {
            Student _student = await GetStudentById(student.Id);
            if(_student != null)
            {
                _student.Name = student.Name;
                _student.Age = student.Age;
                _student.SubjectId = student.SubjectId;
                _studentRepository.Update(_student);
            }
            return _student;
        }
    }
}

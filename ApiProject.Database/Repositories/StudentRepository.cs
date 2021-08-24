using ApiProject.Database.Infrastructure;
using ApiProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiProject.Database.Repositories
{
    public interface IStudentRepository : IRepository <Student>
    {


    }
    public class StudentRepository : Repository<Student>, IStudentRepository
    {
        public StudentRepository(ApiProjectContext apiProjectContext) : base(apiProjectContext)
        {


        }
    }

}





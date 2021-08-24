using ApiProject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiProject.Database
{
    public class ApiProjectContext :DbContext
    {
        public ApiProjectContext(DbContextOptions options) :base(options)
        {

        }
        public DbSet <Student> Students { get; set; }
        public DbSet<UserLogin> UserLogins { get; set; }
    }
}

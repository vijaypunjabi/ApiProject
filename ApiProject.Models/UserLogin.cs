using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiProject.Models
{
    [Table("UserLogin")]
    public class UserLogin
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        public string Password { get; set; }
    }
}

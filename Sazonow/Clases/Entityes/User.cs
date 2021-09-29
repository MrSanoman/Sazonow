using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.EntityFramework;

namespace Sazonow.Clases.Entityes
{
    public class User
    {
        [Key]
        public int id { get; set; }
        [Required, MaxLength(64)]
        public string FirstName { get; set; }
        [Required, MaxLength(64)]
        public string SecondName { get; set; }
        [Required, MaxLength(64)]
        public string LastName { get; set; }
        [Required, MaxLength(64)]
        public string Login { get; set; }
        [Required, MaxLength(32), Index(IsUnique = true)]
        public string Pass { get; set; }
        
    }
}
    


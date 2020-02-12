using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Survey_2._0.Model
{
    class User
    {

       // [Required]
        public int Id { get; set; }
       // [Required]
        public string Name { get; set; }
       // [Required]
        public string Surname { get; set; }
       // [Required]
        public string Email { get; set; }
      //  [Required]
        public string Phone { get; set; }
        public DateTime BirthDate { get; set; }

        public override string ToString()
        {
            return $"{Name} {Surname}";
        }
    }
}


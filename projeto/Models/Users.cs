using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace projeto.Models
{
    public class Users
    {
        public long Id { get; set; }

       
        public string Name { get; set; }

       
        public string PassWord { get; set; }


        public string Email { get; set; }


        public string Phone { get; set; }

       
        public DateTime Birthday { get; set; }

        public string Address { get; set; }

        [Required(ErrorMessage = "Campo obrigatório!")]
        public string City { get; set; }

        [Required(ErrorMessage = "Campo obrigatório!")]
        public int Number { get; set; }
        public bool excluded { get; set; }
    }
}

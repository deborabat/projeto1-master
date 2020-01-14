using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace projeto1.Models
{
    public class Users
    {
        public long Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Campo obrigatório!")]
        [MinLength(6, ErrorMessage = "A senha deve ter mais que 6 caracteres")]
        public string PassWord { get; set; }

        [Required(ErrorMessage = "Campo obrigatório!")]
        public string Email { get; set; }


        public string Phone { get; set; }

        [DataType(DataType.Date)]
        public DateTime Birthday { get; set; }

        [Required(ErrorMessage = "Campo obrigatório!")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Campo obrigatório!")]
        public string City { get; set; }

        [Required(ErrorMessage = "Campo obrigatório!")]
        public int Number { get; set; }

        public bool excluded { get; set; }
    }
}


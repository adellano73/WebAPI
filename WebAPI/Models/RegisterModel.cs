using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Validation;

namespace WebAPI.Models
{
    public class RegisterModel
    {
        [Required, FirstName, MaxLength(50)]
        public string FirstName { get; set; }

        [Required, LastName, MaxLength(50)]
        public string LastName { get; set; }

        [Required, Username, MinLength(8)]
        public string Username { get; set; }

        [Required, EmailAddress, MaxLength(256)]
        public string Email { get; set; }

        [Required, Password, MaxLength(256)]
        public string Password { get; set; }
    }
}

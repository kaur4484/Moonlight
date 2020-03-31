using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RK_LAB1.Models
{
    public class User
    {
        [Required (ErrorMessage ="Please Enter your Username")]
        public string Username { get; set; }

        [Required(ErrorMessage ="Please Enter your password")]
        protected string Password { get; set; }

    }
}

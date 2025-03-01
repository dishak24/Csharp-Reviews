using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Review4
{
    internal class Data
    {
        [Required(ErrorMessage = "Email is Required.")]
        [RegularExpression(@"^[a-zA-Z0-9]+([._-][0-9a-zA-Z]+)*@[a-zA-Z0-9]+([.-][0-9a-zA-Z]+)*\.[a-zA-Z]{2,}$", 
                                ErrorMessage = "Email must in proper format!")]
        public string Email { get; set; }



        [Required(ErrorMessage = "Password is Required.")]
        [PasswordPropertyText]
        [RegularExpression(@"^(.*[A-Z])(.*[a-z])(.*\d)(.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$", 
                                ErrorMessage = "Password must contain at least one uppercase letter, one lowercase letter, one number, and one special character. and atleast 8 digit password !")]
        public string Password { get; set; }



    }
}

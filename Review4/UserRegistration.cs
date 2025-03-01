using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Review4
{
    public class UserRegistration
    {
        [Required(ErrorMessage = "Name is required.")]
        [RegularExpression(@"^[a-z]{2,}$",
                            ErrorMessage = "Name must be atleast 2 characters long.")]
        public string Name { get; set; }


        [Required(ErrorMessage = "Email is Required.")]
        [RegularExpression(@"^[a-zA-Z0-9]+([._-][0-9a-zA-Z]+)*@[a-zA-Z0-9]+([.-][0-9a-zA-Z]+)*\.[a-zA-Z]{2,}$",
                                ErrorMessage = "Email must in proper format!")]
        public string Email { get; set; }


        [Required(ErrorMessage = "Age is Required.")]
        [Range(18,50,ErrorMessage = "Age must in 18 - 50 !")]
        public int Age { get; set; }


    }
}

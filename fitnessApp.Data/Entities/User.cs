using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace fitnessApp.Data.Entities
{
    public class User
    {
        [Key]
        public int Id {get; set;}
        [Required]
        public string Username {get; set;}
        [Required]
        public string Password {get; set;}

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace fitnessApp.Models.UserModels
{
    public class UserUpdate
    {
        public int Id {get; set;}
        public string Username {get; set;}
        public string Password {get; set;}
        public string NewUsername {get; set;}
        public string NewPassword {get; set;}
    }
}
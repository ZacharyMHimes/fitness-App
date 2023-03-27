using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace fitnessApp.Data.Entities
{
    public class LogBook
    {
        [Key]
        public int Id {get; set;}
        [Required]
        public string Name {get; set;}
        [Required]
        public DateTime CreatedUtc {get; set;}

        [Required]
        public int UserId {get; set;}
        
        public List<Log> Logs {get; set;}


    }
}
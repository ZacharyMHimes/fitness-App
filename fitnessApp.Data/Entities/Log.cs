using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace fitnessApp.Data.Entities
{
public class Log
{
        [Key]
        public int Id {get; set;}
        [Required]
        public DateTime CreatedUtc {get; set;}

// AM STATS
        public int Morning_Weight {get; set;}
        public string AM_Meal {get; set;}
        public int AM_KCALS {get; set;}
        public int AM_KCALS_2 {get; set;}
        public int AM_Protein {get; set;}

// Noon STATS

        public string Noon_Meal {get; set;}
        public int Noon_KCALS {get; set;}
        public int Noon_KCALS_2 {get; set;}
        public int Noon_Protein {get; set;}

// PM STATS
        public string PM_Meal {get; set;}
        public int PM_KCALS {get; set;}
        public int PM_KCALS_2 {get; set;}
        public int PM_Protein {get; set;}
        public int Evening_Weight {get; set;}

// Progress Pic:
        public string ProgressPicURL {get; set;}

}
}
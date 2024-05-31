using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OnlineBloodBank.Models
{
    public class City
    {
        public int CityID { get; set; }
        [Required(ErrorMessage ="City Name is Required")]
        [Display(Name ="CityName")]
        public string CityName { get; set; } 
    }
}
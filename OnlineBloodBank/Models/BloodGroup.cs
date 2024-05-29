using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OnlineBloodBank.Models
{
    public class BloodGroup
    {
        public int BloodGroupId { get; set; }
        [Required(ErrorMessage ="Blood Group is Reuired")]
        [Display(Name = "Blood Type")]
        public string BloodGroupName {get;set;}
    }
}
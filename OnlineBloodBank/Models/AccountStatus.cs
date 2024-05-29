using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OnlineBloodBank.Models
{
    public class AccountStatus
    {
        
        public int AccountStatusId { get; set; }
        [Required(ErrorMessage ="Account Status is Required")]
        [Display(Name ="Account Status")]
        public string AccountStatusName { get; set; }

    }
}
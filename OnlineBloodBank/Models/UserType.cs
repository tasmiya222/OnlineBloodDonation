using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OnlineBloodBank.Models
{
    public class UserType
    {
        public int UserTypeId { get; set; }
        [Required(ErrorMessage ="UserType is Requied")]
        [Display(Name = "User Type")]

        public string UserTypeName { get; set; }
    }
}
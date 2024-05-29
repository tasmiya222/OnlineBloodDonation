    using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OnlineBloodBank.Models
{
    public class RequestType
    { 
        public int RequestTypeID { get; set; }

        [Required(ErrorMessage ="Request Type is Required")]
        [Display(Name ="Request Type")]
        public string RequestTypes { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineBloodBank.Models
{
    public class Hospital
    {
        public int HospitalID { get; set; }
        public string FullName { get; set; }
        public string Address { get; set; }
        public string PhoneNo { get; set; }
        public string website { get; set; }
        public string Email { get; set; }
        public string Location { get; set; }
        public int CityID { get; set; }
        public string CityName{ get; set; }
        public int UserID { get; set; }
        public string  UserName { get; set; }

    }
}
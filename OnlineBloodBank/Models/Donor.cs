using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineBloodBank.Models
{
    public class Donor
    {
        public int DonarID { get; set; }
        public string FullName { get; set; }
        public string ContactNo { get; set; }
        public DateTime LastDonationDate { get; set; }
        public string CNIC { get; set; }
        public string Location { get; set; }
        public int BloodGroupID { get; set; }
        public string BloodGroupName { get; set; }
        public int CityID { get; set; }
        public string CityName { get; set; }
        public int UserID { get; set; }
        public string UserName { get; set; }
    }
}
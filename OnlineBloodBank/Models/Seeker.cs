using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineBloodBank.Models
{
    public class Seeker
    {

        public int SeekerID { get; set; }
        public string FullName { get; set; }
        public int Age { get; set; }
        public int CityID { get; set; }
        public string CityName { get; set; }
        public int BloodGroupID { get; set; }
        public string BloodGroupName { get; set; }

        public string ContactNo { get; set; }
        public string CINC { get; set; }
        public int GenderID { get; set; }
        public string GenderName { get; set; }

        public DateTime RegistrationDate { get; set; }
        public int UserID { get; set; }
        public string UserName { get; set; }

       
    }
}
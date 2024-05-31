using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineBloodBank.Models
{
    public class Registeration
    {

        public Registeration()
        {
            seeker = new Seeker();
            hospital = new Hospital();
            bloodBank = new BloodBank();
            donor = new Donor();
            user = new User();

        }
        public int UserTypeId { get; set; }
        public string ConatctNo { get; set; } 
        public int CityId { get; set; }
        public Seeker seeker { get; set; }
        public Hospital hospital { get; set; }
        public BloodBank bloodBank{ get; set; }
        public Donor donor  { get; set; }
        public User user  { get; set; }
    }
}
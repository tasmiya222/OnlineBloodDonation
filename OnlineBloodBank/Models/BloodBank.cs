using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineBloodBank.Models
{
    public class BloodBank
    {
        public int BloodBankID { get; set; }
        public string BloodBankName { get; set; }
        public string Address { get; set; }
        public string PhoneNo { get; set; }
        public string location { get; set; }
        public string website { get; set; }
        public string Email { get; set; }
        public int CityID { get; set; }
        public string CityName { get; set; }
        public int UserID { get; set; }
        public string UserName { get; set; }
    }
}
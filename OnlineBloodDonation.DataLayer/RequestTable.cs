//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OnlineBloodDonation.DataLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class RequestTable
    {
        public int RequestID { get; set; }
        public Nullable<System.DateTime> RequestDate { get; set; }
        public Nullable<int> SeekerId { get; set; }
        public Nullable<int> HospitalId { get; set; }
        public Nullable<int> BloodBankID { get; set; }
        public Nullable<int> DonorID { get; set; }
        public Nullable<int> RequiredBloodID { get; set; }
        public Nullable<int> RequestTypeID { get; set; }
    
        public virtual BloodBankTable BloodBankTable { get; set; }
        public virtual HospitalTable HospitalTable { get; set; }
        public virtual RequestTypeTable RequestTypeTable { get; set; }
        public virtual SeekerTable SeekerTable { get; set; }
    }
}

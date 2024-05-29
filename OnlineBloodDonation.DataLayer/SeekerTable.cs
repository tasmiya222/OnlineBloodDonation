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
    
    public partial class SeekerTable
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SeekerTable()
        {
            this.RequestTables = new HashSet<RequestTable>();
        }
    
        public int SeekerID { get; set; }
        public string FullName { get; set; }
        public Nullable<int> Age { get; set; }
        public Nullable<int> CityID { get; set; }
        public Nullable<int> BloodGroupID { get; set; }
        public string ContactNo { get; set; }
        public string CINC { get; set; }
        public Nullable<int> GenderID { get; set; }
        public Nullable<System.DateTime> RegistrationDate { get; set; }
        public Nullable<int> UserID { get; set; }
    
        public virtual BloodGroupsTable BloodGroupsTable { get; set; }
        public virtual CityTable CityTable { get; set; }
        public virtual GenderTable GenderTable { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RequestTable> RequestTables { get; set; }
        public virtual UserTable UserTable { get; set; }
    }
}

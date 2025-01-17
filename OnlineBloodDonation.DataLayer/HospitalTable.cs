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
    
    public partial class HospitalTable
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HospitalTable()
        {
            this.RequestTables = new HashSet<RequestTable>();
        }
    
        public int HospitalID { get; set; }
        public string FullName { get; set; }
        public string Address { get; set; }
        public string PhoneNo { get; set; }
        public string website { get; set; }
        public string Email { get; set; }
        public string Location { get; set; }
        public Nullable<int> CityID { get; set; }
        public Nullable<int> UserID { get; set; }
    
        public virtual CityTable CityTable { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RequestTable> RequestTables { get; set; }
        public virtual UserTable UserTable { get; set; }
    }
}

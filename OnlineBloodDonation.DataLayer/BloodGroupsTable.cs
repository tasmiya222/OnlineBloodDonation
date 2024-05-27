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
    
    public partial class BloodGroupsTable
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BloodGroupsTable()
        {
            this.BloodBankStockTables = new HashSet<BloodBankStockTable>();
            this.DonorTables = new HashSet<DonorTable>();
            this.SeekerTables = new HashSet<SeekerTable>();
        }
    
        public int BloodGroupID { get; set; }
        public string BloodGroupName { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BloodBankStockTable> BloodBankStockTables { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DonorTable> DonorTables { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SeekerTable> SeekerTables { get; set; }
    }
}

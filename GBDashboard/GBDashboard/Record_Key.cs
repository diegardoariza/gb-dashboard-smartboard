//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GBDashboard
{
    using System;
    using System.Collections.Generic;
    
    public partial class Record_Key
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Record_Key()
        {
            this.Accounting_Record_Additional_Information = new HashSet<Accounting_Record_Additional_Information>();
            this.Customer_Record_Key = new HashSet<Customer_Record_Key>();
        }
    
        public string record_key1 { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Accounting_Record_Additional_Information> Accounting_Record_Additional_Information { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Customer_Record_Key> Customer_Record_Key { get; set; }
    }
}

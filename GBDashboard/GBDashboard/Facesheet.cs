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
    
    public partial class Facesheet
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Facesheet()
        {
            this.Facesheet_Additional_Information = new HashSet<Facesheet_Additional_Information>();
            this.Facesheet_Assigned_Employee = new HashSet<Facesheet_Assigned_Employee>();
            this.Facesheet_Support_Image = new HashSet<Facesheet_Support_Image>();
            this.Procedures = new HashSet<Procedure>();
        }
    
        public int facesheet_id { get; set; }
        public int customer_id { get; set; }
        public System.DateTime date_of_service { get; set; }
        public string location_name { get; set; }
        public string description { get; set; }
        public System.DateTime time_in { get; set; }
        public System.DateTime time_out { get; set; }
        public string notes { get; set; }
        public string patient { get; set; }
        public string insurance_name { get; set; }
        public string facesheet_status_name { get; set; }
        public string payment_type { get; set; }
        public string facesheet_source { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Facesheet_Additional_Information> Facesheet_Additional_Information { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Facesheet_Assigned_Employee> Facesheet_Assigned_Employee { get; set; }
        public virtual Facesheet_Source Facesheet_Source1 { get; set; }
        public virtual Facesheet_Status Facesheet_Status { get; set; }
        public virtual Insurance Insurance { get; set; }
        public virtual Location Location { get; set; }
        public virtual Payment_Type Payment_Type1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Facesheet_Support_Image> Facesheet_Support_Image { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Procedure> Procedures { get; set; }
        public virtual Customer Customer { get; set; }
    }
}

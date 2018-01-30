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
    
    public partial class Document_File
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Document_File()
        {
            this.Accounting_Record_Support_Document = new HashSet<Accounting_Record_Support_Document>();
            this.Facesheet_Support_Image = new HashSet<Facesheet_Support_Image>();
        }
    
        public int document_file_id { get; set; }
        public string document_file_path { get; set; }
        public string document_file_name { get; set; }
        public System.DateTime creation_date { get; set; }
        public bool is_active { get; set; }
        public string document_type { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Accounting_Record_Support_Document> Accounting_Record_Support_Document { get; set; }
        public virtual Document_Type Document_Type1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Facesheet_Support_Image> Facesheet_Support_Image { get; set; }
    }
}

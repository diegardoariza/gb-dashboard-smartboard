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
    
    public partial class Accounting_Record_Additional_Information
    {
        public int accounting_record_additional_information_id { get; set; }
        public int accounting_record_id { get; set; }
        public int customer_id { get; set; }
        public string record_key { get; set; }
        public string record_value { get; set; }
    
        public virtual Accounting_Record Accounting_Record { get; set; }
        public virtual Record_Key Record_Key1 { get; set; }
    }
}

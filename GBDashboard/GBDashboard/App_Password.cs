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
    
    public partial class App_Password
    {
        public string password { get; set; }
        public System.DateTime creation_date { get; set; }
        public string user_id { get; set; }
        public int customer_id { get; set; }
    
        public virtual App_User App_User { get; set; }
    }
}
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
    
    public partial class Customer_Employee_Role
    {
        public int customer_id { get; set; }
        public string employee_role_name { get; set; }
        public bool is_active { get; set; }
    
        public virtual Customer Customer { get; set; }
        public virtual Employee_Role Employee_Role { get; set; }
    }
}

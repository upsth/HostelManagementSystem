//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HostelManagementSystem.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class t_RegisterUser
    {
        public string user_id { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public Nullable<System.DateTime> Create_On { get; set; }
        public string staff_id { get; set; }
        public string Active { get; set; }
    
        public virtual t_staff t_staff { get; set; }
    }
}

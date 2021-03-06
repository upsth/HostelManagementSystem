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
    
    public partial class t_staff
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public t_staff()
        {
            this.t_guardian = new HashSet<t_guardian>();
            this.t_RegisterUser = new HashSet<t_RegisterUser>();
            this.t_salarytransaction = new HashSet<t_salarytransaction>();
        }
    
        public string staff_id { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string address { get; set; }
        public Nullable<System.DateTime> dob { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public string gender { get; set; }
        public Nullable<decimal> salary { get; set; }
        public string guardian_name { get; set; }
        public string guardian_contact_info { get; set; }
        public string guardian_relationship { get; set; }
        public Nullable<System.DateTime> join_date { get; set; }
        public Nullable<System.DateTime> end_date { get; set; }
        public string active { get; set; }
        public string building_info { get; set; }
        public byte[] img_file { get; set; }
        public string citizenship_no { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<t_guardian> t_guardian { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<t_RegisterUser> t_RegisterUser { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<t_salarytransaction> t_salarytransaction { get; set; }
    }
}

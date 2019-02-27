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
    
    public partial class t_student
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public t_student()
        {
            this.t_guardian = new HashSet<t_guardian>();
            this.t_feetransaction = new HashSet<t_feetransaction>();
        }
    
        public string stud_id { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string address { get; set; }
        public Nullable<System.DateTime> dob { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public string gender { get; set; }
        public Nullable<decimal> monthly_fee { get; set; }
        public string school_info { get; set; }
        public string guardian_name { get; set; }
        public string guardian_contact_info { get; set; }
        public string guardian_relationship { get; set; }
        public string room_no { get; set; }
        public string building_info { get; set; }
        public Nullable<System.DateTime> enrollment_date { get; set; }
        public byte[] img_file { get; set; }
        public string Active { get; set; }
        public Nullable<System.DateTime> InActive_Date { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<t_guardian> t_guardian { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<t_feetransaction> t_feetransaction { get; set; }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Comments
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Comments()
        {
            this.Complaints = new HashSet<Complaints>();
            this.Comments1 = new HashSet<Comments>();
        }
    
        public int Id { get; set; }
        public int IdPost { get; set; }
        public int IdUser { get; set; }
        public string Commentary { get; set; }
        public System.DateTime EffectDate { get; set; }
        public Nullable<System.DateTime> NullDate { get; set; }
        public bool DeletedByComplaints { get; set; }
        public Nullable<int> IdUpperComment { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Complaints> Complaints { get; set; }
        public virtual Posts Posts { get; set; }
        public virtual Users Users { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Comments> Comments1 { get; set; }
        public virtual Comments Comments2 { get; set; }
    }
}

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
    
    public partial class Complaints
    {
        public int Id { get; set; }
        public Nullable<int> IdPost { get; set; }
        public Nullable<int> IdComment { get; set; }
        public int IdUser { get; set; }
        public string Description { get; set; }
    
        public virtual Comments Comments { get; set; }
        public virtual Posts Posts { get; set; }
        public virtual Users Users { get; set; }
    }
}

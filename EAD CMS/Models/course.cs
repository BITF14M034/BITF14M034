//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EAD_CMS.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class course
    {
        public course()
        {
            this.assigned_course = new HashSet<assigned_course>();
        }
    
        public int id { get; set; }
        public string name { get; set; }
    
        public virtual ICollection<assigned_course> assigned_course { get; set; }
    }
}

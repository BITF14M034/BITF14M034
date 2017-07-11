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
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.Web.Mvc;
    
    public partial class batch
    {
        public batch()
        {
            this.students = new HashSet<student>();
            this.assigned_course = new HashSet<assigned_course>();
        }
    
        [DisplayName("Batch")]
        [Required]
        [Remote("isBatchExist", "Admin", HttpMethod = "Get", ErrorMessage = "Such Batch already exists!")]
        public string name { get; set; }
    
        public virtual ICollection<student> students { get; set; }
        public virtual ICollection<assigned_course> assigned_course { get; set; }
    }
}
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FunspazPortal.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class content
    {
        public int id { get; set; }
        public Nullable<int> service { get; set; }
        public string title { get; set; }
        public string icon { get; set; }
        public string image1 { get; set; }
        public string image2 { get; set; }
        public System.DateTime insertdate { get; set; }
        public string remark { get; set; }
    
        public virtual service service1 { get; set; }
    }
}
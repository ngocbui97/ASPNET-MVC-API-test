//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CRUDAPI.EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tag
    {
        public Tag()
        {
            this.News = new HashSet<New>();
        }
    
        public string TagID { get; set; }
        public string TagName { get; set; }
    
        public virtual ICollection<New> News { get; set; }
    }
}

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
    
    public partial class NewCategory
    {
        public NewCategory()
        {
            this.News = new HashSet<New>();
        }
    
        public int NewCategoryID { get; set; }
        public string Name { get; set; }
        public string MetaTitle { get; set; }
        public Nullable<int> ParentID { get; set; }
        public Nullable<int> DisplayOrder { get; set; }
        public string SeoTitle { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        public string MetaKeywords { get; set; }
        public string MetaDescriptions { get; set; }
        public Nullable<bool> Status { get; set; }
        public Nullable<bool> ShowOnHome { get; set; }
    
        public virtual ICollection<New> News { get; set; }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Simon8029.EMPDemo.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class EM_EmailTemplateTypes
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public EM_EmailTemplateTypes()  
        {
            this.EM_EmailTemplates = new HashSet<EM_EmailTemplates>();
        }
    
        public short EmailTemplateTypeID { get; set; }
        public string EmailTemplateType { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EM_EmailTemplates> EM_EmailTemplates { get; set; }
    }
}

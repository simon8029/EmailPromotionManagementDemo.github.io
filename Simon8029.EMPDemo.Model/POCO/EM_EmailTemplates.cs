//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Simon8029.EMPDemo.Model
{
	public partial class EM_EmailTemplates
	{
		public EM_EmailTemplates ToPOCO(){
			return new EM_EmailTemplates(){
				EmailTemplateID=this.EmailTemplateID,
				EmailTemplateTypeID=this.EmailTemplateTypeID,
				TemplateTypeID=this.TemplateTypeID,
				Template=this.Template,
				Enabled=this.Enabled,
				ExpireDate=this.ExpireDate,
				CreatedDate=this.CreatedDate,
				CreatedBy=this.CreatedBy,
				UpdatedDate=this.UpdatedDate,
				Updatedby=this.Updatedby,
			};
		}
	}
}

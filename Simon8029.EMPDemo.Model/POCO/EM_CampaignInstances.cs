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
	public partial class EM_CampaignInstances
	{
		public EM_CampaignInstances ToPOCO(){
			return new EM_CampaignInstances(){
								CampaignInstanceID=this.CampaignInstanceID,
				EmailInstanceID=this.EmailInstanceID,
				LeadID=this.LeadID,
				IsSent=this.IsSent,
				EventID=this.EventID,
				EventStatus=this.EventStatus,
				EventDate=this.EventDate,
				Guid=this.Guid,
				CreatedDate=this.CreatedDate,
				CreatedBy=this.CreatedBy,
				UpdatedDate=this.UpdatedDate,
				UpdatedBy=this.UpdatedBy,
			};
		}
	}
}

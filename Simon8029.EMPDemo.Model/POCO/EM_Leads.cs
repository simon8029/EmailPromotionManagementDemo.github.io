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
	public partial class EM_Leads
	{
		public EM_Leads ToPOCO(){
			return new EM_Leads(){
			LeadID=this.LeadID,
			FirstName=this.FirstName,
			LastName=this.LastName,
			EmailAddress=this.EmailAddress,
			IsValid=this.IsValid,
			Unsubscribed=this.Unsubscribed,
			};
		}
	}
}

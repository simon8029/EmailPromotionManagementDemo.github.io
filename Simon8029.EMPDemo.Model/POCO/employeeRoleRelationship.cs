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
	public partial class employeeRoleRelationship
	{
		public employeeRoleRelationship ToPOCO(){
			return new employeeRoleRelationship(){
				employeeRoleRelationID=this.employeeRoleRelationID,
				employeeID=this.employeeID,
				RoleID=this.RoleID,
			};
		}
	}
}

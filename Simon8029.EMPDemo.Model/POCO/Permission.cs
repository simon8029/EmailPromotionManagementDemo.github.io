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
	public partial class Permission
	{
		public Permission ToPOCO(){
			return new Permission(){
								permissionID=this.permissionID,
				permissionParentID=this.permissionParentID,
				permissionName=this.permissionName,
				permissionRemark=this.permissionRemark,
				permissionAreaName=this.permissionAreaName,
				permissionControllerName=this.permissionControllerName,
				permissionActionName=this.permissionActionName,
				permissionFormMethod=this.permissionFormMethod,
				permissionOperationType=this.permissionOperationType,
				permissionJSMethodName=this.permissionJSMethodName,
				permissionIcon=this.permissionIcon,
				permissionIsLink=this.permissionIsLink,
				permissionOrder=this.permissionOrder,
				permissionIsShow=this.permissionIsShow,
				permissionIsDeleted=this.permissionIsDeleted,
				permissionAddTime=this.permissionAddTime,
			};
		}
	}
}

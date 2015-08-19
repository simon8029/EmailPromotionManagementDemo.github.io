﻿
 //------------------------------------------------------------------------------
// <auto-generated>
// 业务仓储接口，作用：
// 1.调用数据仓储 SaveChanges 批量 执行 sql语句
// 2.方便通过 子接口属性直接 获取 对应业务子接口对象
// </auto-generated>
//------------------------------------------------------------------------------

namespace Simon8029.EMPDemo.Service
{
    using System;
    public partial class ServiceSession:IService.IServiceSession
    {
    	IService.IEM_CampaignInstancesService _EM_CampaignInstancesService;
        public IService.IEM_CampaignInstancesService EM_CampaignInstancesService 
        { 
        	get
        	{
                if (_EM_CampaignInstancesService == null)
                    _EM_CampaignInstancesService = new Service.EM_CampaignInstancesService();
                return _EM_CampaignInstancesService;
        	}
        }
    
    	IService.IEM_CampaignsService _EM_CampaignsService;
        public IService.IEM_CampaignsService EM_CampaignsService 
        { 
        	get
        	{
                if (_EM_CampaignsService == null)
                    _EM_CampaignsService = new Service.EM_CampaignsService();
                return _EM_CampaignsService;
        	}
        }
    
    	IService.IEM_EmailInstancesService _EM_EmailInstancesService;
        public IService.IEM_EmailInstancesService EM_EmailInstancesService 
        { 
        	get
        	{
                if (_EM_EmailInstancesService == null)
                    _EM_EmailInstancesService = new Service.EM_EmailInstancesService();
                return _EM_EmailInstancesService;
        	}
        }
    
    	IService.IEM_EmailTemplatesService _EM_EmailTemplatesService;
        public IService.IEM_EmailTemplatesService EM_EmailTemplatesService 
        { 
        	get
        	{
                if (_EM_EmailTemplatesService == null)
                    _EM_EmailTemplatesService = new Service.EM_EmailTemplatesService();
                return _EM_EmailTemplatesService;
        	}
        }
    
    	IService.IEM_EmailTemplateTypesService _EM_EmailTemplateTypesService;
        public IService.IEM_EmailTemplateTypesService EM_EmailTemplateTypesService 
        { 
        	get
        	{
                if (_EM_EmailTemplateTypesService == null)
                    _EM_EmailTemplateTypesService = new Service.EM_EmailTemplateTypesService();
                return _EM_EmailTemplateTypesService;
        	}
        }
    
    	IService.IEM_EventsService _EM_EventsService;
        public IService.IEM_EventsService EM_EventsService 
        { 
        	get
        	{
                if (_EM_EventsService == null)
                    _EM_EventsService = new Service.EM_EventsService();
                return _EM_EventsService;
        	}
        }
    
    	IService.IEM_LeadsService _EM_LeadsService;
        public IService.IEM_LeadsService EM_LeadsService 
        { 
        	get
        	{
                if (_EM_LeadsService == null)
                    _EM_LeadsService = new Service.EM_LeadsService();
                return _EM_LeadsService;
        	}
        }
    
    	IService.IDepartmentService _DepartmentService;
        public IService.IDepartmentService DepartmentService 
        { 
        	get
        	{
                if (_DepartmentService == null)
                    _DepartmentService = new Service.DepartmentService();
                return _DepartmentService;
        	}
        }
    
    	IService.IEmployeeService _EmployeeService;
        public IService.IEmployeeService EmployeeService 
        { 
        	get
        	{
                if (_EmployeeService == null)
                    _EmployeeService = new Service.EmployeeService();
                return _EmployeeService;
        	}
        }
    
    	IService.IemployeeRoleRelationshipService _employeeRoleRelationshipService;
        public IService.IemployeeRoleRelationshipService employeeRoleRelationshipService 
        { 
        	get
        	{
                if (_employeeRoleRelationshipService == null)
                    _employeeRoleRelationshipService = new Service.employeeRoleRelationshipService();
                return _employeeRoleRelationshipService;
        	}
        }
    
    	IService.IPermissionService _PermissionService;
        public IService.IPermissionService PermissionService 
        { 
        	get
        	{
                if (_PermissionService == null)
                    _PermissionService = new Service.PermissionService();
                return _PermissionService;
        	}
        }
    
    	IService.IRoleService _RoleService;
        public IService.IRoleService RoleService 
        { 
        	get
        	{
                if (_RoleService == null)
                    _RoleService = new Service.RoleService();
                return _RoleService;
        	}
        }
    
    	IService.IRolePermissionRelationshipService _RolePermissionRelationshipService;
        public IService.IRolePermissionRelationshipService RolePermissionRelationshipService 
        { 
        	get
        	{
                if (_RolePermissionRelationshipService == null)
                    _RolePermissionRelationshipService = new Service.RolePermissionRelationshipService();
                return _RolePermissionRelationshipService;
        	}
        }
    
    	IService.IVipPermissionService _VipPermissionService;
        public IService.IVipPermissionService VipPermissionService 
        { 
        	get
        	{
                if (_VipPermissionService == null)
                    _VipPermissionService = new Service.VipPermissionService();
                return _VipPermissionService;
        	}
        }
    
    }
}

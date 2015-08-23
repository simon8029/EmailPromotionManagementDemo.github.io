﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Simon8029.EMPDemo.Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Objects;
    using System.Data.Objects.DataClasses;
    using System.Linq;
    
    public partial class Entities : DbContext
    {
        public Entities()
            : base("name=Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Department> Departments { get; set; }
        public DbSet<EM_CampaignInstances> EM_CampaignInstances { get; set; }
        public DbSet<EM_Campaigns> EM_Campaigns { get; set; }
        public DbSet<EM_EmailInstances> EM_EmailInstances { get; set; }
        public DbSet<EM_EmailTemplates> EM_EmailTemplates { get; set; }
        public DbSet<EM_EmailTemplateTypes> EM_EmailTemplateTypes { get; set; }
        public DbSet<EM_Events> EM_Events { get; set; }
        public DbSet<EM_Leads> EM_Leads { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<employeeRoleRelationship> employeeRoleRelationships { get; set; }
        public DbSet<Permission> Permissions { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<RolePermissionRelationship> RolePermissionRelationships { get; set; }
        public DbSet<VipPermission> VipPermissions { get; set; }
    
        public virtual int EM_CampaignInstances_INSERT(Nullable<int> emailInstanceID)
        {
            var emailInstanceIDParameter = emailInstanceID.HasValue ?
                new ObjectParameter("EmailInstanceID", emailInstanceID) :
                new ObjectParameter("EmailInstanceID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("EM_CampaignInstances_INSERT", emailInstanceIDParameter);
        }
    }
}

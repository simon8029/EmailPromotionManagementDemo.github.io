﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
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
    
        public virtual DbSet<Department> Department { get; set; }
        public virtual DbSet<EM_CampaignInstances> EM_CampaignInstances { get; set; }
        public virtual DbSet<EM_Campaigns> EM_Campaigns { get; set; }
        public virtual DbSet<EM_EmailInstances> EM_EmailInstances { get; set; }
        public virtual DbSet<EM_EmailTemplates> EM_EmailTemplates { get; set; }
        public virtual DbSet<EM_EmailTemplateTypes> EM_EmailTemplateTypes { get; set; }
        public virtual DbSet<EM_Events> EM_Events { get; set; }
        public virtual DbSet<EM_Leads> EM_Leads { get; set; }
        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<employeeRoleRelationship> employeeRoleRelationship { get; set; }
        public virtual DbSet<Permission> Permission { get; set; }
        public virtual DbSet<Role> Role { get; set; }
        public virtual DbSet<RolePermissionRelationship> RolePermissionRelationship { get; set; }
        public virtual DbSet<VipPermission> VipPermission { get; set; }
    
        public virtual int EM_CampaignInstances_INSERT(Nullable<int> emailInstanceID)
        {
            var emailInstanceIDParameter = emailInstanceID.HasValue ?
                new ObjectParameter("EmailInstanceID", emailInstanceID) :
                new ObjectParameter("EmailInstanceID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("EM_CampaignInstances_INSERT", emailInstanceIDParameter);
        }
    }
}

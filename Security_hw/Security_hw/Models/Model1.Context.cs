//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Security_hw.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Web.Security;

    
    public partial class MVC_DB_hwEntities : DbContext
    {
        public MVC_DB_hwEntities()
            : base("name=MVC_DB_hwEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<RoleMaster> RoleMasters { get; set; }
        public virtual DbSet<UserRolesMapping> UserRolesMappings { get; set; }
        public virtual DbSet<User> Users { get; set; }

        public System.Data.Entity.DbSet<Security_hw.Models.UserModel> UserModels { get; set; }
    }
}

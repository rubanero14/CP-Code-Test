//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CP_Code_Test.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class CPTestDBEntities : DbContext
    {
        public CPTestDBEntities()
            : base("name=CPTestDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ConsultantInfo> Consultants { get; set; }
        public virtual DbSet<CustomerInfo> Customers { get; set; }
        public virtual DbSet<DiscretionaryRule> DiscretionaryRules { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
    }
}

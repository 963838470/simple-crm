﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class CRMEntities : DbContext
    {
        public CRMEntities()
            : base("name=CRMEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Company> Company { get; set; }
        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<CustomerLog> CustomerLog { get; set; }
        public virtual DbSet<CustomerNoContact> CustomerNoContact { get; set; }
        public virtual DbSet<CustomerVisit> CustomerVisit { get; set; }
        public virtual DbSet<MyRiCheng> MyRiCheng { get; set; }
        public virtual DbSet<Team> Team { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<Menu> Menu { get; set; }
        public virtual DbSet<WorkLog> WorkLog { get; set; }
        public virtual DbSet<Message> Message { get; set; }
        public virtual DbSet<UserAuthority> UserAuthority { get; set; }
    }
}

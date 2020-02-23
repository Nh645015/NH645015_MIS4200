using NH645015_MIS4200.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace NH645015_MIS4200.DAL
{
    public class MIS4200Context : DbContext
    {
        public MIS4200Context() : base("name=DefaultConnection")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<MIS4200Context, NH645015_MIS4200.Migrations.MISContext.Configuration>("DefaultConnection"));
        }
        
        public DbSet<Pet> Pets { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Vet> Vets { get; set; }
        public DbSet<VisitDetail> VisitDetails { get; set; }



        // add this method - it will be used later
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public System.Data.Entity.DbSet<NH645015_MIS4200.Models.userDetails> userDetails { get; set; }
    }
}
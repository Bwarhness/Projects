using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace SchoolTHang.Models
{
    public class DataContext: DbContext
    {
        public DataContext() : base("DefaultConnection")
        {
        }


        public DbSet<Classes> Classes { get; set; }
        public DbSet<School> Schools{ get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Fag> Fag { get; set; }
        public DbSet<Assignment> Assignments { get; set; }
        public DbSet<Arrangements> Arrangements { get; set; }
        public DbSet<Announcement> Annocements { get; set; }
        public DbSet<Grade> Grades { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
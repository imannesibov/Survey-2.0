using Survey_2._0.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Survey_2._0
{
    class UserContext : DbContext
    {

        public UserContext() : base("UserDB")
        {

        }
        public DbSet<User> Users { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<User>().Property(e => e.BirthDate).HasColumnType("datetime2");
        }
    }

}

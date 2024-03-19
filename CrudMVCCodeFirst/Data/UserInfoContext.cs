using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace CrudMVCCodeFirst.Data
{
    public partial class UserInfoContext : DbContext
    {
        public UserInfoContext(): base("name=LaunchContext")
        {
        }

        public virtual DbSet<UserInfo> UserInfo { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}

using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace ExWebApiProjec.Models
{
    public class TaskContext : DbContext
    {
         
        public DbSet<Task> Tasks {get; set;}
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
    }
    //protected override void OnModelCreating(DbModelBuilder modelBuilder)
    //{
    //       Database.SetInitializer<TaskContext>(null);    
    //}

    //CustomRoleProvider -> TaskContext zamenit' na UserContext
    /* public class UserContext : DbContext
     {
         public DbSet<User> Users { get; set; }
         public DbSet<Role> Roles { get; set; }
     }*/
}
using Identity.EntityLayer.Concrate;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Identity.DataAccessLayer.Context
{
    public class IdentityContext : IdentityDbContext<AppUser,AppRole,int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-FCK5R8M\\SQLEXPRESS;initial catalog=IdentityProject;integrated Security=true;");
        }

        public DbSet<Message> messages { get; set; }
        public DbSet<Writer> writers { get; set; }
        public DbSet<deneme> denemes { get; set; }
        public DbSet<Notification> notifications { get; set; }

    }
}

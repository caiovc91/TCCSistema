using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TCCSistema.Models;

namespace TCCSistema.Data
{
    public class BaseContext : IdentityDbContext<TCCSistemaUser>
    {
        public BaseContext(DbContextOptions<BaseContext> options)
               : base(options)
        { }

        public DbSet<User> User { get; set; }
        public DbSet<ImageLog> ImageLog { get; set; }
        public DbSet<Login> Login { get; set; }
        public DbSet<TargetUser> TargetUser { get; set; }
        public DbSet<UserType> UserType { get; set; }
        public DbSet<Camera> Camera { get; set; }
        public DbSet<OccurrenceLog> OccurrenceLog { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            base.OnModelCreating(mb);

            mb.Entity<User>().ToTable("User");
            mb.Entity<ImageLog>().ToTable("ImageLog");
            mb.Entity<Login>().ToTable("Login");
            mb.Entity<TargetUser>().ToTable("TargetUser");
            mb.Entity<UserType>().ToTable("UserType");
            mb.Entity<Camera>().ToTable("Camera");
            mb.Entity<OccurrenceLog>().ToTable("OccurrenceLog");


            mb.Entity<UserType>().HasData(new UserType {id_user_type = 1, type = "Administrator" },
                                          new UserType {id_user_type = 2, type = "Observer" },
                                          new UserType {id_user_type = 3, type = "Regular"},
                                          new UserType {id_user_type = 4, type = "Patient"});
            
            mb.Entity<User>().HasData(new User
                                        {
                                            id_user = 1,
                                            email = "admin@admin.com",
                                            id_user_type = 1,
                                            isPatient = false,
                                            info = "System Administrator",
                                            name = "Admin",
                                            phone = "99999999",

                                        });
            mb.Entity<Login>().HasData(new Login {  id_login = 1,
                                                    id_user = 1,
                                                    login = "admin",
                                                    password = "admin"
                                        });
            
        }
    }

}

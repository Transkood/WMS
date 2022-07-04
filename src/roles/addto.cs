using System;
using Microsoft.Entity.Framework;

namespace WMS 
{ 
    public class ApplicationContext : DbContext
    {
        public DbSet<Users> cargos { get; set; } = null!;
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
            Database.EnsureCreated();   // создаем базу данных при первом обращении
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                    add.User(name, role, password, login)
            );
 
        }    
    }
}

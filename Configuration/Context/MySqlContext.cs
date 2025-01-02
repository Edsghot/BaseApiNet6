using System;
using BaseApiNet6.Configuration.DataBase.EntityConfigurations;
using BaseApiNet6.Modules.User.Domain.Entity;
using Microsoft.EntityFrameworkCore;

namespace BaseApiNet6.Configuration.DataBase
{
    public class MySqlContext : DbContext
    {
        public DbSet<UserEntity> Users { get; set; }

        public MySqlContext(DbContextOptions<MySqlContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=jhedgost.com;Database=dbjhfjuv_jhedgostApi;User=dbjhfjuv_edsghot;Password=Repro321.;";

            optionsBuilder.UseMySql(
                connectionString,
                new MySqlServerVersion(new Version(8, 0, 21))
            );
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserEntityConfiguration());
        }


    }
}

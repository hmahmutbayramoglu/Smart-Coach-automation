using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class DersCalismaProgramiContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=WIN7-BILGISAYAR\SQLEXPRESS;Initial Catalog=DersCalismaProgrami;Integrated Security=True");

        }

        protected override void OnModelCreating(ModelBuilder _modelBuilder)
        {
            _modelBuilder.Entity<CalismaProgrami>().HasKey(o => o.Id);
        }


        //Yazımı veri tabanındaki tablo ismiyle aynı olmalı !
        public DbSet<CalismaProgrami> CalismaProgrami { get; set; }


        public DbSet<Ders> Dersler { get; set; }




    }
}

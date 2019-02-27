using _09._04._2018_Uyelik.Models.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace _09._04._2018_Uyelik.Models.Context
{
    public class DBCONTEXT:DbContext
    {

        public DbSet<Yorum> Yorum { get; set; }

        public DbSet<Makale> Makale { get; set; }


        public DBCONTEXT()
        {

            Database.SetInitializer(new VeritabanıOlusturucu());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
    public class VeritabanıOlusturucu : CreateDatabaseIfNotExists<DBCONTEXT> {

    }
}
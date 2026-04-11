using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using dipendenti_management.Models;

namespace dipendenti_management.App_Start
{
    public class DbContextConfig : DbContext
    {

        public DbContextConfig() : base("name=db_locale")
        {
        }

        public DbSet<Dipendente> dipendenti { get; set; }
        public DbSet<Amministratore> amministratori { get; set; }
    }
}
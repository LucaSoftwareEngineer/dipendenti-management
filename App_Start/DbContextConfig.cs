using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace dipendenti_management.App_Start
{
    public class DbContextConfig : DbContext
    {

        public DbContextConfig() : base("name=db_locale")
        {
        }
    }
}
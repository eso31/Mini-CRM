using Mini_CRM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Mini_CRM.DAL
{
    public class CRMContext : DbContext
    {
        //public CRMContext() : base("CRMDB") { }
        public DbSet <Contact> Contacts { get; set; }
        public DbSet <Annotation> Annotations { get; set; }
    }
}
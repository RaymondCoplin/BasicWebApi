using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BasicWebApi.Models
{
    public class ContactContext: DbContext
    {
        public ContactContext(): base("ContactDb")
        {

        }

        public System.Data.Entity.DbSet<BasicWebApi.Models.Contact> Contacts { get; set; }
    }
}
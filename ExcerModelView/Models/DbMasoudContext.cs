using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace ExcerModelView.Models
{
    public class DbMasoudContext:DbContext
    {
        public DbSet<User> Users { get; set; }

    }
}
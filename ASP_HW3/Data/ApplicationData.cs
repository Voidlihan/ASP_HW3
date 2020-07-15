using ASP_HW3.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ASP_HW3.Data
{
    public class ApplicationData : DbContext
    {
        public virtual DbSet<Subject> Subjects { get; set; }
        public virtual DbSet<Teacher> Teachers { get; set; }

        public ApplicationData() : base("name=ApplicationConnectionString")
        {

        }
    }
}
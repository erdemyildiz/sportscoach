using Entity.Models;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
   public class SportsCoachContext:IdentityDbContext<IdentityUser>
    {
        public SportsCoachContext():base("SportsCoachContext")
        {

        }
        public virtual DbSet<Testimonials> Testimonials { get; set; }
        public virtual DbSet<AboutUs> AboutUs { get; set; }
        public virtual DbSet<Courses> Courses { get; set; }
        public virtual DbSet<Pricing> Pricing { get; set; }
        public virtual DbSet<Contact> Contact { get; set; }
        
    }
}

using Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
   public class Repository
    {
        public class PricingRepo : BaseRepository<Pricing> { }
        public class CoursesRepo : BaseRepository<Courses> { }
        public class AboutUsRepo : BaseRepository<AboutUs> { }
        public class TestimonialsRepo : BaseRepository<Testimonials> { }
        public class ContactRepo : BaseRepository<Contact> { }
    }
}

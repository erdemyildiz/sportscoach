using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Models
{
   public class Courses
    {
        [Key]
        public int CoursesID { get; set; }
        public string CoursesImage { get; set; }
        public string CoursesName { get; set; }
        public string Description { get; set; }


    }
}

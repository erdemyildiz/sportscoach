using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Models
{
   public class AboutUs
    {
        [Key]
        public int AboutUsID { get; set; }
        public string ProjectImage { get; set; }
        public string ProjectName { get; set; }
        public string ProjectDescription { get; set; }


    }
}

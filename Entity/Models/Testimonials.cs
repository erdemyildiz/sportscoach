using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Models
{
   public class Testimonials
    {
        [Key]
        public int YorumlarID { get; set; }
        public string YorumcuAdi { get; set; }
        public string ProfilResmi { get; set; }
        public string Aciklama { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class uyeler
    {
        [Key]
        public long TC { get; set; }
        public string ad { get; set; }
        public string soyad { get; set; }
        public string kan { get; set; }
        public string sehir { get; set; }
        public string e_mail { get; set; }
        public string uye_durum { get; set; }


    }
}

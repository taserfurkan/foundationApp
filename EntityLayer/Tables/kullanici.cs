using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class kullanici
    {
        [Key]
        public long TC { get; set; }
        public string Sifre { get; set; }
        public string kullaniciAdi { get; set; }
    }
}

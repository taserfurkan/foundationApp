using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class aidat_tutarları
    {
        [Key]
        public int id { get; set; }
        public string ay { get; set; }
        public int aylik { get; set; }
    }
}

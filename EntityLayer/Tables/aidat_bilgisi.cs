using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class aidat_bilgisi
    {
        
        [Key]
        public int aidatID { get; set; }
        public long TC { get; set; }
        public string ad { get; set; }
        public string soyad { get; set; }
        public string aidat_donem { get; set; }
        public string odeme_durumu { get; set; }
        public DateTime zaman { get; set; }
        public int Tutar { get; set; }


    }
}

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer { 
    public class mailServis
    {
        [Key]
        public string alan { get; set; }
        public string icerik { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using Microsoft.EntityFrameworkCore;

namespace EntityLayer
{
    public class DBContext: DbContext

    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseJet("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\taser\\Desktop\\201001087- Görsel Programlama\\Dernek_Takip.accdb;");
        }


        public DbSet<kullanici> kullanici { get; set; } //diğer classlar için yap
        public DbSet<uyeler> uyeler { get; set; }
        public DbSet<aidat_tutarları> aidat_tutarları { get; set; }
        public DbSet<aidat_bilgisi> aidat_bilgisi { get; set; }
        public DbSet<mailServis> mailServis { get; set; }
        //hepsini çağır tablolar
    }
}

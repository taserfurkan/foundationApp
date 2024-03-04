using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntityLayer;

namespace DernekTakipUygulaması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

          
        }

        private void btngiris_Click(object sender, EventArgs e)
        {
            var kullaniciadi = kullanicitxt.Text;
            var sifre = sifretxt.Text;
            if (kullaniciadi == null || sifre== null)
            {
                MessageBox.Show("Kullanıcı Adı ve Şifre Boş Geçilemez.");
                return;
            }
            using (DBContext c = new DBContext())
            {   
                var kullanici = c.kullanici.SingleOrDefault(k => k.kullaniciAdi == kullaniciadi && k.Sifre == sifre);
                
                if (kullanici != null)
                {
                    IslemSeç form2 = new IslemSeç();
                    this.Hide();
                    form2.Show();
                }
                else
                {
                    MessageBox.Show("Geçersiz kullanıcı adı veya şifre");
                    kullanicitxt.Text = "";
                    sifretxt.Text = "";
                }
            }
        }

    }
}

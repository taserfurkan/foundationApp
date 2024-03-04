using EntityLayer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DernekTakipUygulaması
{
    public partial class UyeIslemleri : Form
    {
        public UyeIslemleri()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

        }
        private void Form3_Load(object sender, EventArgs e)
        {
            YenileDataGridView();
            gncadtxt.Enabled = false;
            gncdurumcombo.Enabled = false;
            gnckancombo.Enabled = false;
            gncmailtxt.Enabled = false;
            gncsehircombo.Enabled = false;
            gncsoyadtxt.Enabled = false;
            gnctctxt.Enabled = false;
            btnguncelle.Enabled = false;

        }

        private void btngeri_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnekle_Click(object sender, EventArgs e)
        {
            string ad1 = adtxt.Text; 
            string soyad1 = soyadtxt.Text;
            string tcstr = tctxt.Text;
            if (tcstr.Length != 11 || !long.TryParse(tcstr, out long TC))
            {
                MessageBox.Show("Geçersiz TC kimlik numarası. TC kimlik numarası 11 haneli ve sadece sayılardan oluşmalıdır.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                adtxt.Text = "";
                soyadtxt.Text = "";
                tctxt.Text = "";
                sehirCombo.Text = "";
                durumCombo.Text = "";
                kanCombo.Text = "";
                mailtxt.Text = "";
                return;
            }
            long tc = long.Parse(tctxt.Text);
            string sehir1 = sehirCombo.Text;
            string durum1 = durumCombo.Text;
            string kan1 = kanCombo.Text;
            string mail1 = mailtxt.Text;


            uyeler yeniKullanici = new uyeler
            {
                TC = tc,
                ad = ad1,
                soyad = soyad1,
                sehir = sehir1,
                uye_durum = durum1,
                kan = kan1,
                e_mail = mail1
            };

            using (DBContext c = new DBContext())
            {
                
                if (c.uyeler.Any(u => u.TC == tc))
                {
                    MessageBox.Show("Bu TC kimlik numarasına sahip bir üye zaten mevcut.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    adtxt.Text = "";
                    soyadtxt.Text = "";
                    tctxt.Text = "";
                    sehirCombo.Text = "";
                    durumCombo.Text = "";
                    kanCombo.Text = "";
                    mailtxt.Text = "";
                    return; // Üye varsa işlemi sonlandır
                }

                c.uyeler.Add(yeniKullanici); 
                c.SaveChanges();
                YenileDataGridView();
            }
            MessageBox.Show("Kullanıcı başarıyla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            adtxt.Text = "";
            soyadtxt.Text = "";
            tctxt.Text = "";
            sehirCombo.Text = "";
            durumCombo.Text = "";
            kanCombo.Text = "";
            mailtxt.Text = "";
            
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            if (siltctxt.Text.Length != 11 || !long.TryParse(siltctxt.Text, out long TC))
            {
                MessageBox.Show("TC Numarası Boş Geçilemez.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;

            }
            long tctxt1 = long.Parse(siltctxt.Text);
            
            using (DBContext c = new DBContext())
            {
                uyeler seciliKullanici = c.uyeler.FirstOrDefault(k => k.TC == tctxt1);

                if (seciliKullanici != null)
                {
                    c.uyeler.Remove(seciliKullanici);
                    c.SaveChanges();
                    YenileDataGridView();
                    MessageBox.Show("Belirtilen TC numarasına sahip kullanıcı kayıdı silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Belirtilen TC numarasına sahip kullanıcı bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnbul_Click(object sender, EventArgs e)
        {
            if (tcbultxt.Text.Length != 11 || !long.TryParse(tcbultxt.Text, out long TC))
            {
                MessageBox.Show("TC Numarası Boş Geçilemez.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;

            }
            long tc5 = long.Parse(tcbultxt.Text);

            using (DBContext c = new DBContext())
            {
                uyeler seciliKullanici = c.uyeler.FirstOrDefault(k => k.TC == tc5);

                if (seciliKullanici != null)
                {
                    gncadtxt.Enabled = true;
                    gncdurumcombo.Enabled = true;
                    gnckancombo.Enabled = true;
                    gncmailtxt.Enabled = true;
                    gncsehircombo.Enabled = true;
                    gncsoyadtxt.Enabled = true;
                    btnguncelle.Enabled = true;

                    gncadtxt.Text = seciliKullanici.ad;
                    gncsoyadtxt.Text = seciliKullanici.soyad;
                    gncdurumcombo.Text = seciliKullanici.uye_durum;
                    gnckancombo.Text = seciliKullanici.kan;
                    gncmailtxt.Text = seciliKullanici.e_mail;
                    gncsehircombo.Text = seciliKullanici.sehir;
                    gnctctxt.Text = Convert.ToString(seciliKullanici.TC);

                }
                else
                {
                    MessageBox.Show("Belirtilen TC numarasına sahip kullanıcı bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
       
        private void btnguncelle_Click(object sender, EventArgs e)
        {
            if (gnctctxt.Text.Length != 11 || !long.TryParse(gnctctxt.Text, out long TC))
            {
                MessageBox.Show("TC Numarası Boş Geçilemez.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;

            }
            long tc5 = long.Parse(gnctctxt.Text);

            Silmeİslemi(tc5);
            Ekleİslemi();
            gncadtxt.Enabled = false;
            gncdurumcombo.Enabled = false;
            gnckancombo.Enabled = false;
            gncmailtxt.Enabled = false;
            gncsehircombo.Enabled = false;
            gncsoyadtxt.Enabled = false;
            gnctctxt.Enabled = false;
            btnguncelle.Enabled = false;
            YenileDataGridView();
        }

        private void YenileDataGridView()
        {
            // DataGridView'i güncellemek için kullanılan kod
            using (DBContext c = new DBContext())
            {
                dgtumuyeler.DataSource = c.uyeler.ToList();
            }
        }

        private void Silmeİslemi(long kullaniciTC)
        {

            long tctxt1 = kullaniciTC;

            using (DBContext c = new DBContext())
            {
                uyeler seciliKullanici = c.uyeler.FirstOrDefault(k => k.TC == tctxt1);

                if (seciliKullanici != null)
                {
                    c.uyeler.Remove(seciliKullanici);
                    c.SaveChanges();
                }
                else
                {
                    MessageBox.Show("Belirtilen TC numarasına sahip kullanıcı bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Ekleİslemi()
        {

            string ad1 = gncadtxt.Text;
            string soyad1 = gncsoyadtxt.Text;
            long tc = long.Parse(gnctctxt.Text);
            string sehir1 = gncsehircombo.Text;
            string durum1 = gncdurumcombo.Text;
            string kan1 = gnckancombo.Text;
            string mail1 = gncmailtxt.Text;

            uyeler yeniKullanici = new uyeler
            {
                TC = tc,
                ad = ad1,
                soyad = soyad1,
                sehir = sehir1,
                uye_durum = durum1,
                kan = kan1,
                e_mail = mail1
            };

            using (DBContext c = new DBContext())
            {
                c.uyeler.Add(yeniKullanici);
                c.SaveChanges();
                YenileDataGridView();
            }
            MessageBox.Show("Kullanıcı başarıyla guncellendi..", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            gncadtxt.Text = "";
            gncsoyadtxt.Text = "";
            gnctctxt.Text = "";
            gncsehircombo.Text = "";
            gncdurumcombo.Text = "";
            gnckancombo.Text = "";
            gncmailtxt.Text = "";
            tcbultxt.Text = "";

        }

        
    }
}

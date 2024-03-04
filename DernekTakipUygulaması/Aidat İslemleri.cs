using EntityLayer;
using Microsoft.EntityFrameworkCore;
using System;
using System.IO; 
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace DernekTakipUygulaması
{
    public partial class Form4 : Form
    {

        public Form4()
        {
            InitializeComponent(); this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btngeri_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            YenileDataGridView();

            btnlistele.Enabled = false;
            button2.Enabled = false;
            comboBox3.Enabled = false;
            comboBox4.Enabled = false;
            comboBox5.Enabled = false;
            btngonder.Enabled = false;
            dateTimePicker1.Enabled = false;
            radioButton3.Enabled = false;
            radioButton4.Enabled = false;
            textBox4.Visible = false;
            label15.Visible = false;


        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            MailServis form7 = new MailServis();
            form7.Show();
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            if (aylarCombo == null || tutartxt== null)
            {
                MessageBox.Show("Lütfen Alanları Doldurunuz.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;

            }
            string ay = aylarCombo.Text; ;

            using (DBContext c = new DBContext())
            {
                aidat_tutarları seciliay = c.aidat_tutarları.FirstOrDefault(k => k.ay == ay);

                if (seciliay != null)
                {
                    seciliay.aylik = Convert.ToInt32(tutartxt.Text);
                    c.Update(seciliay);
                    c.SaveChanges();
                    MessageBox.Show("Belirtilen ay aidat tutarı güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    aylarCombo.Text = "";
                    tutartxt.Text = "";

                }
                else
                {
                    MessageBox.Show("Belirtilen ay aidat tutarı güncellenmedi.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox2 == null)
            {
                MessageBox.Show("Lütfen Görüntülemek İstediğiniz Ayı Seçiniz.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;

            }
            string ay = comboBox2.Text;

            using (DBContext c = new DBContext())
            {
                aidat_tutarları seciliay = c.aidat_tutarları.FirstOrDefault(k => k.ay == ay);

                if (seciliay != null)
                {
                    textBox1.Text = Convert.ToString(seciliay.aylik);

                }
                else
                {
                    MessageBox.Show("Belirtilen ayın aidat bilgisi bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void kayitgetir_Click(object sender, EventArgs e)
        {
            if (odemetc.Text.Length != 11 || !long.TryParse(odemetc.Text, out long TC))
            {
                MessageBox.Show("TC Numarası Kontrol Ediniz.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;

            }
            
            long tc5 = long.Parse(odemetc.Text);

            using (DBContext c = new DBContext())
            {
                uyeler seciliKullanici = c.uyeler.FirstOrDefault(k => k.TC == tc5);

                if (seciliKullanici != null)
                {
                    textBox2.Text = seciliKullanici.ad;
                    textBox3.Text = seciliKullanici.soyad;
                    button2.Enabled = true;
                    comboBox3.Enabled = true;
                    comboBox4.Enabled = true;
                    comboBox5.Enabled = true;
                    dateTimePicker1.Enabled = true;
                    label4.Enabled = true;
                    radioButton3.Enabled = true;
                    radioButton4.Enabled = true;

                }
                else
                {
                    MessageBox.Show("Belirtilen TC numarasına sahip kullanıcı bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DateTime zaman1 = dateTimePicker1.Value;
            string ad = textBox2.Text;
            string soyad = textBox3.Text;
            long tc = long.Parse(odemetc.Text);
            string aidat_donem = comboBox4.Text + " " + comboBox3.Text;
            string durum = comboBox5.Text;
            int guncel;
            if (radioButton3.Checked)
            {
                 guncel = Convert.ToInt32(textBox4.Text);
            }

            else
            {
                 guncel = 50;
            }
            aidat_bilgisi yeniGiris = new aidat_bilgisi
            {
                TC = tc,
                ad = ad,
                soyad = soyad,
                aidat_donem = aidat_donem,
                odeme_durumu = durum,
                zaman = zaman1,
                Tutar = guncel,
            };

            using (DBContext c = new DBContext())
            {
                c.aidat_bilgisi.Add(yeniGiris);
                c.SaveChanges();
                YenileDataGridView();
            }
            MessageBox.Show("Ödeme Başarıyla Alındı...", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            odemetc.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            comboBox3.Text = "";
            comboBox5.Text = "";
            comboBox4.Text = "";
            button2.Enabled = false;
            comboBox3.Enabled = false;
            comboBox4.Enabled = false;
            comboBox5.Enabled = false;
            dateTimePicker1.Enabled = false;
            label15.Visible = false;
            textBox4.Visible = false;
            radioButton3.Enabled = false;
            radioButton4.Enabled = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;

        }

        private void YenileDataGridView()
        {
            using (DBContext c = new DBContext())
            {
                dataGridView1.DataSource = c.aidat_bilgisi.ToList();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            YenileDataGridView();
        }

        private void btnlistele_Click(object sender, EventArgs e)
        {
            long tc5 = long.Parse(tctxt.Text);

            using (var dbContext = new DBContext())
            {
                // TC'ye göre uyeler ve aidat_tablosu tablolarını birleştirip, odeme_durumu "Yapılmadı" olanları seçme
                var sonuc = from uye in dbContext.uyeler
                            join aidat in dbContext.aidat_bilgisi on uye.TC equals aidat.TC
                            where uye.TC ==tc5 
                            select new { Uye = uye, Aidat = aidat };

                if (sonuc.Any())
                {
                    dataGridView1.DataSource = sonuc.ToList();
                    foreach (var kayit in sonuc)
                    {
                        MessageBox.Show($"TC: {kayit.Uye.TC}, Ad: {kayit.Uye.ad}, Soyad: {kayit.Uye.soyad}, Tutar: {kayit.Aidat.Tutar}");
                        // İhtiyaca göre diğer alanları da ekleyebilirsiniz
                    }
                }
                else
                {
                    MessageBox.Show("Kayıt Getirilemedi");
                }


            }
        }

        private void tctxt_TextChanged(object sender, EventArgs e)
        {
            btnlistele.Enabled = true;
        }

        static void mailServis(string recipientEmail)
        {
            
                try
            {
                // SMTP sunucu ayarları (Gmail için örnek)
                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com");
                smtpClient.Port = 587;
                smtpClient.Credentials = new NetworkCredential("furkantaser16@gmail.com", "jgnhuytpmfouwean");
                smtpClient.EnableSsl = true;

                // Gönderen ve alıcı e-posta adresleri
                MailMessage mailMessage = new MailMessage();
                mailMessage.From = new MailAddress("furkantaser16@gmail.com");
                mailMessage.To.Add(recipientEmail);

                // E-posta konu ve içeriği
                mailMessage.Subject = "Ödeme Hatırlatması";
                using (DBContext c = new DBContext())
                {
                    string icerik1 = c.mailServis
                                        .Where(ms => ms.alan == "birincil")
                                        .Select(ms => ms.icerik)
                                        .FirstOrDefault();

                    if (icerik1 != null)
                    {
                        mailMessage.Body = icerik1;
                    }
                    else
                    {
                        mailMessage.Body = "Ödemenizi yapmayı unuttunuz. Lütfen en kısa sürede ödemeyi gerçekleştirin.";

                    }

                }
                // E-posta gönderme işlemi
                smtpClient.Send(mailMessage);

                
            }
            catch (Exception ex)
            {
                Console.WriteLine($"E-posta gönderme hatası: {ex.Message}");
            }
        }
        static void case1()
        {
            using (var c = new DBContext())
            {
                var odemeYapilmamisKullanicilar = c.aidat_bilgisi
                    .Where(k => k.odeme_durumu == "Yapılmadı")
                    .ToList();

                // TC'leri kullanarak e-posta adreslerini çekme
                var tcListesi = odemeYapilmamisKullanicilar.Select(k => k.TC).ToList();
                var epostaAdresleri = c.uyeler
                    .Where(u => tcListesi.Contains(u.TC))
                    .Select(u => u.e_mail)
                    .ToList();


                foreach (var mail in epostaAdresleri)
                {
                    mailServis(mail);
                }

            }
        }
        static void case2()
        {
            using (var c = new DBContext())
            {
                var odemeYapilmamisKullanicilar = c.aidat_bilgisi
                    .Where(k => k.odeme_durumu == "Yapıldı")
                    .ToList();

                // TC'leri kullanarak e-posta adreslerini çekme
                var epostaAdresleri = c.uyeler
                    .Where(u => odemeYapilmamisKullanicilar.Select(k => k.TC).Contains(u.TC))
                    .Select(u => u.e_mail)
                    .ToList();

                foreach (var mail in epostaAdresleri)
                {
                    mailServis(mail);
                }
            }

        }
        static void case3()
        {
            using (var context = new DBContext())
            {
                var tumMailler = context.uyeler.Select(u => u.e_mail).ToList();
                
                foreach(var mail in tumMailler)
                {
                    mailServis(mail);
                }

            }

        }
        private void btngonder_Click(object sender, EventArgs e)
        {
            if (comboBox1 == null)
            {
                MessageBox.Show("İletmek İstediğiniz Listeyi Seçiniz.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;

            }
            int seciliIslem = comboBox1.SelectedIndex;

            switch (seciliIslem)
            {
                case 0:
                    case1();
                    break;

                case 1:
                    case2();
                    break;

                case 2:
                    case3();
                    break;

                default:
                    break;
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            btngonder.Enabled = true;
        }

        public void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            textBox4.Visible = true;
            label15.Visible = true;
        }

        public void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            label15.Visible = false;
            textBox4.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (var dbContext = new DBContext())
            {
                // TC'ye göre uyeler ve aidat_tablosu tablolarını birleştirip, odeme_durumu "Yapılmadı" olanları seçme
                var sonuc = from uye in dbContext.uyeler
                            join aidat in dbContext.aidat_bilgisi on uye.TC equals aidat.TC
                            where aidat.odeme_durumu == "Yapılmadı"
                            select new { Uye = uye, Aidat = aidat };
                if (sonuc.Any())
                {
                    string pdfPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "YapilmadiAidatlar.pdf");
                    using (var writer = new PdfWriter(pdfPath))
                    {
                        using (var pdf = new PdfDocument(writer))
                        {
                            var document = new Document(pdf);

                            // PDF'e başlık ekleyebilirsiniz
                            document.Add(new Paragraph("Odeme_durumu 'Yapılmadı' Olan Aidat Kayıtları"));

                            // Her kaydı PDF'e ekleyin
                            foreach (var kayit in sonuc)
                            {
                                document.Add(new Paragraph($"TC: {kayit.Uye.TC}, Ad: {kayit.Uye.ad}, Soyad: {kayit.Uye.soyad}, Tutar: {kayit.Aidat.Tutar}"));
                                // İhtiyaca göre diğer alanları da ekleyebilirsiniz
                            }
                        }
                    }
                    MessageBox.Show($"PDF dosyası başarıyla oluşturuldu: {pdfPath}", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

                else
                {
                    MessageBox.Show("Odeme_durumu 'Yapılmadı' olan kayıt bulunamadı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                


            }
        }
    }
}

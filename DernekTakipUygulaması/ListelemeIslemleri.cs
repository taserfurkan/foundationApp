using EntityLayer;
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
    public partial class ListelemeIslemleri : Form
    {
        public ListelemeIslemleri()
        {
            InitializeComponent(); this.StartPosition = FormStartPosition.CenterScreen;
            label2.Visible = false;
            kanCombo.Visible = false;
            btnlistele.Visible = false;
            sehirCombo.Visible = false;
            kanCombo.Visible = false;
            durumCombo.Visible = false;
            baslangicdate.Visible = false;
            bitisdate.Visible = false;

        }

        private void btngeri_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnsec_Click(object sender, EventArgs e)
        {
            if (ozellikcombo.SelectedIndex == 0)
            {
                btnlistele.Visible = false;
                sehirCombo.Visible = false;
                kanCombo.Visible = false;
                durumCombo.Visible = false;
                baslangicdate.Visible = false;
                bitisdate.Visible = false;

                label2.Visible = true;
                kanCombo.Visible = true;
                btnlistele.Visible = true;


            }

            if (ozellikcombo.SelectedIndex == 1)
            {
                kanCombo.Visible = false;
                btnlistele.Visible = false;
                kanCombo.Visible = false;
                durumCombo.Visible = false;
                baslangicdate.Visible = false;
                bitisdate.Visible = false;

                label2.Text = "Lütfen Şehir Seçiniz:";
                label2.Visible = true;
                sehirCombo.Visible = true;
                btnlistele.Visible = true;


            }

            if (ozellikcombo.SelectedIndex == 2)
            {
                kanCombo.Visible = false;
                btnlistele.Visible = false;
                sehirCombo.Visible = false;
                kanCombo.Visible = false;
                baslangicdate.Visible = false;
                bitisdate.Visible = false;

                label2.Text = "Lütfen Üye Durumunu Seçiniz:";
                label2.Visible = true;
                durumCombo.Visible = true;
                btnlistele.Visible = true;


            }

            if (ozellikcombo.SelectedIndex == 3)
            {
                label2.Visible = false;
                kanCombo.Visible = false;
                btnlistele.Visible = false;
                sehirCombo.Visible = false;
                kanCombo.Visible = false;
                durumCombo.Visible = false;
                baslangicdate.Visible = false;
                bitisdate.Visible = false;
                using (var c = new DBContext())
                {
                    var odemeYapilmamisKullanicilar = c.aidat_bilgisi
                        .Where(k => k.odeme_durumu == "Yapılmadı")
                        .ToList();

                    dataGridView1.DataSource = odemeYapilmamisKullanicilar;
                }
            }

            if (ozellikcombo.SelectedIndex == 4)
            {
                kanCombo.Visible = false;
                btnlistele.Visible = false;
                sehirCombo.Visible = false;
                kanCombo.Visible = false;
                durumCombo.Visible = false;

                label2.Text = "Lütfen Başlangıç ve Bitiş Tarihi Seçiniz:";
                label2.Visible = true;
                baslangicdate.Visible = true;
                bitisdate.Visible = true;
                btnlistele.Visible = true;


            }

        }

        private void btnlistele_Click(object sender, EventArgs e)
        {
            if (ozellikcombo.SelectedIndex == 0)
            {
                string kanGrubu = kanCombo.Text; // İlgili kan grubunu seçin

                using (var context = new DBContext())
                {
                    var uyeListesi = new List<uyeler>();

                    switch (kanGrubu)
                    {
                        case "A Rh+":
                            uyeListesi = context.uyeler.Where(u => u.kan == "A Rh+").ToList();
                            break;

                        case "B Rh-":
                            uyeListesi = context.uyeler.Where(u => u.kan == "B Rh-").ToList();
                            break;

                        case "AB Rh+":
                            uyeListesi = context.uyeler.Where(u => u.kan == "AB Rh+").ToList();
                            break;

                        // Diğer kan gruplarına göre case'leri ekleyin

                        default:
                            Console.WriteLine("Belirtilen kan grubu bulunamadı.");
                            break;
                    }

                    dataGridView1.DataSource = uyeListesi;
                }
            }
            if(ozellikcombo.SelectedIndex == 1)
            {
                string sehir = sehirCombo.Text; // İlgili kan grubunu seçin

                using (var context = new DBContext())
                {
                    var uyeListesi = new List<uyeler>();
                    uyeListesi = context.uyeler.Where(u => u.sehir == sehir).ToList();
                    dataGridView1.DataSource = uyeListesi;
                }

            }
            if(ozellikcombo.SelectedIndex == 2)
            {
                string durum = durumCombo.Text; // İlgili kan grubunu seçin

                using (var context = new DBContext())
                {
                    var uyeListesi = new List<uyeler>();
                    uyeListesi = context.uyeler.Where(u => u.uye_durum == durum).ToList();
                    dataGridView1.DataSource = uyeListesi;
                }
            }
            if (ozellikcombo.SelectedIndex == 4) 
            {
                DateTime baslangicZamani = baslangicdate.Value; // Belirli bir başlangıç tarihi
                DateTime bitisZamani = bitisdate.Value; // Belirli bir bitiş tarihi

                using (var context = new DBContext())
                {
                    var kayitlar = context.aidat_bilgisi
                                          .Where(ab => ab.zaman >= baslangicZamani && ab.zaman <= bitisZamani)
                                          .ToList();
                    dataGridView1.DataSource = kayitlar;


                }
            }
        }
    }
}

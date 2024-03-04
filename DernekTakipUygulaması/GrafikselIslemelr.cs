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
using ZedGraph;

namespace DernekTakipUygulaması
{
    public partial class GrafikselIslemelr : Form
    {
        public GrafikselIslemelr()
        {
            InitializeComponent(); this.StartPosition = FormStartPosition.CenterScreen;
            

        }

        private void btngeri_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            
        }

        private void btnsec_Click(object sender, EventArgs e)
        {
            if (degerCombo.SelectedIndex == 0)
            {
                gelirGoster();
               

            }

            if(degerCombo.SelectedIndex == 1)
            {

                sehirGrafik();
            }

            
        }
        private void sehirGrafik()
        {
            zedGraphControl1.GraphPane = new GraphPane();
            zedGraphControl1.GraphPane.Title.Text = "Üye Sayıları";
            zedGraphControl1.GraphPane.XAxis.Title.Text = "İller";
            zedGraphControl1.GraphPane.YAxis.Title.Text = "Üye Sayısı";

            using (var context = new DBContext())
            {
                // İllere göre üye sayısını bulma
                var cityMemberCounts = context.uyeler
                    .GroupBy(u => u.sehir)
                    .Select(group => new
                    {
                        City = group.Key,
                        MemberCount = group.Count()
                    })
                    .OrderBy(x => x.City) // İlleri alfabetik sıraya göre sırala
                    .ToList();

                if (cityMemberCounts.Any())
                {
                    // X ekseni için illeri ayarla
                    var xLabels = cityMemberCounts.Select(x => x.City).ToArray();
                    zedGraphControl1.GraphPane.XAxis.Scale.TextLabels = xLabels;
                    zedGraphControl1.GraphPane.XAxis.Type = AxisType.Text;

                    // Bar tipi bir grafik oluşturma
                    var barItem = zedGraphControl1.GraphPane.AddBar("Üye Sayısı", null,
                        cityMemberCounts.Select(x => (double)x.MemberCount).ToArray(), Color.Blue);

                    // Grafik güncelleme
                    zedGraphControl1.AxisChange();
                    zedGraphControl1.Invalidate();
                }
                else
                {
                    MessageBox.Show("Hiç üye bulunmamaktadır.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void gelirGoster()
        {
            GraphPane myPane = zedGraphControl1.GraphPane;
            myPane.Title.Text = "Aidat Geliri Grafiği";
            myPane.XAxis.Title.Text = "Tarih";
            myPane.YAxis.Title.Text = "Tutar";

            PointPairList aylıkPoints = new PointPairList();
            PointPairList yıllıkPoints = new PointPairList();

            using (var context = new DBContext())
            {
                List<aidat_bilgisi> aidatListesi = context.aidat_bilgisi.ToList();

                foreach (aidat_bilgisi aidat in aidatListesi)
                {
                    DateTime tarih = aidat.zaman;
                    double aylikToplam = aidatListesi
                        .Where(a => a.zaman.Month == tarih.Month && a.zaman.Year == tarih.Year && a.odeme_durumu =="Yapıldı")
                        .Sum(a => a.Tutar);

                    double yillikToplam = aidatListesi
                        .Where(a => a.zaman.Year == tarih.Year && a.odeme_durumu =="Yapıldı")
                        .Sum(a => a.Tutar);

                    aylıkPoints.Add(new XDate(tarih), aylikToplam);
                    yıllıkPoints.Add(new XDate(tarih), yillikToplam);
                }

                LineItem aylıkCurve = myPane.AddCurve("Aylık", aylıkPoints, System.Drawing.Color.Blue, SymbolType.None);
                LineItem yıllıkCurve = myPane.AddCurve("Yıllık", yıllıkPoints, System.Drawing.Color.Red, SymbolType.None);
                myPane.AxisChange();
                zedGraphControl1.Invalidate();


            }
            
        }
    }
}

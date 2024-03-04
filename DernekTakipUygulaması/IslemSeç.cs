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
    public partial class IslemSeç : Form
    {
        public IslemSeç()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

        }

        private void btnuyeislemleri_Click(object sender, EventArgs e)
        {
            UyeIslemleri form3 = new UyeIslemleri();
            this.Hide();
            form3.ShowDialog();
            this.Show(); 

        }

        private void btnaidatislemleri_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            this.Hide();
            form4.ShowDialog();
            this.Show();
        }

        private void btnlistelemeislemleri_Click(object sender, EventArgs e)
        {
            ListelemeIslemleri form5 = new ListelemeIslemleri();
            this.Hide();
            form5.ShowDialog();
            this.Show();
        }

        private void btngrafikislemleri_Click(object sender, EventArgs e)
        {
            GrafikselIslemelr form6 = new GrafikselIslemelr();
            this.Hide();
            form6.ShowDialog();
            this.Show();
        }
    }
}

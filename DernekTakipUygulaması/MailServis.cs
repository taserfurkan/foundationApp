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
    public partial class MailServis : Form
    {
        public MailServis()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            button1.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string icerik1 = richTextBox1.Text; ;

            using (DBContext c = new DBContext())
            {
                mailServis secili = c.mailServis.FirstOrDefault(k => k.alan == "birincil");

                if (secili != null)
                {
                    secili.icerik = icerik1;
                    c.Update(secili);
                    c.SaveChanges();
                    
                }
                else
                {
                    MessageBox.Show("Belirtilen ay aidat tutarı güncellenmedi.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            this.Close();

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;

        }
    }
}

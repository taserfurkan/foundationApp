
namespace DernekTakipUygulaması
{
    partial class GrafikselIslemelr
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GrafikselIslemelr));
            this.btngeri = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.degerCombo = new System.Windows.Forms.ComboBox();
            this.btnsec = new System.Windows.Forms.Button();
            this.zedGraphControl1 = new ZedGraph.ZedGraphControl();
            this.SuspendLayout();
            // 
            // btngeri
            // 
            this.btngeri.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btngeri.BackgroundImage")));
            this.btngeri.Location = new System.Drawing.Point(1075, 17);
            this.btngeri.Name = "btngeri";
            this.btngeri.Size = new System.Drawing.Size(75, 62);
            this.btngeri.TabIndex = 1;
            this.btngeri.UseVisualStyleBackColor = true;
            this.btngeri.Click += new System.EventHandler(this.btngeri_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Lütfen Görmek İstediğiniz Grafiksel Veriyi Seçiniz:";
            // 
            // degerCombo
            // 
            this.degerCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.degerCombo.FormattingEnabled = true;
            this.degerCombo.Items.AddRange(new object[] {
            "Aidat Gelirlerinin Aylık/Yıllık Bazda Gösterimi",
            "Şehirlere Göre Üye Dağılımları"});
            this.degerCombo.Location = new System.Drawing.Point(292, 17);
            this.degerCombo.Name = "degerCombo";
            this.degerCombo.Size = new System.Drawing.Size(388, 23);
            this.degerCombo.TabIndex = 3;
            // 
            // btnsec
            // 
            this.btnsec.Location = new System.Drawing.Point(686, 17);
            this.btnsec.Name = "btnsec";
            this.btnsec.Size = new System.Drawing.Size(102, 23);
            this.btnsec.TabIndex = 4;
            this.btnsec.Text = "Seç";
            this.btnsec.UseVisualStyleBackColor = true;
            this.btnsec.Click += new System.EventHandler(this.btnsec_Click);
            // 
            // zedGraphControl1
            // 
            this.zedGraphControl1.Location = new System.Drawing.Point(23, 95);
            this.zedGraphControl1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.zedGraphControl1.Name = "zedGraphControl1";
            this.zedGraphControl1.ScrollGrace = 0D;
            this.zedGraphControl1.ScrollMaxX = 0D;
            this.zedGraphControl1.ScrollMaxY = 0D;
            this.zedGraphControl1.ScrollMaxY2 = 0D;
            this.zedGraphControl1.ScrollMinX = 0D;
            this.zedGraphControl1.ScrollMinY = 0D;
            this.zedGraphControl1.ScrollMinY2 = 0D;
            this.zedGraphControl1.Size = new System.Drawing.Size(1127, 528);
            this.zedGraphControl1.TabIndex = 8;
            this.zedGraphControl1.UseExtendedPrintDialog = true;
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 660);
            this.Controls.Add(this.zedGraphControl1);
            this.Controls.Add(this.btnsec);
            this.Controls.Add(this.degerCombo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btngeri);
            this.Name = "Form6";
            this.Text = "Grafiksel İşlemler";
            this.Load += new System.EventHandler(this.Form6_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btngeri;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox degerCombo;
        private System.Windows.Forms.Button btnsec;
        private ZedGraph.ZedGraphControl zedGraphControl1;
    }
}
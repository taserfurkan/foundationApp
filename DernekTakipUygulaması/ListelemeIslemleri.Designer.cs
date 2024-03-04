
namespace DernekTakipUygulaması
{
    partial class ListelemeIslemleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListelemeIslemleri));
            this.btngeri = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ozellikcombo = new System.Windows.Forms.ComboBox();
            this.btnsec = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.kanCombo = new System.Windows.Forms.ComboBox();
            this.btnlistele = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sehirCombo = new System.Windows.Forms.ComboBox();
            this.durumCombo = new System.Windows.Forms.ComboBox();
            this.baslangicdate = new System.Windows.Forms.DateTimePicker();
            this.bitisdate = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btngeri
            // 
            this.btngeri.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btngeri.BackgroundImage")));
            this.btngeri.Location = new System.Drawing.Point(713, 376);
            this.btngeri.Name = "btngeri";
            this.btngeri.Size = new System.Drawing.Size(75, 62);
            this.btngeri.TabIndex = 1;
            this.btngeri.UseVisualStyleBackColor = true;
            this.btngeri.Click += new System.EventHandler(this.btngeri_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Listeleme Yapmak İstediğiniz Özelliği Seçiniz";
            // 
            // ozellikcombo
            // 
            this.ozellikcombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ozellikcombo.FormattingEnabled = true;
            this.ozellikcombo.Items.AddRange(new object[] {
            "Kan Grubu",
            "Şehir",
            "Üye Durumu",
            "Borçlu Olan Üyeler",
            "İki Tarih Arasında Ödeme Yapanlar ve Yapmayanlar"});
            this.ozellikcombo.Location = new System.Drawing.Point(257, 6);
            this.ozellikcombo.Name = "ozellikcombo";
            this.ozellikcombo.Size = new System.Drawing.Size(415, 23);
            this.ozellikcombo.TabIndex = 3;
            // 
            // btnsec
            // 
            this.btnsec.Location = new System.Drawing.Point(678, 5);
            this.btnsec.Name = "btnsec";
            this.btnsec.Size = new System.Drawing.Size(110, 23);
            this.btnsec.TabIndex = 4;
            this.btnsec.Text = "Seç";
            this.btnsec.UseVisualStyleBackColor = true;
            this.btnsec.Click += new System.EventHandler(this.btnsec_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Lütfen Kan Grubu Seçiniz:";
            // 
            // kanCombo
            // 
            this.kanCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.kanCombo.FormattingEnabled = true;
            this.kanCombo.Items.AddRange(new object[] {
            "A Rh+",
            "A Rh-",
            "B Rh+",
            "B Rh-",
            "AB Rh+",
            "AB Rh-",
            "0 Rh+",
            "0 Rh-"});
            this.kanCombo.Location = new System.Drawing.Point(257, 38);
            this.kanCombo.Name = "kanCombo";
            this.kanCombo.Size = new System.Drawing.Size(415, 23);
            this.kanCombo.TabIndex = 6;
            // 
            // btnlistele
            // 
            this.btnlistele.Location = new System.Drawing.Point(678, 38);
            this.btnlistele.Name = "btnlistele";
            this.btnlistele.Size = new System.Drawing.Size(110, 23);
            this.btnlistele.TabIndex = 7;
            this.btnlistele.Text = "Listele";
            this.btnlistele.UseVisualStyleBackColor = true;
            this.btnlistele.Click += new System.EventHandler(this.btnlistele_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 80);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(776, 290);
            this.dataGridView1.TabIndex = 8;
            // 
            // sehirCombo
            // 
            this.sehirCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sehirCombo.FormattingEnabled = true;
            this.sehirCombo.Items.AddRange(new object[] {
            "Adana",
            "Adıyaman",
            "Afyonkarahisar",
            "Ağrı",
            "Amasya",
            "Ankara",
            "Antalya",
            "Artvin",
            "Aydın",
            "Balıkesir",
            "Bilecik",
            "Bingöl",
            "Bitlis",
            "Bolu",
            "Burdur",
            "Bursa",
            "Çanakkale",
            "Çankırı",
            "Çorum",
            "Denizli",
            "Diyarbakır",
            "Edirne",
            "Elazığ",
            "Erzincan",
            "Erzurum",
            "Eskişehir",
            "Gaziantep",
            "Giresun",
            "Gümüşhane",
            "Hakkâri",
            "Hatay",
            "Isparta",
            "Mersin",
            "İstanbul",
            "İzmir",
            "Kars",
            "Kastamonu",
            "Kayseri",
            "Kırklareli",
            "Kırşehir",
            "Kocaeli",
            "Konya",
            "Kütahya",
            "Malatya",
            "Manisa",
            "Kahramanmaraş",
            "Mardin",
            "Muğla",
            "Muş",
            "Nevşehir",
            "Niğde",
            "Ordu",
            "Rize",
            "Sakarya",
            "Samsun",
            "Siirt",
            "Sinop",
            "Sivas",
            "Tekirdağ",
            "Tokat",
            "Trabzon",
            "Tunceli",
            "Şanlıurfa",
            "Uşak",
            "Van",
            "Yozgat",
            "Zonguldak",
            "Aksaray",
            "Bayburt",
            "Karaman",
            "Kırıkkale",
            "Batman",
            "Şırnak",
            "Bartın",
            "Ardahan",
            "Iğdır",
            "Yalova",
            "Karabük",
            "Kilis",
            "Osmaniye",
            "Düzce"});
            this.sehirCombo.Location = new System.Drawing.Point(257, 38);
            this.sehirCombo.Name = "sehirCombo";
            this.sehirCombo.Size = new System.Drawing.Size(415, 23);
            this.sehirCombo.TabIndex = 11;
            // 
            // durumCombo
            // 
            this.durumCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.durumCombo.FormattingEnabled = true;
            this.durumCombo.Items.AddRange(new object[] {
            "Aktif",
            "Pasif"});
            this.durumCombo.Location = new System.Drawing.Point(257, 38);
            this.durumCombo.Name = "durumCombo";
            this.durumCombo.Size = new System.Drawing.Size(415, 23);
            this.durumCombo.TabIndex = 12;
            // 
            // baslangicdate
            // 
            this.baslangicdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.baslangicdate.Location = new System.Drawing.Point(257, 38);
            this.baslangicdate.Name = "baslangicdate";
            this.baslangicdate.Size = new System.Drawing.Size(186, 23);
            this.baslangicdate.TabIndex = 13;
            // 
            // bitisdate
            // 
            this.bitisdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.bitisdate.Location = new System.Drawing.Point(490, 38);
            this.bitisdate.Name = "bitisdate";
            this.bitisdate.Size = new System.Drawing.Size(182, 23);
            this.bitisdate.TabIndex = 14;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bitisdate);
            this.Controls.Add(this.baslangicdate);
            this.Controls.Add(this.durumCombo);
            this.Controls.Add(this.sehirCombo);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnlistele);
            this.Controls.Add(this.kanCombo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnsec);
            this.Controls.Add(this.ozellikcombo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btngeri);
            this.Name = "Form5";
            this.Text = "Listeleme İşlemleri";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btngeri;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ozellikcombo;
        private System.Windows.Forms.Button btnsec;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox kanCombo;
        private System.Windows.Forms.Button btnlistele;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox sehirCombo;
        private System.Windows.Forms.ComboBox durumCombo;
        private System.Windows.Forms.DateTimePicker baslangicdate;
        private System.Windows.Forms.DateTimePicker bitisdate;
    }
}
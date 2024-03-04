
namespace DernekTakipUygulaması
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btngiris = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.kullanicitxt = new System.Windows.Forms.TextBox();
            this.sifretxt = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btngiris
            // 
            this.btngiris.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btngiris.Location = new System.Drawing.Point(87, 392);
            this.btngiris.Name = "btngiris";
            this.btngiris.Size = new System.Drawing.Size(126, 23);
            this.btngiris.TabIndex = 0;
            this.btngiris.Text = "Giriş Yap";
            this.btngiris.UseVisualStyleBackColor = false;
            this.btngiris.Click += new System.EventHandler(this.btngiris_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 327);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kullanıcı Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 356);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Şifre";
            // 
            // kullanicitxt
            // 
            this.kullanicitxt.Location = new System.Drawing.Point(125, 319);
            this.kullanicitxt.Name = "kullanicitxt";
            this.kullanicitxt.Size = new System.Drawing.Size(139, 23);
            this.kullanicitxt.TabIndex = 3;
            // 
            // sifretxt
            // 
            this.sifretxt.Location = new System.Drawing.Point(125, 348);
            this.sifretxt.Name = "sifretxt";
            this.sifretxt.PasswordChar = '*';
            this.sifretxt.Size = new System.Drawing.Size(139, 23);
            this.sifretxt.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(45, 77);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(219, 204);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 506);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.sifretxt);
            this.Controls.Add(this.kullanicitxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btngiris);
            this.Name = "Form1";
            this.Text = "Dernek Takip Uygulaması";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btngiris;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox kullanicitxt;
        private System.Windows.Forms.TextBox sifretxt;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}


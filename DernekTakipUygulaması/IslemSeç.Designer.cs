
namespace DernekTakipUygulaması
{
    partial class IslemSeç
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IslemSeç));
            this.btnuyeislemleri = new System.Windows.Forms.Button();
            this.btnlistelemeislemleri = new System.Windows.Forms.Button();
            this.btnaidatislemleri = new System.Windows.Forms.Button();
            this.btngrafikislemleri = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnuyeislemleri
            // 
            this.btnuyeislemleri.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnuyeislemleri.BackgroundImage")));
            this.btnuyeislemleri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnuyeislemleri.Location = new System.Drawing.Point(12, 12);
            this.btnuyeislemleri.Name = "btnuyeislemleri";
            this.btnuyeislemleri.Size = new System.Drawing.Size(440, 250);
            this.btnuyeislemleri.TabIndex = 0;
            this.btnuyeislemleri.UseVisualStyleBackColor = true;
            this.btnuyeislemleri.Click += new System.EventHandler(this.btnuyeislemleri_Click);
            // 
            // btnlistelemeislemleri
            // 
            this.btnlistelemeislemleri.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnlistelemeislemleri.BackgroundImage")));
            this.btnlistelemeislemleri.Location = new System.Drawing.Point(12, 298);
            this.btnlistelemeislemleri.Name = "btnlistelemeislemleri";
            this.btnlistelemeislemleri.Size = new System.Drawing.Size(440, 250);
            this.btnlistelemeislemleri.TabIndex = 1;
            this.btnlistelemeislemleri.UseVisualStyleBackColor = true;
            this.btnlistelemeislemleri.Click += new System.EventHandler(this.btnlistelemeislemleri_Click);
            // 
            // btnaidatislemleri
            // 
            this.btnaidatislemleri.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnaidatislemleri.BackgroundImage")));
            this.btnaidatislemleri.Location = new System.Drawing.Point(494, 12);
            this.btnaidatislemleri.Name = "btnaidatislemleri";
            this.btnaidatislemleri.Size = new System.Drawing.Size(440, 250);
            this.btnaidatislemleri.TabIndex = 2;
            this.btnaidatislemleri.UseVisualStyleBackColor = true;
            this.btnaidatislemleri.Click += new System.EventHandler(this.btnaidatislemleri_Click);
            // 
            // btngrafikislemleri
            // 
            this.btngrafikislemleri.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btngrafikislemleri.BackgroundImage")));
            this.btngrafikislemleri.Location = new System.Drawing.Point(494, 298);
            this.btngrafikislemleri.Name = "btngrafikislemleri";
            this.btngrafikislemleri.Size = new System.Drawing.Size(440, 250);
            this.btngrafikislemleri.TabIndex = 3;
            this.btngrafikislemleri.UseVisualStyleBackColor = true;
            this.btngrafikislemleri.Click += new System.EventHandler(this.btngrafikislemleri_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 560);
            this.Controls.Add(this.btngrafikislemleri);
            this.Controls.Add(this.btnaidatislemleri);
            this.Controls.Add(this.btnlistelemeislemleri);
            this.Controls.Add(this.btnuyeislemleri);
            this.Name = "Form2";
            this.Text = "İşlemler Menüsü";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnuyeislemleri;
        private System.Windows.Forms.Button btnlistelemeislemleri;
        private System.Windows.Forms.Button btnaidatislemleri;
        private System.Windows.Forms.Button btngrafikislemleri;
    }
}
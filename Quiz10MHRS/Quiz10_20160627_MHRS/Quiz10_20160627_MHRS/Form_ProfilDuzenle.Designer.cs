namespace Quiz10_20160627_MHRS
{
    partial class Form_ProfilDuzenle
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
            this.tbx_yeniSifre2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbx_yeniSifre = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_guncelle = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_geri = new System.Windows.Forms.Button();
            this.btn_titleUyeKayit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbx_yeniSifre2
            // 
            this.tbx_yeniSifre2.Font = new System.Drawing.Font("Verdana", 9F);
            this.tbx_yeniSifre2.Location = new System.Drawing.Point(8, 128);
            this.tbx_yeniSifre2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbx_yeniSifre2.Name = "tbx_yeniSifre2";
            this.tbx_yeniSifre2.Size = new System.Drawing.Size(224, 29);
            this.tbx_yeniSifre2.TabIndex = 14;
            this.tbx_yeniSifre2.UseSystemPasswordChar = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 9F);
            this.label7.Location = new System.Drawing.Point(8, 94);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(166, 22);
            this.label7.TabIndex = 13;
            this.label7.Text = "Şifre Doğrulama:";
            // 
            // tbx_yeniSifre
            // 
            this.tbx_yeniSifre.Font = new System.Drawing.Font("Verdana", 9F);
            this.tbx_yeniSifre.Location = new System.Drawing.Point(8, 36);
            this.tbx_yeniSifre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbx_yeniSifre.Name = "tbx_yeniSifre";
            this.tbx_yeniSifre.Size = new System.Drawing.Size(224, 29);
            this.tbx_yeniSifre.TabIndex = 11;
            this.tbx_yeniSifre.UseSystemPasswordChar = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 9F);
            this.label6.Location = new System.Drawing.Point(8, 11);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 22);
            this.label6.TabIndex = 5;
            this.label6.Text = "Yeni Şifre:";
            // 
            // btn_guncelle
            // 
            this.btn_guncelle.BackColor = System.Drawing.Color.SeaShell;
            this.btn_guncelle.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_guncelle.FlatAppearance.BorderSize = 0;
            this.btn_guncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_guncelle.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_guncelle.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btn_guncelle.Location = new System.Drawing.Point(0, 376);
            this.btn_guncelle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_guncelle.Name = "btn_guncelle";
            this.btn_guncelle.Size = new System.Drawing.Size(380, 62);
            this.btn_guncelle.TabIndex = 44;
            this.btn_guncelle.Text = "Güncelle";
            this.btn_guncelle.UseVisualStyleBackColor = false;
            this.btn_guncelle.Click += new System.EventHandler(this.btn_guncelle_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tbx_yeniSifre2);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.tbx_yeniSifre);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(35, 113);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(303, 240);
            this.panel1.TabIndex = 43;
            // 
            // btn_geri
            // 
            this.btn_geri.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn_geri.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_geri.FlatAppearance.BorderSize = 0;
            this.btn_geri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_geri.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_geri.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btn_geri.Location = new System.Drawing.Point(0, 438);
            this.btn_geri.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_geri.Name = "btn_geri";
            this.btn_geri.Size = new System.Drawing.Size(380, 62);
            this.btn_geri.TabIndex = 42;
            this.btn_geri.Text = "Geri Dön";
            this.btn_geri.UseVisualStyleBackColor = false;
            this.btn_geri.Click += new System.EventHandler(this.btn_geri_Click);
            // 
            // btn_titleUyeKayit
            // 
            this.btn_titleUyeKayit.BackColor = System.Drawing.Color.LightSalmon;
            this.btn_titleUyeKayit.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_titleUyeKayit.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btn_titleUyeKayit.FlatAppearance.BorderSize = 0;
            this.btn_titleUyeKayit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btn_titleUyeKayit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btn_titleUyeKayit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_titleUyeKayit.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_titleUyeKayit.ForeColor = System.Drawing.Color.White;
            this.btn_titleUyeKayit.Location = new System.Drawing.Point(0, 0);
            this.btn_titleUyeKayit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_titleUyeKayit.Name = "btn_titleUyeKayit";
            this.btn_titleUyeKayit.Size = new System.Drawing.Size(380, 92);
            this.btn_titleUyeKayit.TabIndex = 41;
            this.btn_titleUyeKayit.Text = "PROFİL DÜZENLE";
            this.btn_titleUyeKayit.UseVisualStyleBackColor = false;
            // 
            // Form_ProfilDuzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(380, 500);
            this.Controls.Add(this.btn_guncelle);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_geri);
            this.Controls.Add(this.btn_titleUyeKayit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(200, 200);
            this.Name = "Form_ProfilDuzenle";
            this.Text = "Form_ProfilDuzenle";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tbx_yeniSifre2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbx_yeniSifre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_guncelle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_geri;
        private System.Windows.Forms.Button btn_titleUyeKayit;
    }
}
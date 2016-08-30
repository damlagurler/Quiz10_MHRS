namespace Quiz10_20160627_MHRS
{
    partial class Form_UyeKayit
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
            this.btn_kaydol = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmb_cinsiyetHasta = new System.Windows.Forms.ComboBox();
            this.dtp_dogumTarihiHasta = new System.Windows.Forms.DateTimePicker();
            this.tbx_sifre2Hasta = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbx_sifreHastaKayit = new System.Windows.Forms.TextBox();
            this.tbx_tcHastaKayit = new System.Windows.Forms.TextBox();
            this.tbx_soyadHasta = new System.Windows.Forms.TextBox();
            this.tbx_adHasta = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_menuUyeKayit = new System.Windows.Forms.Button();
            this.btn_titleUyeKayit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_kaydol
            // 
            this.btn_kaydol.BackColor = System.Drawing.Color.MistyRose;
            this.btn_kaydol.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_kaydol.FlatAppearance.BorderSize = 0;
            this.btn_kaydol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_kaydol.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kaydol.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btn_kaydol.Location = new System.Drawing.Point(0, 576);
            this.btn_kaydol.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_kaydol.Name = "btn_kaydol";
            this.btn_kaydol.Size = new System.Drawing.Size(550, 62);
            this.btn_kaydol.TabIndex = 38;
            this.btn_kaydol.Text = "Kayıt Ol";
            this.btn_kaydol.UseVisualStyleBackColor = false;
            this.btn_kaydol.Click += new System.EventHandler(this.btn_kaydol_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmb_cinsiyetHasta);
            this.panel1.Controls.Add(this.dtp_dogumTarihiHasta);
            this.panel1.Controls.Add(this.tbx_sifre2Hasta);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.tbx_sifreHastaKayit);
            this.panel1.Controls.Add(this.tbx_tcHastaKayit);
            this.panel1.Controls.Add(this.tbx_soyadHasta);
            this.panel1.Controls.Add(this.tbx_adHasta);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(13, 102);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(511, 454);
            this.panel1.TabIndex = 37;
            // 
            // cmb_cinsiyetHasta
            // 
            this.cmb_cinsiyetHasta.BackColor = System.Drawing.Color.White;
            this.cmb_cinsiyetHasta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_cinsiyetHasta.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmb_cinsiyetHasta.FormattingEnabled = true;
            this.cmb_cinsiyetHasta.Items.AddRange(new object[] {
            "Kadın",
            "Erkek"});
            this.cmb_cinsiyetHasta.Location = new System.Drawing.Point(4, 356);
            this.cmb_cinsiyetHasta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmb_cinsiyetHasta.Name = "cmb_cinsiyetHasta";
            this.cmb_cinsiyetHasta.Size = new System.Drawing.Size(224, 30);
            this.cmb_cinsiyetHasta.TabIndex = 16;
            // 
            // dtp_dogumTarihiHasta
            // 
            this.dtp_dogumTarihiHasta.CalendarFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtp_dogumTarihiHasta.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtp_dogumTarihiHasta.Location = new System.Drawing.Point(4, 271);
            this.dtp_dogumTarihiHasta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtp_dogumTarihiHasta.Name = "dtp_dogumTarihiHasta";
            this.dtp_dogumTarihiHasta.Size = new System.Drawing.Size(224, 29);
            this.dtp_dogumTarihiHasta.TabIndex = 15;
            // 
            // tbx_sifre2Hasta
            // 
            this.tbx_sifre2Hasta.Location = new System.Drawing.Point(260, 119);
            this.tbx_sifre2Hasta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbx_sifre2Hasta.Name = "tbx_sifre2Hasta";
            this.tbx_sifre2Hasta.Size = new System.Drawing.Size(224, 26);
            this.tbx_sifre2Hasta.TabIndex = 14;
            this.tbx_sifre2Hasta.UseSystemPasswordChar = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 9F);
            this.label7.Location = new System.Drawing.Point(256, 92);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(166, 22);
            this.label7.TabIndex = 13;
            this.label7.Text = "Şifre Doğrulama:";
            // 
            // tbx_sifreHastaKayit
            // 
            this.tbx_sifreHastaKayit.Location = new System.Drawing.Point(260, 45);
            this.tbx_sifreHastaKayit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbx_sifreHastaKayit.Name = "tbx_sifreHastaKayit";
            this.tbx_sifreHastaKayit.Size = new System.Drawing.Size(224, 26);
            this.tbx_sifreHastaKayit.TabIndex = 11;
            this.tbx_sifreHastaKayit.UseSystemPasswordChar = true;
            // 
            // tbx_tcHastaKayit
            // 
            this.tbx_tcHastaKayit.Location = new System.Drawing.Point(4, 194);
            this.tbx_tcHastaKayit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbx_tcHastaKayit.Name = "tbx_tcHastaKayit";
            this.tbx_tcHastaKayit.Size = new System.Drawing.Size(224, 26);
            this.tbx_tcHastaKayit.TabIndex = 8;
            // 
            // tbx_soyadHasta
            // 
            this.tbx_soyadHasta.Location = new System.Drawing.Point(4, 119);
            this.tbx_soyadHasta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbx_soyadHasta.Name = "tbx_soyadHasta";
            this.tbx_soyadHasta.Size = new System.Drawing.Size(224, 26);
            this.tbx_soyadHasta.TabIndex = 7;
            // 
            // tbx_adHasta
            // 
            this.tbx_adHasta.Location = new System.Drawing.Point(4, 45);
            this.tbx_adHasta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbx_adHasta.Name = "tbx_adHasta";
            this.tbx_adHasta.Size = new System.Drawing.Size(224, 26);
            this.tbx_adHasta.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 9F);
            this.label6.Location = new System.Drawing.Point(256, 18);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 22);
            this.label6.TabIndex = 5;
            this.label6.Text = "Şifre:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 9F);
            this.label5.Location = new System.Drawing.Point(4, 328);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 22);
            this.label5.TabIndex = 4;
            this.label5.Text = "Cinsiyet:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 9F);
            this.label4.Location = new System.Drawing.Point(4, 244);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Doğum Tarihi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9F);
            this.label3.Location = new System.Drawing.Point(4, 167);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "TC Kimlik No:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9F);
            this.label2.Location = new System.Drawing.Point(4, 92);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(4, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad:";
            // 
            // btn_menuUyeKayit
            // 
            this.btn_menuUyeKayit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_menuUyeKayit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_menuUyeKayit.FlatAppearance.BorderSize = 0;
            this.btn_menuUyeKayit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_menuUyeKayit.Font = new System.Drawing.Font("Verdana", 12F);
            this.btn_menuUyeKayit.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btn_menuUyeKayit.Location = new System.Drawing.Point(0, 638);
            this.btn_menuUyeKayit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_menuUyeKayit.Name = "btn_menuUyeKayit";
            this.btn_menuUyeKayit.Size = new System.Drawing.Size(550, 62);
            this.btn_menuUyeKayit.TabIndex = 36;
            this.btn_menuUyeKayit.Text = "Menü";
            this.btn_menuUyeKayit.UseVisualStyleBackColor = false;
            this.btn_menuUyeKayit.Click += new System.EventHandler(this.btn_menuUyeKayit_Click);
            // 
            // btn_titleUyeKayit
            // 
            this.btn_titleUyeKayit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
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
            this.btn_titleUyeKayit.Size = new System.Drawing.Size(550, 92);
            this.btn_titleUyeKayit.TabIndex = 35;
            this.btn_titleUyeKayit.Text = "ÜYE KAYDI";
            this.btn_titleUyeKayit.UseVisualStyleBackColor = false;
            // 
            // Form_UyeKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(550, 700);
            this.Controls.Add(this.btn_kaydol);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_menuUyeKayit);
            this.Controls.Add(this.btn_titleUyeKayit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form_UyeKayit";
            this.Text = "Form_UyeKayit";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_kaydol;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmb_cinsiyetHasta;
        private System.Windows.Forms.DateTimePicker dtp_dogumTarihiHasta;
        private System.Windows.Forms.TextBox tbx_sifre2Hasta;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbx_sifreHastaKayit;
        private System.Windows.Forms.TextBox tbx_tcHastaKayit;
        private System.Windows.Forms.TextBox tbx_soyadHasta;
        private System.Windows.Forms.TextBox tbx_adHasta;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_menuUyeKayit;
        private System.Windows.Forms.Button btn_titleUyeKayit;
    }
}
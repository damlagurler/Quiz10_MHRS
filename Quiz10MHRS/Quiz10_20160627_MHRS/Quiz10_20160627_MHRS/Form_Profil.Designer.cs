namespace Quiz10_20160627_MHRS
{
    partial class Form_Profil
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
            this.tc_hasta = new System.Windows.Forms.TabControl();
            this.tp_bilgiler = new System.Windows.Forms.TabPage();
            this.rtb_bilgilerHasta = new System.Windows.Forms.RichTextBox();
            this.tp_randevu = new System.Windows.Forms.TabPage();
            this.dgv_randevuHasta = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.tp_reçete = new System.Windows.Forms.TabPage();
            this.cmb_receteHasta = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_randevuAl = new System.Windows.Forms.Button();
            this.btn_profilSil = new System.Windows.Forms.Button();
            this.btn_sifreDegistir = new System.Windows.Forms.Button();
            this.btn_uyeOturumuKapat = new System.Windows.Forms.Button();
            this.btn_titleProfil = new System.Windows.Forms.Button();
            this.btn_menuProfil = new System.Windows.Forms.Button();
            this.rtb_recete = new System.Windows.Forms.RichTextBox();
            this.tc_hasta.SuspendLayout();
            this.tp_bilgiler.SuspendLayout();
            this.tp_randevu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_randevuHasta)).BeginInit();
            this.tp_reçete.SuspendLayout();
            this.SuspendLayout();
            // 
            // tc_hasta
            // 
            this.tc_hasta.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tc_hasta.Controls.Add(this.tp_bilgiler);
            this.tc_hasta.Controls.Add(this.tp_randevu);
            this.tc_hasta.Controls.Add(this.tp_reçete);
            this.tc_hasta.Dock = System.Windows.Forms.DockStyle.Top;
            this.tc_hasta.Font = new System.Drawing.Font("Verdana", 9F);
            this.tc_hasta.Location = new System.Drawing.Point(0, 92);
            this.tc_hasta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tc_hasta.Multiline = true;
            this.tc_hasta.Name = "tc_hasta";
            this.tc_hasta.SelectedIndex = 0;
            this.tc_hasta.Size = new System.Drawing.Size(550, 315);
            this.tc_hasta.TabIndex = 43;
            // 
            // tp_bilgiler
            // 
            this.tp_bilgiler.BackColor = System.Drawing.Color.White;
            this.tp_bilgiler.Controls.Add(this.rtb_bilgilerHasta);
            this.tp_bilgiler.Location = new System.Drawing.Point(4, 34);
            this.tp_bilgiler.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tp_bilgiler.Name = "tp_bilgiler";
            this.tp_bilgiler.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tp_bilgiler.Size = new System.Drawing.Size(542, 277);
            this.tp_bilgiler.TabIndex = 0;
            this.tp_bilgiler.Text = "Bilgiler";
            // 
            // rtb_bilgilerHasta
            // 
            this.rtb_bilgilerHasta.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.rtb_bilgilerHasta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtb_bilgilerHasta.Location = new System.Drawing.Point(18, 27);
            this.rtb_bilgilerHasta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rtb_bilgilerHasta.Name = "rtb_bilgilerHasta";
            this.rtb_bilgilerHasta.ReadOnly = true;
            this.rtb_bilgilerHasta.Size = new System.Drawing.Size(495, 224);
            this.rtb_bilgilerHasta.TabIndex = 0;
            this.rtb_bilgilerHasta.Text = "";
            // 
            // tp_randevu
            // 
            this.tp_randevu.BackColor = System.Drawing.Color.White;
            this.tp_randevu.Controls.Add(this.dgv_randevuHasta);
            this.tp_randevu.Controls.Add(this.label2);
            this.tp_randevu.Location = new System.Drawing.Point(4, 34);
            this.tp_randevu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tp_randevu.Name = "tp_randevu";
            this.tp_randevu.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tp_randevu.Size = new System.Drawing.Size(542, 277);
            this.tp_randevu.TabIndex = 1;
            this.tp_randevu.Text = "Randevu";
            // 
            // dgv_randevuHasta
            // 
            this.dgv_randevuHasta.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgv_randevuHasta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_randevuHasta.Location = new System.Drawing.Point(9, 29);
            this.dgv_randevuHasta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgv_randevuHasta.Name = "dgv_randevuHasta";
            this.dgv_randevuHasta.Size = new System.Drawing.Size(524, 238);
            this.dgv_randevuHasta.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 5);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Randevu Geçmişi:";
            // 
            // tp_reçete
            // 
            this.tp_reçete.BackColor = System.Drawing.Color.White;
            this.tp_reçete.Controls.Add(this.rtb_recete);
            this.tp_reçete.Controls.Add(this.cmb_receteHasta);
            this.tp_reçete.Controls.Add(this.label1);
            this.tp_reçete.Location = new System.Drawing.Point(4, 34);
            this.tp_reçete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tp_reçete.Name = "tp_reçete";
            this.tp_reçete.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tp_reçete.Size = new System.Drawing.Size(542, 277);
            this.tp_reçete.TabIndex = 2;
            this.tp_reçete.Text = "Reçete";
            // 
            // cmb_receteHasta
            // 
            this.cmb_receteHasta.FormattingEnabled = true;
            this.cmb_receteHasta.Location = new System.Drawing.Point(9, 29);
            this.cmb_receteHasta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmb_receteHasta.Name = "cmb_receteHasta";
            this.cmb_receteHasta.Size = new System.Drawing.Size(514, 30);
            this.cmb_receteHasta.TabIndex = 5;
            this.cmb_receteHasta.SelectionChangeCommitted += new System.EventHandler(this.cmb_receteHasta_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Reçete Geçmişi:";
            // 
            // btn_randevuAl
            // 
            this.btn_randevuAl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_randevuAl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_randevuAl.FlatAppearance.BorderSize = 0;
            this.btn_randevuAl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_randevuAl.Font = new System.Drawing.Font("Verdana", 12F);
            this.btn_randevuAl.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btn_randevuAl.Location = new System.Drawing.Point(0, 425);
            this.btn_randevuAl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_randevuAl.Name = "btn_randevuAl";
            this.btn_randevuAl.Size = new System.Drawing.Size(550, 55);
            this.btn_randevuAl.TabIndex = 47;
            this.btn_randevuAl.Text = "Randevu Al";
            this.btn_randevuAl.UseVisualStyleBackColor = false;
            this.btn_randevuAl.Click += new System.EventHandler(this.btn_randevuAl_Click);
            // 
            // btn_profilSil
            // 
            this.btn_profilSil.BackColor = System.Drawing.Color.MistyRose;
            this.btn_profilSil.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_profilSil.FlatAppearance.BorderSize = 0;
            this.btn_profilSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_profilSil.Font = new System.Drawing.Font("Verdana", 12F);
            this.btn_profilSil.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btn_profilSil.Location = new System.Drawing.Point(0, 480);
            this.btn_profilSil.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_profilSil.Name = "btn_profilSil";
            this.btn_profilSil.Size = new System.Drawing.Size(550, 55);
            this.btn_profilSil.TabIndex = 46;
            this.btn_profilSil.Text = "Profil Sil";
            this.btn_profilSil.UseVisualStyleBackColor = false;
            this.btn_profilSil.Click += new System.EventHandler(this.btn_profilSil_Click);
            // 
            // btn_sifreDegistir
            // 
            this.btn_sifreDegistir.BackColor = System.Drawing.Color.LightCyan;
            this.btn_sifreDegistir.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_sifreDegistir.FlatAppearance.BorderSize = 0;
            this.btn_sifreDegistir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sifreDegistir.Font = new System.Drawing.Font("Verdana", 12F);
            this.btn_sifreDegistir.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btn_sifreDegistir.Location = new System.Drawing.Point(0, 535);
            this.btn_sifreDegistir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_sifreDegistir.Name = "btn_sifreDegistir";
            this.btn_sifreDegistir.Size = new System.Drawing.Size(550, 55);
            this.btn_sifreDegistir.TabIndex = 45;
            this.btn_sifreDegistir.Text = "Şifre Değiştir";
            this.btn_sifreDegistir.UseVisualStyleBackColor = false;
            this.btn_sifreDegistir.Click += new System.EventHandler(this.btn_sifreDegistir_Click);
            // 
            // btn_uyeOturumuKapat
            // 
            this.btn_uyeOturumuKapat.BackColor = System.Drawing.Color.MistyRose;
            this.btn_uyeOturumuKapat.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_uyeOturumuKapat.FlatAppearance.BorderSize = 0;
            this.btn_uyeOturumuKapat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_uyeOturumuKapat.Font = new System.Drawing.Font("Verdana", 12F);
            this.btn_uyeOturumuKapat.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btn_uyeOturumuKapat.Location = new System.Drawing.Point(0, 590);
            this.btn_uyeOturumuKapat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_uyeOturumuKapat.Name = "btn_uyeOturumuKapat";
            this.btn_uyeOturumuKapat.Size = new System.Drawing.Size(550, 55);
            this.btn_uyeOturumuKapat.TabIndex = 44;
            this.btn_uyeOturumuKapat.Text = "Oturumu Kapat";
            this.btn_uyeOturumuKapat.UseVisualStyleBackColor = false;
            this.btn_uyeOturumuKapat.Click += new System.EventHandler(this.btn_uyeOturumuKapat_Click);
            // 
            // btn_titleProfil
            // 
            this.btn_titleProfil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_titleProfil.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_titleProfil.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btn_titleProfil.FlatAppearance.BorderSize = 0;
            this.btn_titleProfil.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btn_titleProfil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btn_titleProfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_titleProfil.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_titleProfil.ForeColor = System.Drawing.Color.White;
            this.btn_titleProfil.Location = new System.Drawing.Point(0, 0);
            this.btn_titleProfil.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_titleProfil.Name = "btn_titleProfil";
            this.btn_titleProfil.Size = new System.Drawing.Size(550, 92);
            this.btn_titleProfil.TabIndex = 42;
            this.btn_titleProfil.Text = "PROFİL";
            this.btn_titleProfil.UseVisualStyleBackColor = false;
            // 
            // btn_menuProfil
            // 
            this.btn_menuProfil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_menuProfil.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_menuProfil.FlatAppearance.BorderSize = 0;
            this.btn_menuProfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_menuProfil.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_menuProfil.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btn_menuProfil.Location = new System.Drawing.Point(0, 645);
            this.btn_menuProfil.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_menuProfil.Name = "btn_menuProfil";
            this.btn_menuProfil.Size = new System.Drawing.Size(550, 55);
            this.btn_menuProfil.TabIndex = 41;
            this.btn_menuProfil.Text = "Menü";
            this.btn_menuProfil.UseVisualStyleBackColor = false;
            this.btn_menuProfil.Click += new System.EventHandler(this.btn_menuProfil_Click);
            // 
            // rtb_recete
            // 
            this.rtb_recete.Location = new System.Drawing.Point(9, 78);
            this.rtb_recete.Name = "rtb_recete";
            this.rtb_recete.Size = new System.Drawing.Size(514, 169);
            this.rtb_recete.TabIndex = 6;
            this.rtb_recete.Text = "";
            // 
            // Form_Profil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(550, 700);
            this.Controls.Add(this.tc_hasta);
            this.Controls.Add(this.btn_randevuAl);
            this.Controls.Add(this.btn_profilSil);
            this.Controls.Add(this.btn_sifreDegistir);
            this.Controls.Add(this.btn_uyeOturumuKapat);
            this.Controls.Add(this.btn_titleProfil);
            this.Controls.Add(this.btn_menuProfil);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form_Profil";
            this.Text = "Form_Profil";
            this.Load += new System.EventHandler(this.Form_Profil_Load);
            this.tc_hasta.ResumeLayout(false);
            this.tp_bilgiler.ResumeLayout(false);
            this.tp_randevu.ResumeLayout(false);
            this.tp_randevu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_randevuHasta)).EndInit();
            this.tp_reçete.ResumeLayout(false);
            this.tp_reçete.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tc_hasta;
        private System.Windows.Forms.TabPage tp_bilgiler;
        private System.Windows.Forms.RichTextBox rtb_bilgilerHasta;
        private System.Windows.Forms.TabPage tp_randevu;
        private System.Windows.Forms.DataGridView dgv_randevuHasta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tp_reçete;
        private System.Windows.Forms.ComboBox cmb_receteHasta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_randevuAl;
        private System.Windows.Forms.Button btn_profilSil;
        private System.Windows.Forms.Button btn_sifreDegistir;
        private System.Windows.Forms.Button btn_uyeOturumuKapat;
        private System.Windows.Forms.Button btn_titleProfil;
        private System.Windows.Forms.Button btn_menuProfil;
        private System.Windows.Forms.RichTextBox rtb_recete;
    }
}
namespace Quiz10_20160627_MHRS
{
    partial class Form_ReceteYaz
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbx_hastaTc = new System.Windows.Forms.TextBox();
            this.btn_receteOlustur = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_ilacEkle = new System.Windows.Forms.Button();
            this.cmb_ilac = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_profileGit = new System.Windows.Forms.Button();
            this.btn_titleReceteYaz = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tbx_hastaTc);
            this.panel1.Controls.Add(this.btn_receteOlustur);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_ilacEkle);
            this.panel1.Controls.Add(this.cmb_ilac);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(67, 161);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(412, 336);
            this.panel1.TabIndex = 34;
            // 
            // tbx_hastaTc
            // 
            this.tbx_hastaTc.Location = new System.Drawing.Point(9, 50);
            this.tbx_hastaTc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbx_hastaTc.Name = "tbx_hastaTc";
            this.tbx_hastaTc.Size = new System.Drawing.Size(399, 26);
            this.tbx_hastaTc.TabIndex = 17;
            // 
            // btn_receteOlustur
            // 
            this.btn_receteOlustur.Font = new System.Drawing.Font("Verdana", 10F);
            this.btn_receteOlustur.Location = new System.Drawing.Point(9, 276);
            this.btn_receteOlustur.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_receteOlustur.Name = "btn_receteOlustur";
            this.btn_receteOlustur.Size = new System.Drawing.Size(399, 55);
            this.btn_receteOlustur.TabIndex = 34;
            this.btn_receteOlustur.Text = "Reçete Oluştur";
            this.btn_receteOlustur.UseVisualStyleBackColor = true;
            this.btn_receteOlustur.Click += new System.EventHandler(this.btn_receteOlustur_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 10F);
            this.label1.Location = new System.Drawing.Point(4, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 25);
            this.label1.TabIndex = 16;
            this.label1.Text = "Hasta TC Kimlik No:";
            // 
            // btn_ilacEkle
            // 
            this.btn_ilacEkle.Font = new System.Drawing.Font("Verdana", 10F);
            this.btn_ilacEkle.Location = new System.Drawing.Point(9, 211);
            this.btn_ilacEkle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_ilacEkle.Name = "btn_ilacEkle";
            this.btn_ilacEkle.Size = new System.Drawing.Size(399, 55);
            this.btn_ilacEkle.TabIndex = 15;
            this.btn_ilacEkle.Text = "İlaç Ekle";
            this.btn_ilacEkle.UseVisualStyleBackColor = true;
            this.btn_ilacEkle.Click += new System.EventHandler(this.btn_ilacEkle_Click);
            // 
            // cmb_ilac
            // 
            this.cmb_ilac.FormattingEnabled = true;
            this.cmb_ilac.Location = new System.Drawing.Point(9, 142);
            this.cmb_ilac.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmb_ilac.Name = "cmb_ilac";
            this.cmb_ilac.Size = new System.Drawing.Size(399, 28);
            this.cmb_ilac.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 10F);
            this.label4.Location = new System.Drawing.Point(4, 112);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "İlaç Seçin:";
            // 
            // btn_profileGit
            // 
            this.btn_profileGit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_profileGit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_profileGit.FlatAppearance.BorderSize = 0;
            this.btn_profileGit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_profileGit.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_profileGit.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btn_profileGit.Location = new System.Drawing.Point(0, 638);
            this.btn_profileGit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_profileGit.Name = "btn_profileGit";
            this.btn_profileGit.Size = new System.Drawing.Size(550, 62);
            this.btn_profileGit.TabIndex = 36;
            this.btn_profileGit.Text = "Profil Sayfama Dön";
            this.btn_profileGit.UseVisualStyleBackColor = false;
            this.btn_profileGit.Click += new System.EventHandler(this.btn_profileGit_Click);
            // 
            // btn_titleReceteYaz
            // 
            this.btn_titleReceteYaz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_titleReceteYaz.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_titleReceteYaz.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btn_titleReceteYaz.FlatAppearance.BorderSize = 0;
            this.btn_titleReceteYaz.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btn_titleReceteYaz.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btn_titleReceteYaz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_titleReceteYaz.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_titleReceteYaz.ForeColor = System.Drawing.Color.White;
            this.btn_titleReceteYaz.Location = new System.Drawing.Point(0, 0);
            this.btn_titleReceteYaz.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_titleReceteYaz.Name = "btn_titleReceteYaz";
            this.btn_titleReceteYaz.Size = new System.Drawing.Size(550, 92);
            this.btn_titleReceteYaz.TabIndex = 35;
            this.btn_titleReceteYaz.Text = "REÇETE YAZ";
            this.btn_titleReceteYaz.UseVisualStyleBackColor = false;
            // 
            // Form_ReceteYaz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(550, 700);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_profileGit);
            this.Controls.Add(this.btn_titleReceteYaz);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form_ReceteYaz";
            this.Text = "Form_ReceteYaz";
            this.Load += new System.EventHandler(this.Form_ReceteYaz_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbx_hastaTc;
        private System.Windows.Forms.Button btn_receteOlustur;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_ilacEkle;
        private System.Windows.Forms.ComboBox cmb_ilac;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_profileGit;
        private System.Windows.Forms.Button btn_titleReceteYaz;
    }
}
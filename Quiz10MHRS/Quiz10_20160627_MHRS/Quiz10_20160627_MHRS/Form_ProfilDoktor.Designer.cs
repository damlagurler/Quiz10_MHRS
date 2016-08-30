namespace Quiz10_20160627_MHRS
{
    partial class Form_ProfilDoktor
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
            this.btn_receteYaz = new System.Windows.Forms.Button();
            this.btn_izinAl = new System.Windows.Forms.Button();
            this.btn_sifreDegistir = new System.Windows.Forms.Button();
            this.btn_doktorOturumuKapat = new System.Windows.Forms.Button();
            this.rtb_bilgilerDoktor = new System.Windows.Forms.RichTextBox();
            this.btn_titleProfil = new System.Windows.Forms.Button();
            this.btn_menuProfil = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_receteYaz
            // 
            this.btn_receteYaz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_receteYaz.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_receteYaz.FlatAppearance.BorderSize = 0;
            this.btn_receteYaz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_receteYaz.Font = new System.Drawing.Font("Verdana", 12F);
            this.btn_receteYaz.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btn_receteYaz.Location = new System.Drawing.Point(0, 400);
            this.btn_receteYaz.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_receteYaz.Name = "btn_receteYaz";
            this.btn_receteYaz.Size = new System.Drawing.Size(550, 60);
            this.btn_receteYaz.TabIndex = 48;
            this.btn_receteYaz.Text = "Reçete Yaz";
            this.btn_receteYaz.UseVisualStyleBackColor = false;
            this.btn_receteYaz.Click += new System.EventHandler(this.btn_receteYaz_Click);
            // 
            // btn_izinAl
            // 
            this.btn_izinAl.BackColor = System.Drawing.Color.MistyRose;
            this.btn_izinAl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_izinAl.FlatAppearance.BorderSize = 0;
            this.btn_izinAl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_izinAl.Font = new System.Drawing.Font("Verdana", 12F);
            this.btn_izinAl.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btn_izinAl.Location = new System.Drawing.Point(0, 460);
            this.btn_izinAl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_izinAl.Name = "btn_izinAl";
            this.btn_izinAl.Size = new System.Drawing.Size(550, 60);
            this.btn_izinAl.TabIndex = 47;
            this.btn_izinAl.Text = "İzin Al";
            this.btn_izinAl.UseVisualStyleBackColor = false;
            this.btn_izinAl.Click += new System.EventHandler(this.btn_izinAl_Click);
            // 
            // btn_sifreDegistir
            // 
            this.btn_sifreDegistir.BackColor = System.Drawing.Color.LightCyan;
            this.btn_sifreDegistir.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_sifreDegistir.FlatAppearance.BorderSize = 0;
            this.btn_sifreDegistir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sifreDegistir.Font = new System.Drawing.Font("Verdana", 12F);
            this.btn_sifreDegistir.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btn_sifreDegistir.Location = new System.Drawing.Point(0, 520);
            this.btn_sifreDegistir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_sifreDegistir.Name = "btn_sifreDegistir";
            this.btn_sifreDegistir.Size = new System.Drawing.Size(550, 60);
            this.btn_sifreDegistir.TabIndex = 46;
            this.btn_sifreDegistir.Text = "Şifre Değiştir";
            this.btn_sifreDegistir.UseVisualStyleBackColor = false;
            this.btn_sifreDegistir.Click += new System.EventHandler(this.btn_sifreDegistir_Click);
            // 
            // btn_doktorOturumuKapat
            // 
            this.btn_doktorOturumuKapat.BackColor = System.Drawing.Color.MistyRose;
            this.btn_doktorOturumuKapat.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_doktorOturumuKapat.FlatAppearance.BorderSize = 0;
            this.btn_doktorOturumuKapat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_doktorOturumuKapat.Font = new System.Drawing.Font("Verdana", 12F);
            this.btn_doktorOturumuKapat.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btn_doktorOturumuKapat.Location = new System.Drawing.Point(0, 580);
            this.btn_doktorOturumuKapat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_doktorOturumuKapat.Name = "btn_doktorOturumuKapat";
            this.btn_doktorOturumuKapat.Size = new System.Drawing.Size(550, 60);
            this.btn_doktorOturumuKapat.TabIndex = 45;
            this.btn_doktorOturumuKapat.Text = "Oturumu Kapat";
            this.btn_doktorOturumuKapat.UseVisualStyleBackColor = false;
            this.btn_doktorOturumuKapat.Click += new System.EventHandler(this.btn_doktorOturumuKapat_Click);
            // 
            // rtb_bilgilerDoktor
            // 
            this.rtb_bilgilerDoktor.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.rtb_bilgilerDoktor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtb_bilgilerDoktor.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rtb_bilgilerDoktor.Location = new System.Drawing.Point(20, 125);
            this.rtb_bilgilerDoktor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rtb_bilgilerDoktor.Name = "rtb_bilgilerDoktor";
            this.rtb_bilgilerDoktor.ReadOnly = true;
            this.rtb_bilgilerDoktor.Size = new System.Drawing.Size(505, 240);
            this.rtb_bilgilerDoktor.TabIndex = 44;
            this.rtb_bilgilerDoktor.Text = "";
            
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
            this.btn_titleProfil.TabIndex = 43;
            this.btn_titleProfil.Text = "PROFİL DOKTOR";
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
            this.btn_menuProfil.Location = new System.Drawing.Point(0, 640);
            this.btn_menuProfil.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_menuProfil.Name = "btn_menuProfil";
            this.btn_menuProfil.Size = new System.Drawing.Size(550, 60);
            this.btn_menuProfil.TabIndex = 42;
            this.btn_menuProfil.Text = "Menü";
            this.btn_menuProfil.UseVisualStyleBackColor = false;
            this.btn_menuProfil.Click += new System.EventHandler(this.btn_menuProfil_Click);
            // 
            // Form_ProfilDoktor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(550, 700);
            this.Controls.Add(this.btn_receteYaz);
            this.Controls.Add(this.btn_izinAl);
            this.Controls.Add(this.btn_sifreDegistir);
            this.Controls.Add(this.btn_doktorOturumuKapat);
            this.Controls.Add(this.rtb_bilgilerDoktor);
            this.Controls.Add(this.btn_titleProfil);
            this.Controls.Add(this.btn_menuProfil);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form_ProfilDoktor";
            this.Text = "Form_ProfilDoktor";
            this.Load += new System.EventHandler(this.Form_ProfilDoktor_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_receteYaz;
        private System.Windows.Forms.Button btn_izinAl;
        private System.Windows.Forms.Button btn_sifreDegistir;
        private System.Windows.Forms.Button btn_doktorOturumuKapat;
        private System.Windows.Forms.RichTextBox rtb_bilgilerDoktor;
        private System.Windows.Forms.Button btn_titleProfil;
        private System.Windows.Forms.Button btn_menuProfil;
    }
}
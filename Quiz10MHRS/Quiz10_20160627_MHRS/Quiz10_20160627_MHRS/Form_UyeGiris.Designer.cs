namespace Quiz10_20160627_MHRS
{
    partial class Form_UyeGiris
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
            this.lbl_kaydol = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_uyeGiris = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tbx_sifreGiris = new System.Windows.Forms.TextBox();
            this.tbx_tcGiris = new System.Windows.Forms.TextBox();
            this.btn_menuUyeGiris = new System.Windows.Forms.Button();
            this.btn_titleUyeGiris = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_kaydol
            // 
            this.lbl_kaydol.AutoSize = true;
            this.lbl_kaydol.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_kaydol.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbl_kaydol.Location = new System.Drawing.Point(144, 309);
            this.lbl_kaydol.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_kaydol.Name = "lbl_kaydol";
            this.lbl_kaydol.Size = new System.Drawing.Size(56, 20);
            this.lbl_kaydol.TabIndex = 12;
            this.lbl_kaydol.Text = "Kaydol";
            this.lbl_kaydol.Click += new System.EventHandler(this.lbl_kaydol_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbl_kaydol);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btn_uyeGiris);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.tbx_sifreGiris);
            this.panel1.Controls.Add(this.tbx_tcGiris);
            this.panel1.Location = new System.Drawing.Point(100, 187);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(345, 329);
            this.panel1.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 9F);
            this.label4.Location = new System.Drawing.Point(4, 27);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 22);
            this.label4.TabIndex = 8;
            this.label4.Text = "TC Kimlik No:";
            // 
            // btn_uyeGiris
            // 
            this.btn_uyeGiris.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_uyeGiris.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_uyeGiris.Location = new System.Drawing.Point(4, 243);
            this.btn_uyeGiris.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_uyeGiris.Name = "btn_uyeGiris";
            this.btn_uyeGiris.Size = new System.Drawing.Size(336, 62);
            this.btn_uyeGiris.TabIndex = 13;
            this.btn_uyeGiris.Text = "Giriş Yap";
            this.btn_uyeGiris.UseVisualStyleBackColor = false;
            this.btn_uyeGiris.Click += new System.EventHandler(this.btn_uyeGiris_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(4, 124);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 22);
            this.label5.TabIndex = 9;
            this.label5.Text = "Şifre:";
            // 
            // tbx_sifreGiris
            // 
            this.tbx_sifreGiris.Location = new System.Drawing.Point(4, 151);
            this.tbx_sifreGiris.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbx_sifreGiris.Name = "tbx_sifreGiris";
            this.tbx_sifreGiris.PasswordChar = '*';
            this.tbx_sifreGiris.Size = new System.Drawing.Size(334, 26);
            this.tbx_sifreGiris.TabIndex = 11;
            // 
            // tbx_tcGiris
            // 
            this.tbx_tcGiris.Location = new System.Drawing.Point(4, 58);
            this.tbx_tcGiris.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbx_tcGiris.Name = "tbx_tcGiris";
            this.tbx_tcGiris.Size = new System.Drawing.Size(334, 26);
            this.tbx_tcGiris.TabIndex = 10;
            // 
            // btn_menuUyeGiris
            // 
            this.btn_menuUyeGiris.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_menuUyeGiris.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_menuUyeGiris.FlatAppearance.BorderSize = 0;
            this.btn_menuUyeGiris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_menuUyeGiris.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_menuUyeGiris.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btn_menuUyeGiris.Location = new System.Drawing.Point(0, 638);
            this.btn_menuUyeGiris.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_menuUyeGiris.Name = "btn_menuUyeGiris";
            this.btn_menuUyeGiris.Size = new System.Drawing.Size(550, 62);
            this.btn_menuUyeGiris.TabIndex = 29;
            this.btn_menuUyeGiris.Text = "Menü";
            this.btn_menuUyeGiris.UseVisualStyleBackColor = false;
            this.btn_menuUyeGiris.Click += new System.EventHandler(this.btn_menuUye_Click);
            // 
            // btn_titleUyeGiris
            // 
            this.btn_titleUyeGiris.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_titleUyeGiris.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_titleUyeGiris.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btn_titleUyeGiris.FlatAppearance.BorderSize = 0;
            this.btn_titleUyeGiris.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btn_titleUyeGiris.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btn_titleUyeGiris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_titleUyeGiris.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_titleUyeGiris.ForeColor = System.Drawing.Color.White;
            this.btn_titleUyeGiris.Location = new System.Drawing.Point(0, 0);
            this.btn_titleUyeGiris.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_titleUyeGiris.Name = "btn_titleUyeGiris";
            this.btn_titleUyeGiris.Size = new System.Drawing.Size(550, 92);
            this.btn_titleUyeGiris.TabIndex = 28;
            this.btn_titleUyeGiris.Text = "ÜYE GİRİŞİ";
            this.btn_titleUyeGiris.UseVisualStyleBackColor = false;
            // 
            // Form_UyeGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(550, 700);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_menuUyeGiris);
            this.Controls.Add(this.btn_titleUyeGiris);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form_UyeGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form_Randevu";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }



        #endregion

        private System.Windows.Forms.Label lbl_kaydol;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_uyeGiris;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbx_sifreGiris;
        private System.Windows.Forms.TextBox tbx_tcGiris;
        private System.Windows.Forms.Button btn_menuUyeGiris;
        private System.Windows.Forms.Button btn_titleUyeGiris;
    }
}
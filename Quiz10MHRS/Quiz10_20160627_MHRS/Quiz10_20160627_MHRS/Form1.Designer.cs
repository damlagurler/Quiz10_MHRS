namespace Quiz10_20160627_MHRS
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_cikis = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btn_personelListele = new System.Windows.Forms.Button();
            this.btn_uyeGiris = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_cikis
            // 
            this.btn_cikis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_cikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cikis.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_cikis.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btn_cikis.Location = new System.Drawing.Point(0, 620);
            this.btn_cikis.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.btn_cikis.Name = "btn_cikis";
            this.btn_cikis.Size = new System.Drawing.Size(550, 80);
            this.btn_cikis.TabIndex = 8;
            this.btn_cikis.Text = "Çıkış";
            this.btn_cikis.UseVisualStyleBackColor = false;
            this.btn_cikis.Click += new System.EventHandler(this.btn_cikis_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Verdana", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(0, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(550, 220);
            this.button3.TabIndex = 7;
            this.button3.Text = "MHRS";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // btn_personelListele
            // 
            this.btn_personelListele.BackColor = System.Drawing.Color.White;
            this.btn_personelListele.FlatAppearance.BorderSize = 0;
            this.btn_personelListele.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_personelListele.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_personelListele.Location = new System.Drawing.Point(0, 420);
            this.btn_personelListele.Name = "btn_personelListele";
            this.btn_personelListele.Size = new System.Drawing.Size(550, 200);
            this.btn_personelListele.TabIndex = 6;
            this.btn_personelListele.Text = "PERSONEL LİSTELE";
            this.btn_personelListele.UseVisualStyleBackColor = false;
            this.btn_personelListele.Click += new System.EventHandler(this.btn_personelListele_Click);
            // 
            // btn_uyeGiris
            // 
            this.btn_uyeGiris.BackColor = System.Drawing.Color.White;
            this.btn_uyeGiris.FlatAppearance.BorderSize = 0;
            this.btn_uyeGiris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_uyeGiris.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_uyeGiris.Location = new System.Drawing.Point(0, 220);
            this.btn_uyeGiris.Name = "btn_uyeGiris";
            this.btn_uyeGiris.Size = new System.Drawing.Size(550, 200);
            this.btn_uyeGiris.TabIndex = 5;
            this.btn_uyeGiris.Text = "ÜYE GİRİŞİ";
            this.btn_uyeGiris.UseVisualStyleBackColor = false;
            this.btn_uyeGiris.Click += new System.EventHandler(this.btn_uyeGiris_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(550, 700);
            this.Controls.Add(this.btn_cikis);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btn_personelListele);
            this.Controls.Add(this.btn_uyeGiris);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_cikis;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btn_personelListele;
        private System.Windows.Forms.Button btn_uyeGiris;
    }
}


namespace Quiz10_20160627_MHRS
{
    partial class Form_RandevuAl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_RandevuAl));
            this.dtp_randevu = new System.Windows.Forms.DateTimePicker();
            this.cmb_doktorRandevuAl = new System.Windows.Forms.ComboBox();
            this.cmb_bolumRandevuAl = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_saat = new System.Windows.Forms.Label();
            this.cmb_saat = new System.Windows.Forms.ComboBox();
            this.btn_randevuAl = new System.Windows.Forms.Button();
            this.btn_profilRandevuAl = new System.Windows.Forms.Button();
            this.btn_menuRandevuAl = new System.Windows.Forms.Button();
            this.btn_titleRandevuAl = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtp_randevu
            // 
            this.dtp_randevu.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtp_randevu.Location = new System.Drawing.Point(8, 244);
            this.dtp_randevu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtp_randevu.Name = "dtp_randevu";
            this.dtp_randevu.Size = new System.Drawing.Size(319, 27);
            this.dtp_randevu.TabIndex = 26;
            // 
            // cmb_doktorRandevuAl
            // 
            this.cmb_doktorRandevuAl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_doktorRandevuAl.FormattingEnabled = true;
            this.cmb_doktorRandevuAl.Location = new System.Drawing.Point(8, 138);
            this.cmb_doktorRandevuAl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmb_doktorRandevuAl.Name = "cmb_doktorRandevuAl";
            this.cmb_doktorRandevuAl.Size = new System.Drawing.Size(319, 28);
            this.cmb_doktorRandevuAl.TabIndex = 25;
            // 
            // cmb_bolumRandevuAl
            // 
            this.cmb_bolumRandevuAl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_bolumRandevuAl.FormattingEnabled = true;
            this.cmb_bolumRandevuAl.Location = new System.Drawing.Point(8, 54);
            this.cmb_bolumRandevuAl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmb_bolumRandevuAl.Name = "cmb_bolumRandevuAl";
            this.cmb_bolumRandevuAl.Size = new System.Drawing.Size(319, 28);
            this.cmb_bolumRandevuAl.TabIndex = 24;
            this.cmb_bolumRandevuAl.SelectedIndexChanged += new System.EventHandler(this.cmb_bolumRandevuAl_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(4, 203);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 22);
            this.label3.TabIndex = 23;
            this.label3.Text = "Tarih seçin:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(4, 100);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 22);
            this.label2.TabIndex = 22;
            this.label2.Text = "Doktor seçin:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9F);
            this.label1.Location = new System.Drawing.Point(4, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 22);
            this.label1.TabIndex = 21;
            this.label1.Text = "Bölüm seçin:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbl_saat);
            this.panel1.Controls.Add(this.cmb_saat);
            this.panel1.Controls.Add(this.dtp_randevu);
            this.panel1.Controls.Add(this.cmb_doktorRandevuAl);
            this.panel1.Controls.Add(this.cmb_bolumRandevuAl);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(55, 135);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(344, 396);
            this.panel1.TabIndex = 38;
            // 
            // lbl_saat
            // 
            this.lbl_saat.AutoSize = true;
            this.lbl_saat.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_saat.Location = new System.Drawing.Point(4, 309);
            this.lbl_saat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_saat.Name = "lbl_saat";
            this.lbl_saat.Size = new System.Drawing.Size(110, 22);
            this.lbl_saat.TabIndex = 29;
            this.lbl_saat.Text = "Saat seçin:";
            // 
            // cmb_saat
            // 
            this.cmb_saat.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmb_saat.FormattingEnabled = true;
            this.cmb_saat.Items.AddRange(new object[] {
            "08:00",
            "08:30",
            "09:00",
            "09:30",
            "10:00",
            "10:30",
            "11:00",
            "11:30",
            "12:00",
            "13:00",
            "13:30",
            "14:00",
            "14:30",
            "15:00",
            "15:30",
            "16:00",
            "16:30",
            "17:00"});
            this.cmb_saat.Location = new System.Drawing.Point(116, 309);
            this.cmb_saat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmb_saat.Name = "cmb_saat";
            this.cmb_saat.Size = new System.Drawing.Size(211, 30);
            this.cmb_saat.TabIndex = 28;
            // 
            // btn_randevuAl
            // 
            this.btn_randevuAl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_randevuAl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_randevuAl.FlatAppearance.BorderSize = 0;
            this.btn_randevuAl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_randevuAl.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_randevuAl.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btn_randevuAl.Location = new System.Drawing.Point(0, 576);
            this.btn_randevuAl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_randevuAl.Name = "btn_randevuAl";
            this.btn_randevuAl.Size = new System.Drawing.Size(550, 62);
            this.btn_randevuAl.TabIndex = 41;
            this.btn_randevuAl.Text = "Randevu Al";
            this.btn_randevuAl.UseVisualStyleBackColor = false;
            this.btn_randevuAl.Click += new System.EventHandler(this.btn_randevuAl_Click);
            // 
            // btn_profilRandevuAl
            // 
            this.btn_profilRandevuAl.Image = ((System.Drawing.Image)(resources.GetObject("btn_profilRandevuAl.Image")));
            this.btn_profilRandevuAl.Location = new System.Drawing.Point(436, 135);
            this.btn_profilRandevuAl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_profilRandevuAl.Name = "btn_profilRandevuAl";
            this.btn_profilRandevuAl.Size = new System.Drawing.Size(90, 92);
            this.btn_profilRandevuAl.TabIndex = 40;
            this.btn_profilRandevuAl.UseVisualStyleBackColor = true;
            // 
            // btn_menuRandevuAl
            // 
            this.btn_menuRandevuAl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_menuRandevuAl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_menuRandevuAl.FlatAppearance.BorderSize = 0;
            this.btn_menuRandevuAl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_menuRandevuAl.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_menuRandevuAl.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btn_menuRandevuAl.Location = new System.Drawing.Point(0, 638);
            this.btn_menuRandevuAl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_menuRandevuAl.Name = "btn_menuRandevuAl";
            this.btn_menuRandevuAl.Size = new System.Drawing.Size(550, 62);
            this.btn_menuRandevuAl.TabIndex = 39;
            this.btn_menuRandevuAl.Text = "Menü";
            this.btn_menuRandevuAl.UseVisualStyleBackColor = false;
            this.btn_menuRandevuAl.Click += new System.EventHandler(this.btn_menuRandevu_Click);
            // 
            // btn_titleRandevuAl
            // 
            this.btn_titleRandevuAl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_titleRandevuAl.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_titleRandevuAl.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btn_titleRandevuAl.FlatAppearance.BorderSize = 0;
            this.btn_titleRandevuAl.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btn_titleRandevuAl.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btn_titleRandevuAl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_titleRandevuAl.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_titleRandevuAl.ForeColor = System.Drawing.Color.White;
            this.btn_titleRandevuAl.Location = new System.Drawing.Point(0, 0);
            this.btn_titleRandevuAl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_titleRandevuAl.Name = "btn_titleRandevuAl";
            this.btn_titleRandevuAl.Size = new System.Drawing.Size(550, 92);
            this.btn_titleRandevuAl.TabIndex = 37;
            this.btn_titleRandevuAl.Text = "RANDEVU AL";
            this.btn_titleRandevuAl.UseVisualStyleBackColor = false;
            // 
            // Form_RandevuAl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(550, 700);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_randevuAl);
            this.Controls.Add(this.btn_profilRandevuAl);
            this.Controls.Add(this.btn_menuRandevuAl);
            this.Controls.Add(this.btn_titleRandevuAl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form_RandevuAl";
            this.Text = "Form_RandevuAl";
            this.Load += new System.EventHandler(this.Form_RandevuAl_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtp_randevu;
        private System.Windows.Forms.ComboBox cmb_doktorRandevuAl;
        private System.Windows.Forms.ComboBox cmb_bolumRandevuAl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_saat;
        private System.Windows.Forms.ComboBox cmb_saat;
        private System.Windows.Forms.Button btn_randevuAl;
        private System.Windows.Forms.Button btn_profilRandevuAl;
        private System.Windows.Forms.Button btn_menuRandevuAl;
        private System.Windows.Forms.Button btn_titleRandevuAl;
    }
}
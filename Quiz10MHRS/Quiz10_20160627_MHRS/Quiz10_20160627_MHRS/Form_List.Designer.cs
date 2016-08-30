namespace Quiz10_20160627_MHRS
{
    partial class Form_List
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
            this.btn_guncelle = new System.Windows.Forms.Button();
            this.cmb_departman = new System.Windows.Forms.ComboBox();
            this.btn_menuPerList = new System.Windows.Forms.Button();
            this.btn_titlePerList = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_personel = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_personel)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_guncelle
            // 
            this.btn_guncelle.BackColor = System.Drawing.Color.MistyRose;
            this.btn_guncelle.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_guncelle.FlatAppearance.BorderSize = 0;
            this.btn_guncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_guncelle.Font = new System.Drawing.Font("Verdana", 12F);
            this.btn_guncelle.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btn_guncelle.Location = new System.Drawing.Point(0, 583);
            this.btn_guncelle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_guncelle.Name = "btn_guncelle";
            this.btn_guncelle.Size = new System.Drawing.Size(550, 55);
            this.btn_guncelle.TabIndex = 36;
            this.btn_guncelle.Text = "Güncelle";
            this.btn_guncelle.UseVisualStyleBackColor = false;
            this.btn_guncelle.Visible = false;
            this.btn_guncelle.Click += new System.EventHandler(this.btn_guncelle_Click);
            // 
            // cmb_departman
            // 
            this.cmb_departman.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_departman.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmb_departman.FormattingEnabled = true;
            this.cmb_departman.Location = new System.Drawing.Point(26, 151);
            this.cmb_departman.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmb_departman.Name = "cmb_departman";
            this.cmb_departman.Size = new System.Drawing.Size(487, 30);
            this.cmb_departman.TabIndex = 35;
            this.cmb_departman.SelectedIndexChanged += new System.EventHandler(this.cmb_departman_SelectedIndexChanged);
            // 
            // btn_menuPerList
            // 
            this.btn_menuPerList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_menuPerList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_menuPerList.FlatAppearance.BorderSize = 0;
            this.btn_menuPerList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_menuPerList.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_menuPerList.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btn_menuPerList.Location = new System.Drawing.Point(0, 638);
            this.btn_menuPerList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_menuPerList.Name = "btn_menuPerList";
            this.btn_menuPerList.Size = new System.Drawing.Size(550, 62);
            this.btn_menuPerList.TabIndex = 34;
            this.btn_menuPerList.Text = "Menü";
            this.btn_menuPerList.UseVisualStyleBackColor = false;
            this.btn_menuPerList.Click += new System.EventHandler(this.btn_menuPerList_Click);
            // 
            // btn_titlePerList
            // 
            this.btn_titlePerList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_titlePerList.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_titlePerList.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btn_titlePerList.FlatAppearance.BorderSize = 0;
            this.btn_titlePerList.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btn_titlePerList.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btn_titlePerList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_titlePerList.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_titlePerList.ForeColor = System.Drawing.Color.White;
            this.btn_titlePerList.Location = new System.Drawing.Point(0, 0);
            this.btn_titlePerList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_titlePerList.Name = "btn_titlePerList";
            this.btn_titlePerList.Size = new System.Drawing.Size(550, 92);
            this.btn_titlePerList.TabIndex = 33;
            this.btn_titlePerList.Text = "PERSONEL LİSTELE";
            this.btn_titlePerList.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(22, 114);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(403, 22);
            this.label1.TabIndex = 32;
            this.label1.Text = "Görüntülemek istediğiniz departmanı seçin:";
            // 
            // dgv_personel
            // 
            this.dgv_personel.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgv_personel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_personel.Location = new System.Drawing.Point(26, 210);
            this.dgv_personel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgv_personel.Name = "dgv_personel";
            this.dgv_personel.Size = new System.Drawing.Size(489, 328);
            this.dgv_personel.TabIndex = 31;
            // 
            // Form_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(550, 700);
            this.Controls.Add(this.btn_guncelle);
            this.Controls.Add(this.cmb_departman);
            this.Controls.Add(this.btn_menuPerList);
            this.Controls.Add(this.btn_titlePerList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_personel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form_List";
            this.Text = "Form_List";
            this.Load += new System.EventHandler(this.Form_List_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_personel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_guncelle;
        private System.Windows.Forms.ComboBox cmb_departman;
        private System.Windows.Forms.Button btn_menuPerList;
        private System.Windows.Forms.Button btn_titlePerList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_personel;
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz10_20160627_MHRS
{
    public partial class Form_Veri : Form
    {
        public Form_Veri()
        {
            InitializeComponent();
        }
        Form form1;

        #region dragging
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        private void btn_titleVeriGiris_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void btn_titleVeriGiris_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void btn_titleVeriGiris_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
        #endregion

        private void btn_menuVeri_Click(object sender, EventArgs e)
        {
            form1 = new Form1();
            form1.Show();
            this.Close();
            form1.Location = this.Location;
        }
        static DataTable dt = new DataTable();

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Properties.Settings.Default.MHRSConDamla);
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Personel", con);
            da.Fill(dt);
            string a = "";
            foreach (DataRow item in dt.Rows)
            {
                a += item[1].ToString() + item[2].ToString() + item[3].ToString() + item[4].ToString() + item[5].ToString() + "\n";
            }
            MessageBox.Show(a);
            SqlCommandBuilder cb = new SqlCommandBuilder(da);
            cb.GetInsertCommand();
            DataRow dr = dt.NewRow();
            dr[1] = tbx_tcPersonel.Text;
            dr[2] = tbx_personelAd.Text;
            dr[3] = tbx_personelSoyad.Text;
            dr[4] = dtp_dogumTarihiPersonel.Value;
            dr[5] = cmb_cinsiyetPersonel.Text == "Kadın" ? false : true;
            dr[6] = tbx_personelAd.Text + "123";
            dr[7] = cmb_departmanVeri.SelectedValue;
            dr[8] = cmb_bolumYaDaDoktor.SelectedValue;
            dr[9] = new byte[5] { 1, 0, 1, 0, 1 };
            dr[10] = "FotoYolu";
            dr[11] = false;
            dr[12] = DateTime.Now;
            dt.Rows.Add(dr);
            da.Update(dt);
            //string komut = da.InsertCommand.CommandText.ToString();
            //MessageBox.Show(komut);
        }

        private void cmb_departmanVeri_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_departmanVeri.SelectedIndex == 0)
            {
                cmb_bolumYaDaDoktor.Visible = true;
                lbl_personelBilgi.Visible = true;
            }
            else
            {
                cmb_bolumYaDaDoktor.Visible = false;
                lbl_personelBilgi.Visible = false;
            }
        }

        private void Form_Veri_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Properties.Settings.Default.MHRSConDamla);

            SqlDataAdapter da = new SqlDataAdapter("SELECT PersonelTipId, Ad FROM PersonelTip WHERE Ad<>'Admin'", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmb_departmanVeri.DataSource = dt;
            cmb_departmanVeri.DisplayMember = "Ad";
            cmb_departmanVeri.ValueMember = "PersonelTipId";

            SqlDataAdapter da2 = new SqlDataAdapter("SELECT * FROM Bolum", con);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            cmb_bolumYaDaDoktor.DataSource = dt2;
            cmb_bolumYaDaDoktor.DisplayMember = "BolumAd";
            cmb_bolumYaDaDoktor.ValueMember = "BolumId";

            SqlDataAdapter daAdminOturum = new SqlDataAdapter("select * from Personel where Tc=@pTc", con);
            daAdminOturum.SelectCommand.Parameters.AddWithValue("pTc", Form_UyeGiris.TcGiris);
            DataTable dtAdminOturum = new DataTable();
            daAdminOturum.Fill(dtAdminOturum);

            SqlCommandBuilder cb = new SqlCommandBuilder(daAdminOturum);
            cb.GetUpdateCommand();
            dtAdminOturum.Rows[0][11] = true;
            daAdminOturum.Update(dtAdminOturum);
        }

        private void btn_adminOturumuKapat_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Properties.Settings.Default.MHRSConDamla);
            SqlDataAdapter daAdminOturum = new SqlDataAdapter("select * from Personel where Tc=@pTc", con);
            daAdminOturum.SelectCommand.Parameters.AddWithValue("pTc", Form_UyeGiris.TcGiris);
            DataTable dtAdminOturum = new DataTable();
            daAdminOturum.Fill(dtAdminOturum);

            SqlCommandBuilder cb = new SqlCommandBuilder(daAdminOturum);
            cb.GetUpdateCommand();
            dtAdminOturum.Rows[0][11] = false;
            daAdminOturum.Update(dtAdminOturum);

            Form_UyeGiris.TcGiris = null;
            Form_UyeGiris.adminMod = false;
            form1 = new Form1();
            form1.Show();
            this.Close();
            form1.Location = this.Location;

        }
    }
}

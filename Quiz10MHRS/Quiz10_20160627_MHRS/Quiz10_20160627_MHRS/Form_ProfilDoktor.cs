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
    public partial class Form_ProfilDoktor : Form
    {
        public Form_ProfilDoktor()
        {
            InitializeComponent();
        }
        #region dragging
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        private void btn_titleProfil_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void btn_titleProfil_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void btn_titleProfil_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
        #endregion

        Form form_1;
        Form f_receteYaz;
        Form f_izinAl;
        Form f_profilDuzenle;

        private void Form_ProfilDoktor_Load(object sender, EventArgs e)
        {
           
            SqlConnection con = new SqlConnection(Properties.Settings.Default.MHRSConDamla);
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Personel WHERE Tc=@pTc", con);
            da.SelectCommand.Parameters.AddWithValue("pTc", Form_UyeGiris.TcGiris);
            DataTable dt = new DataTable();
            da.Fill(dt);
            string cinsiyet = dt.Rows[0][5].ToString() == "False" ? "Kadın" : "Erkek";
            rtb_bilgilerDoktor.Text =
                "TC: " + dt.Rows[0][1].ToString() + "\n" +
                "Ad: " + dt.Rows[0][2].ToString() + "\n" +
                "Soyad: " + dt.Rows[0][3].ToString() + "\n" +
                "Doğum Tarihi: " + dt.Rows[0][4].ToString() + "\n" +
                "Cinsiyet: " + cinsiyet + "\n" +
                "Kayıt Tarihi: " + dt.Rows[0][10].ToString();
            btn_titleProfil.Text = "Hoşgeldiniz! " + dt.Rows[0][2].ToString().ToUpper() + " " + dt.Rows[0][3].ToString().ToUpper();
            SqlCommandBuilder cb = new SqlCommandBuilder(da);
            cb.GetUpdateCommand();
            dt.Rows[0][11] = true;
            da.Update(dt);
        }

        private void btn_menuProfil_Click(object sender, EventArgs e)
        {
            form_1 = new Form1();
            form_1.Show();
            form_1.Location = Location;
            Hide();

            try
            {
                f_profilDuzenle.Close();
            }
            catch (Exception)
            {

            }
        }

        private void btn_izinAl_Click(object sender, EventArgs e)
        {
            f_izinAl = new Form_IzinAl();
            f_izinAl.Show();
            f_izinAl.Location = Location;
            Hide();
        }

        private void btn_receteYaz_Click(object sender, EventArgs e)
        {
            f_receteYaz = new Form_ReceteYaz();
            f_receteYaz.Show();
            f_receteYaz.Location = Location;
            Hide();
        }

        private void btn_doktorOturumuKapat_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Properties.Settings.Default.MHRSConDamla);
            SqlDataAdapter da = new SqlDataAdapter("SELECT PersonelId,Tc,IsOturumAcik FROM Personel WHERE Tc=@pTc", con);
            da.SelectCommand.Parameters.AddWithValue("pTc", Form_UyeGiris.TcGiris);
            DataTable dt = new DataTable();
            da.Fill(dt);
            SqlCommandBuilder cb = new SqlCommandBuilder(da);
            cb.GetUpdateCommand();
            dt.Rows[0][2] = false;
            da.Update(dt);


            Form_UyeGiris.TcGiris = null;
            Form form1 = new Form1();
            form1.Show();
            this.Close();
            form1.Location = this.Location;
        }

        private void btn_sifreDegistir_Click(object sender, EventArgs e)
        {
            f_profilDuzenle = new Form_ProfilDuzenle();
            f_profilDuzenle.Show();
        }

    
    }
}

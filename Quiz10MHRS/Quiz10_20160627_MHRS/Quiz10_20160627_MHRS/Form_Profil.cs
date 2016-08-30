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
    public partial class Form_Profil : Form
    {
        public Form_Profil()
        {
            InitializeComponent();
        }

        Form f_randevuAl;
        Form f_profilDuzenle;
        SqlConnection con = new SqlConnection(Properties.Settings.Default.MHRSConDamla);

        private void btn_menuProfil_Click(object sender, EventArgs e)
        {
            Form form1 = new Form1();
            form1.Show();
            this.Close();
            form1.Location = this.Location;
            try
            {
                f_profilDuzenle.Close();
            }
            catch (Exception)
            {

            }
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

       
        private void Form_Profil_Load(object sender, EventArgs e)
        {
           
            
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Hasta WHERE Tc=@pTc", con);
            da.SelectCommand.Parameters.AddWithValue("pTc", Form_UyeGiris.TcGiris);
            DataTable dt = new DataTable();
            da.Fill(dt);

            string cinsiyet = dt.Rows[0][5].ToString() == "False" ? "Kadın" : "Erkek";
            rtb_bilgilerHasta.Text =
                "TC: " + dt.Rows[0][1].ToString() + "\n" +
                "Ad: " + dt.Rows[0][2].ToString() + "\n" +
                "Soyad: " + dt.Rows[0][3].ToString() + "\n" +
                "Doğum Tarihi: " + dt.Rows[0][4].ToString() + "\n" +
                "Cinsiyet: " + cinsiyet + "\n" +
                "Kayıt Tarihi: " + dt.Rows[0][10].ToString();
            btn_titleProfil.Text = "Hoşgeldiniz! " + dt.Rows[0][2].ToString().ToUpper() + " " + dt.Rows[0][3].ToString().ToUpper();
            SqlCommandBuilder cb = new SqlCommandBuilder(da);
            cb.GetUpdateCommand();
            dt.Rows[0][9] = true;
            da.Update(dt);

            SqlDataAdapter da2 = new SqlDataAdapter(
                "SELECT r.RandevuSaati AS [Randevu Saati], CONCAT(p.Ad, ' ', p.Soyad) AS Doktor, b.BolumAd AS [Bölüm] " +
                "FROM Randevu r JOIN Personel p on p.PersonelId=r.PersonelId " +
                "JOIN Bolum b on b.BolumId=p.BolumId " +
                "JOIN Hasta h on h.HastaId=r.HastaId " +
                "WHERE h.Tc=@pTc", con);
            da2.SelectCommand.Parameters.AddWithValue("pTc", Form_UyeGiris.TcGiris);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            dgv_randevuHasta.DataSource = dt2;


            SqlDataAdapter daReceteTarih = new SqlDataAdapter(
                "SELECT r.CreateDate, r.ReceteId FROM recete r join Hasta h on h.HastaId=r.HastaId WHERE Tc=@pTc", con);
            daReceteTarih.SelectCommand.Parameters.AddWithValue("pTc", Form_UyeGiris.TcGiris);
            DataTable dtReceteTarih = new DataTable();
            daReceteTarih.Fill(dtReceteTarih);
            cmb_receteHasta.DataSource = dtReceteTarih;
            cmb_receteHasta.DisplayMember = "CreateDate";
            cmb_receteHasta.ValueMember = "r.CreateDate";
            cmb_receteHasta.BindingContext = new BindingContext();
        }
        private void btn_randevuAl_Click(object sender, EventArgs e)
        {
            f_randevuAl = new Form_RandevuAl();
            f_randevuAl.Show();
            f_randevuAl.Location = this.Location;
            Hide();
        }
 

        private void btn_uyeOturumuKapat_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Properties.Settings.Default.MHRSConDamla);
            SqlDataAdapter da = new SqlDataAdapter("SELECT HastaId,Tc,IsOturumAcik FROM Hasta WHERE Tc=@pTc", con);
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

        private void btn_profilSil_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Properties.Settings.Default.MHRSConDamla);
            SqlDataAdapter da = new SqlDataAdapter("select * from Hasta where Tc=@pTc", con);
            da.SelectCommand.Parameters.AddWithValue("pTc", Form_UyeGiris.TcGiris);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dt.Rows[0][11] = true;
            dt.Rows[0][9] = false;
            SqlCommandBuilder cb = new SqlCommandBuilder(da);
            cb.GetUpdateCommand();
            da.Update(dt);
            MessageBox.Show("Kaydınız başarıyla silindi");

            Form_UyeGiris.TcGiris = null;
            Form form1 = new Form1();
            form1.Show();
            this.Close();
            form1.Location = this.Location;


        }

        private void cmb_receteHasta_SelectionChangeCommitted(object sender, EventArgs e)
        {

           // try
           //{
           //     SqlDataAdapter daReceteSonuc = new SqlDataAdapter(
           //        "SELECT i.Ad, p.Ad FROM Recete r " +
           //             "JOIN ReceteIlac re on re.ReceteId=r.ReceteId " +
           //             "JOIN Ilac i on i.IlacId=re.IlacId " +
           //             "JOIN Personel p on p.PersonelId=r.PersonelId " +
           //             "WHERE r.CreateDate=@pTarih", con);
           //     string trh = cmb_receteHasta.GetItemText(cmb_receteHasta.SelectedItem);
           //     //var trh = cmb_receteHasta.SelectedValue;
           //     StringBuilder sb = new StringBuilder(trh);
           //     sb.Replace(".", "-");
           //     trh = sb.ToString();


           //     //MessageBox.Show("2=>" + trh);]
           //     DataTable dtReceteSonuc = new DataTable();
           //     daReceteSonuc.SelectCommand.Parameters.AddWithValue("pTarih", trh);
           //     daReceteSonuc.Fill(dtReceteSonuc);
           //     rtb_recete.Text = "İlaç: " + dtReceteSonuc.Rows[0][0].ToString() + " Doktor: " + dtReceteSonuc.Rows[0][1].ToString();
           // }
           // catch (Exception ex)
           // {
           //     MessageBox.Show(ex.Message);
           // }

        }
    }
}

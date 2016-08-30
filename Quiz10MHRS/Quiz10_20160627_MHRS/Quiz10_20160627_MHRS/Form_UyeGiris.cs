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
    public partial class Form_UyeGiris : Form
    {
        public Form_UyeGiris()
        {
            InitializeComponent();
        }
        Form form1;
        Form f_uyeKayit;
        Form f_veri;
        Form f_profil;
        Form f_profilDoktor;

        private void btn_menuUye_Click(object sender, EventArgs e)
        {
            form1 = new Form1();
            form1.Show();
            this.Close();
            form1.Location = this.Location;
        }
        #region dragging
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        private void btn_titleUyeGiris_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void btn_titleUyeGiris_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void btn_titleUyeGiris_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
        #endregion

        private void lbl_kaydol_Click(object sender, EventArgs e)
        {
            f_uyeKayit = new Form_UyeKayit();
            f_uyeKayit.Show();
            this.Close();
            f_uyeKayit.Location = this.Location;
        }

        public static bool adminMod = false;
        public static string TcGiris = null;
        public static bool girisKontrol = false;


        private void btn_uyeGiris_Click(object sender, EventArgs e)
        {
            if (adminKontrol(tbx_tcGiris.Text, tbx_sifreGiris.Text)!=null)
            {
                TcGiris = tbx_tcGiris.Text;
                adminMod = true;
                f_veri = new Form_Veri();
                f_veri.Show();
                this.Close();
                f_veri.Location = this.Location;
            }

            else if (uyeKontrol(tbx_tcGiris.Text, tbx_sifreGiris.Text) != null)
            {
                TcGiris = tbx_tcGiris.Text;
                adminMod = false;
                f_profil = new Form_Profil();
                f_profil.Show();
                this.Close();
                f_profil.Location = this.Location;
            }
            else if (personelKontrol(tbx_tcGiris.Text, tbx_sifreGiris.Text) != null)
            {
                TcGiris = tbx_tcGiris.Text;
                adminMod = false;
                f_profilDoktor = new Form_ProfilDoktor();
                f_profilDoktor.Show();
                this.Close();
                f_profilDoktor.Location = this.Location;
            }
            else
            {
                girisKontrol = false;
                MessageBox.Show("Girdiğiniz TC kimlik numarası veya şifre yanlış.");
                tbx_tcGiris.Clear();
                tbx_sifreGiris.Clear();
            }

        }
        private string uyeKontrol(string Tc, string sifre)
        {
            SqlConnection con = new SqlConnection(Properties.Settings.Default.MHRSConDamla);
            SqlDataAdapter daHasta = new SqlDataAdapter("SELECT Tc, Sifre,IsDeleted FROM Hasta WHERE Tc=@pTc", con);
            daHasta.SelectCommand.Parameters.AddWithValue("pTc", Tc);
            DataTable dtHasta = new DataTable();
            daHasta.Fill(dtHasta);
            try
            {
                if (!(bool)(dtHasta.Rows[0][2]))
                {
                    if (dtHasta.Rows[0][0].ToString().TrimEnd().Equals(Tc))
                    {
                        girisKontrol = true;
                        if (dtHasta.Rows[0][1].ToString().Equals(sifre))
                        {
                            girisKontrol = true;
                            return Tc;
                        }
                        else
                        {
                            //MessageBox.Show("Şifre yanlış!\nTekrar Deneyin...");
                            girisKontrol = false;
                            return null;
                        }
                    }
                    else
                    {
                        //MessageBox.Show("Böyle bir kayıt yok!");
                        girisKontrol = false;
                        return null;
                    }
                }
                else
                {
                    girisKontrol = false;
                    return null;
                }
            }
            catch (Exception)
            {
                //MessageBox.Show("Böyle bir kayıt yok!");
                girisKontrol = false;
                return null;
            }
        }
        private string personelKontrol(string Tc, string sifre)
        {
            SqlConnection con = new SqlConnection(Properties.Settings.Default.MHRSConDamla);
            SqlDataAdapter daPersonel = new SqlDataAdapter("SELECT Tc, Sifre FROM Personel WHERE Tc=@pTc", con);
            daPersonel.SelectCommand.Parameters.AddWithValue("pTc", Tc);
            DataTable dtPersonel = new DataTable();
            daPersonel.Fill(dtPersonel);
            try
            {
                if (dtPersonel.Rows[0][0].ToString().TrimEnd().Equals(Tc))
                {
                    girisKontrol = true;
                    if (dtPersonel.Rows[0][1].ToString().Equals(sifre))
                    {
                        girisKontrol = true;
                        return Tc;
                    }
                    else
                    {
                        //MessageBox.Show("Şifre yanlış!\nTekrar Deneyin...");
                        girisKontrol = false;
                        return null;
                    }
                }
                else
                {
                    //MessageBox.Show("Böyle bir kayıt yok!");
                    girisKontrol = false;
                    return null;
                }
            }
            catch (Exception)
            {
                //MessageBox.Show("Böyle bir kayıt yok!");
                girisKontrol = false;
                return null;
            }
        }

        private string adminKontrol(string Tc, string sifre)
        {
            SqlConnection con = new SqlConnection(Properties.Settings.Default.MHRSConDamla);
            SqlDataAdapter daAdmin = new SqlDataAdapter("SELECT Tc, Sifre FROM Personel WHERE Tc=@pTc and PersonelTipId=1", con);
            daAdmin.SelectCommand.Parameters.AddWithValue("pTc", Tc);
            DataTable dtAdmin = new DataTable();
            daAdmin.Fill(dtAdmin);
            try
            {
                if (dtAdmin.Rows[0][0].ToString().TrimEnd().Equals(Tc))
                {
                    girisKontrol = true;
                    if (dtAdmin.Rows[0][1].ToString().Equals(sifre))
                    {
                        girisKontrol = true;
                        return Tc;
                    }
                    else
                    {
                        //MessageBox.Show("Şifre yanlış!\nTekrar Deneyin...");
                        girisKontrol = false;
                        return null;
                    }
                }
                else
                {
                    //MessageBox.Show("Böyle bir kayıt yok!");
                    girisKontrol = false;
                    return null;
                }
            }
            catch (Exception)
            {
                //MessageBox.Show("Böyle bir kayıt yok!");
                girisKontrol = false;
                return null;
            }
        }
    }
}

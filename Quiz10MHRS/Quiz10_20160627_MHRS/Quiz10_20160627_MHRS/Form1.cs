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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Form f_uyeGiris;
        Form f_randevu;
        Form f_list;
        Form f_veri;
        Form f_profilDoktor;
        Form f_profil;

        private void btn_veri_Click(object sender, EventArgs e)
        {
            Form form_veri = new Form_Veri();
            //form_veri.MdiParent = this;
            //form_veri.WindowState = FormWindowState.Maximized;
            form_veri.Show();
            //tableLayoutPanel1.Hide();
            form_veri.Size = this.Size;
            form_veri.Location = this.Location;
            this.Hide();
        }

        private void btn_list_Click(object sender, EventArgs e)
        {
            Form form_list = new Form_List();
            //form_list.MdiParent = this;
            //form_list.WindowState = FormWindowState.Maximized;
            form_list.Show();
            //tableLayoutPanel1.Hide();
            form_list.Size = this.Size;
            form_list.Location = this.Location;
            this.Hide();
        }

        private void btn_randevu_Click(object sender, EventArgs e)
        {
            Form form_randevu = new Form_UyeGiris();
            //form_randevu.MdiParent = this;
            //form_randevu.WindowState = FormWindowState.Maximized;
            form_randevu.Show();
            //tableLayoutPanel1.Hide();
            form_randevu.Size = this.Size;
            form_randevu.Location = this.Location;
            this.Hide();
        }

        private void btn_profil_Click(object sender, EventArgs e)
        {
            Form form_profil = new Form_Profil();
            //form_profil.MdiParent = this;
            //form_profil.WindowState = FormWindowState.Maximized;
            form_profil.Show();
            //tableLayoutPanel1.Hide();
            form_profil.Size = this.Size;
            form_profil.Location = this.Location;
            this.Hide();
        }

        private void btn_cikis_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Properties.Settings.Default.MHRSConDamla);
            try
            {
                SqlDataAdapter daHasta = new SqlDataAdapter("SELECT HastaId,Tc, IsOturumAcik FROM Hasta WHERE Tc=@pTc", con);
                daHasta.SelectCommand.Parameters.AddWithValue("pTc", Form_UyeGiris.TcGiris);
                DataTable dtHasta = new DataTable();
                daHasta.Fill(dtHasta);

                SqlCommandBuilder cb = new SqlCommandBuilder(daHasta);
                cb.GetUpdateCommand();
                dtHasta.Rows[0][2] = false;
                daHasta.Update(dtHasta);

            }
            catch (Exception)
            {
                try
                {
                    SqlDataAdapter daPersonel = new SqlDataAdapter("SELECT PersonelId,Tc, IsOturumAcik FROM Personel WHERE Tc=@pTc", con);
                    daPersonel.SelectCommand.Parameters.AddWithValue("pTc", Form_UyeGiris.TcGiris);
                    DataTable dtPersonel = new DataTable();
                    daPersonel.Fill(dtPersonel);

                    SqlCommandBuilder cb = new SqlCommandBuilder(daPersonel);
                    cb.GetUpdateCommand();
                    dtPersonel.Rows[0][2] = false;
                    daPersonel.Update(dtPersonel);
                }
                catch (Exception)
                {
                    this.Close();
                    //Environment.Exit(0);
                    Application.Exit();
                }
            }
            this.Close();
            //Environment.Exit(0);
            Application.Exit();
        }

        private void btn_uyeGiris_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(Properties.Settings.Default.MHRSConDamla);
                SqlDataAdapter daHasta = new SqlDataAdapter("SELECT Tc, IsOturumAcik FROM Hasta WHERE Tc=@pTc", con);
                daHasta.SelectCommand.Parameters.AddWithValue("pTc", Form_UyeGiris.TcGiris);
                DataTable dtHasta = new DataTable();
                daHasta.Fill(dtHasta);

                SqlDataAdapter daPersonel = new SqlDataAdapter("SELECT Tc, PersonelTipId, IsOturumAcik FROM Personel WHERE Tc=@pTc", con);
                daPersonel.SelectCommand.Parameters.AddWithValue("pTc", Form_UyeGiris.TcGiris);
                DataTable dtPersonel = new DataTable();
                daPersonel.Fill(dtPersonel);
                try
                {
                    if ((bool)dtPersonel.Rows[0][2])
                    {
                        if ((int)dtPersonel.Rows[0][1]==1)
                        {
                            f_veri = new Form_Veri();
                            f_veri.Show();
                            this.Close();
                            f_veri.Location = this.Location;

                        }
                        else
                        {
                            f_profilDoktor = new Form_ProfilDoktor();
                            f_profilDoktor.Show();
                            this.Close();
                            f_profilDoktor.Location = this.Location;
                        }
                    }
                }
                catch (Exception)
                {
                    if ((bool)dtHasta.Rows[0][1])
                    {
                        f_profil = new Form_Profil();
                        f_profil.Show();
                        this.Close();
                        f_profil.Location = this.Location;
                    }
                }
            }
            catch (Exception)
            {
                f_uyeGiris = new Form_UyeGiris();
                f_uyeGiris.Show();
                f_uyeGiris.Location = this.Location;
                this.Hide();
            }

        }

        #region None-styled window sürükleme (dragging)
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        private void btn_mhrs_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void btn_mhrs_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void btn_mhrs_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
        #endregion

        private void btn_randevuAl_Click(object sender, EventArgs e)
        {
            f_randevu = new Form_RandevuAl();
            f_randevu.Show();
            f_randevu.Location = Location;
            Hide();
        }

        private void btn_personelListele_Click(object sender, EventArgs e)
        {
            f_list = new Form_List();
            f_list.Show();
            f_list.Location = this.Location;
            this.Hide();
        }

     
    }
}

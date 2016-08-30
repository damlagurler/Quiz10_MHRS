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
    public partial class Form_ReceteYaz : Form
    {
        public Form_ReceteYaz()
        {
            InitializeComponent();
        }
        Form f_ProfilDoktor;

        private void Form_ReceteYaz_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Properties.Settings.Default.MHRSConDamla);

            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Ilac", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmb_ilac.DataSource = dt;
            cmb_ilac.ValueMember = "IlacId";
            cmb_ilac.DisplayMember = "Ad";
        }

        private void btn_profileGit_Click(object sender, EventArgs e)
        {
            f_ProfilDoktor = new Form_ProfilDoktor();
            f_ProfilDoktor.Show();
            f_ProfilDoktor.Location = Location;
            Hide();
        }
        static DateTime IdIcinTarih;
        private void btn_receteOlustur_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(Properties.Settings.Default.MHRSConDamla);

                SqlDataAdapter daHastaBul = new SqlDataAdapter("SELECT * FROM Hasta WHERE Tc=@pTcHasta", con);
                daHastaBul.SelectCommand.Parameters.AddWithValue("pTcHasta",tbx_hastaTc.Text);

                DataTable dtHastaBul = new DataTable();
                daHastaBul.Fill(dtHastaBul);
                var hastaId = dtHastaBul.Rows[0][0];

                SqlDataAdapter daDoktorBul = new SqlDataAdapter("SELECT * FROM Personel WHERE Tc=@pTcDoktor", con);
                daDoktorBul.SelectCommand.Parameters.AddWithValue("pTcDoktor", Form_UyeGiris.TcGiris);

                DataTable dtDoktorBul = new DataTable();
                daDoktorBul.Fill(dtDoktorBul);
                var doktorId = dtDoktorBul.Rows[0][0];

                SqlDataAdapter daReceteOlustur = new SqlDataAdapter("SELECT * FROM Recete", con);
                DataTable dtReceteOlustur = new DataTable();
                daReceteOlustur.Fill(dtReceteOlustur);
                DataRow dr = dtReceteOlustur.NewRow();
                dr[1] = hastaId;
                dr[2] = doktorId;
                dr[3] = DateTime.Now;
                IdIcinTarih = (DateTime)dr[3];
                SqlCommandBuilder cb = new SqlCommandBuilder(daReceteOlustur);
                cb.GetInsertCommand();
                dtReceteOlustur.Rows.Add(dr);
                daReceteOlustur.Update(dtReceteOlustur);
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen geçerli bir TC Kimlik No girin!");
            }

        }

        private void btn_ilacEkle_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(Properties.Settings.Default.MHRSConDamla);
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Recete WHERE CreateDate=@pDate", con);
                da.SelectCommand.Parameters.AddWithValue("pDate", IdIcinTarih);
                DataTable dt = new DataTable();
                da.Fill(dt);
                var receteId_ = dt.Rows[0][0];

                SqlDataAdapter daIlacEkle = new SqlDataAdapter("SELECT * FROM ReceteIlac", con);
                DataTable dtIlacEkle = new DataTable();
                daIlacEkle.Fill(dtIlacEkle);
                SqlCommandBuilder cb = new SqlCommandBuilder(daIlacEkle);
                cb.GetInsertCommand();
                DataRow dr = dtIlacEkle.NewRow();
                dr[1] = receteId_;
                dr[2] = Convert.ToInt32(cmb_ilac.SelectedValue);
                dtIlacEkle.Rows.Add(dr);
                daIlacEkle.Update(dtIlacEkle);

                MessageBox.Show("İlaç eklendi.");
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen öncelikle bir reçete oluşturun!");
            }
        }
    }
}

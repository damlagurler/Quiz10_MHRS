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
    public partial class Form_ProfilDuzenle : Form
    {
        public Form_ProfilDuzenle()
        {
            InitializeComponent();
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Properties.Settings.Default.MHRSConDamla);
            SqlDataAdapter daHasta = new SqlDataAdapter("select HastaId,Tc,Sifre from Hasta where Tc=@pTc", con);
            daHasta.SelectCommand.Parameters.AddWithValue("pTc", Form_UyeGiris.TcGiris);
            DataTable dtHasta = new DataTable();


            SqlDataAdapter daPersonel = new SqlDataAdapter("select PersonelId, Tc, Sifre from Personel where Tc=@pTc", con);
            daPersonel.SelectCommand.Parameters.AddWithValue("pTc", Form_UyeGiris.TcGiris);
            DataTable dtPersonel = new DataTable();
            daHasta.Fill(dtHasta);
            daPersonel.Fill(dtPersonel);


            if (tbx_yeniSifre.Text.Equals(tbx_yeniSifre2.Text))
            {
                try
                {
                    if (dtHasta.Rows != null)
                    {
                        dtHasta.Rows[0][2] = tbx_yeniSifre.Text;
                        SqlCommandBuilder cb = new SqlCommandBuilder(daHasta);
                        cb.GetUpdateCommand();
                        daHasta.Update(dtHasta);
                        MessageBox.Show("Şifre değiştirme başarılı");
                        Hide();
                    }
                }
                catch (Exception)
                {
                    dtPersonel.Rows[0][2] = tbx_yeniSifre.Text;
                    SqlCommandBuilder cb = new SqlCommandBuilder(daPersonel);
                    cb.GetUpdateCommand();
                    daPersonel.Update(dtPersonel);
                    MessageBox.Show("Şifre değiştirme başarılı");
                    Hide();

                }
               
            }
            else
            {
                MessageBox.Show("Şifreler uyuşmuyor, tekrar deneyin...");
                tbx_yeniSifre.Clear();
                tbx_yeniSifre2.Clear();

            }


        }

        private void btn_geri_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

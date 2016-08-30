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
    public partial class Form_UyeKayit : Form
    {
        public Form_UyeKayit()
        {
            InitializeComponent();
        }
        Form form1;
        Form f_profil;

        #region dragging
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        private void btn_titleUyeKayit_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void btn_titleUyeKayit_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void btn_titleUyeKayit_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
        #endregion

        private void btn_menuUyeKayit_Click(object sender, EventArgs e)
        {
            form1 = new Form1();
            form1.Show();
            this.Close();
            form1.Location = this.Location;
        }
        static bool kayitDevam;
        private void btn_kaydol_Click(object sender, EventArgs e)
        {
            if ((tbx_tcHastaKayit.TextLength != 11))
            {
                MessageBox.Show("TC Kimlik No 11 haneli olmalıdır!");
                return;
            }
            else if ((tbx_adHasta.TextLength == 0) ||
                (tbx_soyadHasta.TextLength == 0) ||
                (tbx_sifreHastaKayit.TextLength == 0))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun");
                return;
            }

            if (tbx_sifreHastaKayit.Text == tbx_sifre2Hasta.Text)
            {
                SqlConnection con = new SqlConnection(Properties.Settings.Default.MHRSConStrLENOVO);

                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Hasta", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                SqlCommandBuilder cb = new SqlCommandBuilder(da);
                cb.GetInsertCommand();

                DataRow dr = dt.NewRow();
                dr[1] = tbx_tcHastaKayit.Text;
                dr[2] = tbx_adHasta.Text;
                dr[3] = tbx_soyadHasta.Text;
                dr[4] = dtp_dogumTarihiHasta.Value;
                dr[5] = cmb_cinsiyetHasta.Text == "Kadın" ? false : true;
                dr[6] = tbx_sifreHastaKayit.Text;
                dr[7] = new byte[5] { 1, 0, 1, 0, 1 };
                dr[8] = "FotoYoluHasta";
                dr[9] = false;
                dr[10] = DateTime.Now;
                dt.Rows.Add(dr);

                if (HastaKayitGecerliMi(dr))
                {
                    da.Update(dt);
                    Form_UyeGiris.TcGiris = tbx_tcHastaKayit.Text;
                    MessageBox.Show("Kaydınız başarıyla yapıldı");
                    f_profil = new Form_Profil();
                    f_profil.Show();
                    f_profil.Location = Location;
                    Hide();
                }
            }
            else
            {
                MessageBox.Show("Şifreler uyuşmuyor.\nLütfen şifreyi kontrol edin.");
            }
        }

        private bool HastaKayitGecerliMi(DataRow yeniRow)
        {
            bool kayitDevam = false;
            SqlConnection con = new SqlConnection(Properties.Settings.Default.MHRSConStrLENOVO);
            SqlDataAdapter daTumKayitlar = new SqlDataAdapter(
                "SELECT Tc FROM Hasta UNION SELECT Tc FROM Personel ORDER BY Tc ASC", con);
            DataTable dtTumKayitlar = new DataTable();
            daTumKayitlar.Fill(dtTumKayitlar);

            foreach (DataRow row in dtTumKayitlar.Rows)
            {
                if (row[0].ToString().TrimEnd() == yeniRow[1].ToString())
                {
                    MessageBox.Show("Bu TC Kimlik No zaten kayıtlı");
                    kayitDevam = false;
                    break;
                }
                else
                {
                    kayitDevam = true;
                }
            }
            return kayitDevam;
        }
    }
}

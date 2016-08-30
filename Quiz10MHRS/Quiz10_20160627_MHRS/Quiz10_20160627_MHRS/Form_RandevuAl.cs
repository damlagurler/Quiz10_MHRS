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
    public partial class Form_RandevuAl : Form
    {
        public Form_RandevuAl()
        {
            InitializeComponent();
        }

        Form form1;
        Form f_RandevuOzet;

        private void btn_menuRandevu_Click(object sender, EventArgs e)
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
        private void btn_titleRandevu_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void btn_titleRandevu_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void btn_titleRandevu_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
        #endregion

        SqlConnection con = new SqlConnection(Properties.Settings.Default.MHRSConDamla);
        private void Form_RandevuAl_Load(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Bolum", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmb_bolumRandevuAl.DataSource = dt;
            cmb_bolumRandevuAl.DisplayMember = "BolumAd";
            cmb_bolumRandevuAl.ValueMember = "BolumId";
            dtp_randevu.MinDate = DateTime.Now;


            //dtp_randevu.Format = DateTimePickerFormat.Long;
        }

        private void cmb_bolumRandevuAl_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT PersonelId, CONCAT(Ad, ' ', Soyad) AS TamAd FROM Personel WHERE PersonelTipId=2 AND BolumId=@pBolumId", con);
                da.SelectCommand.Parameters.AddWithValue("pBolumId", cmb_bolumRandevuAl.SelectedValue);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cmb_doktorRandevuAl.DataSource = dt;
                cmb_doktorRandevuAl.DisplayMember = "TamAd";
                cmb_doktorRandevuAl.ValueMember = "PersonelId";
            }
            catch (Exception)
            {
            }
        }
        public static int sonRandevuId;
        public static string tarih;
        public static bool hastaMusait = false;
        public static bool doktorMusait = true;
        private void btn_randevuAl_Click(object sender, EventArgs e)
        {
            //bool kayitDevam = false;
            if ((dtp_randevu.Value.DayOfWeek == DayOfWeek.Saturday) || (dtp_randevu.Value.DayOfWeek == DayOfWeek.Sunday))
            {
                MessageBox.Show("Haftasonu için randevu verilmemektedir");
            }
            else
            {
                SqlConnection con = new SqlConnection(Properties.Settings.Default.MHRSConDamla);
                //Sadece giriş yapmış üyenin bilgilerini tutan tek satırlı bir tablo getirir
                SqlDataAdapter daIdBul = new SqlDataAdapter("SELECT HastaId FROM Hasta WHERE Tc=@pTc", con);
                daIdBul.SelectCommand.Parameters.AddWithValue("pTc", Form_UyeGiris.TcGiris);
                con.Open();
                int hastaId = (int)daIdBul.SelectCommand.ExecuteScalar();
                con.Close();

                //Hastanın silinmemiş tüm randevularını getirir
                SqlDataAdapter daRandevuHasta = new SqlDataAdapter(
                    "SELECT * FROM Randevu WHERE HastaId=@pHastaId AND IsDeleted=0", con);
                daRandevuHasta.SelectCommand.Parameters.AddWithValue("pHastaId", hastaId);
                DataTable dtRandevuHasta = new DataTable();
                daRandevuHasta.Fill(dtRandevuHasta);
                //Hastanın randevularına eklenecek yeni randevu için satır oluşturur
                DataRow dr = dtRandevuHasta.NewRow();
                dr[1] = hastaId;
                dr[2] = int.Parse(cmb_doktorRandevuAl.SelectedValue.ToString());
                dr[3] = dtp_randevu.Value.Year.ToString() + "-" +
                    dtp_randevu.Value.Month.ToString() + "-" +
                    dtp_randevu.Value.Day.ToString() + " " +
                    cmb_saat.SelectedItem.ToString();
                dr[4] = DateTime.Now;

                //Doktorun silinmemiş tüm randevularını getirir
                SqlDataAdapter daRandevuDoktor = new SqlDataAdapter(
                    "SELECT * FROM Randevu WHERE PersonelId=@pPersonelId AND IsDeleted=0", con);
                daRandevuDoktor.SelectCommand.Parameters.AddWithValue("pPersonelId", cmb_doktorRandevuAl.SelectedValue);
                DataTable dtRandevuDoktor = new DataTable();
                daRandevuDoktor.Fill(dtRandevuDoktor);
                SqlCommandBuilder cbDoktor = new SqlCommandBuilder(daRandevuDoktor);
                cbDoktor.GetInsertCommand();

                string dtpTarih = dtp_randevu.Value.Year.ToString() + "-" +
                    dtp_randevu.Value.Month.ToString() + "-" +
                    dtp_randevu.Value.Day.ToString();
                string dtpTarihSaat = dtp_randevu.Value.ToShortDateString() + " " + cmb_saat.Text;
                string rowTarih = "";
                string rowTarihSaat = "";

                //Hastanın o güne randevusu var mı
                if (dtRandevuHasta.Rows.Count != 0)
                {
                    foreach (DataRow row in dtRandevuHasta.Rows)
                    {
                        rowTarih = ((DateTime)row[3]).Year.ToString() + "-" +
                            ((DateTime)row[3]).Month.ToString() + "-" +
                            ((DateTime)row[3]).Day.ToString();

                        if (dtpTarih == rowTarih)
                        {
                            MessageBox.Show("Aynı güne birden fazla randevu alamazsınız");
                            hastaMusait = false;
                            break;
                        }
                        else
                        {
                            hastaMusait = true;
                        }
                    }
                }
                else
                {
                    hastaMusait = true;
                }
                //Doktorun o saatte boş randevusu var mı
                if (dtRandevuDoktor.Rows.Count != 0)
                {
                    foreach (DataRow row in dtRandevuDoktor.Rows)
                    {
                        rowTarihSaat = ((DateTime)row[3]).ToShortDateString() + " " + ((DateTime)row[3]).ToShortTimeString();

                        if (dtpTarihSaat == rowTarihSaat)
                        {
                            MessageBox.Show("İstediğiniz randevu daha önceden alındı");
                            doktorMusait = false;
                            break;
                        }
                        else
                        {
                            doktorMusait = true;
                        }
                    }
                }
                else
                {
                    doktorMusait = true;
                }

                if ((!RandevuIzinCakisiyorMu(dtp_randevu.Value)) && (hastaMusait) && (doktorMusait))
                {
                    dtRandevuHasta.Clear();
                    //Randevuyu veritabanına kaydetme ve özetinin verilebilmesi için id'sini bulma
                    SqlCommand com = new SqlCommand("sp_InsertRandevu", con);
                    com.CommandType = CommandType.StoredProcedure;
                    com.Parameters.AddWithValue("hastaId", hastaId);
                    com.Parameters.AddWithValue("personelId", int.Parse(cmb_doktorRandevuAl.SelectedValue.ToString()));
                    com.Parameters.AddWithValue(
                        "randevuSaati",
                        dtp_randevu.Value.Year.ToString() + "-" +
                        dtp_randevu.Value.Month.ToString() + "-" +
                        dtp_randevu.Value.Day.ToString() + " " +
                        cmb_saat.SelectedItem.ToString());
                    com.Parameters.AddWithValue("createDate", DateTime.Now);
                    com.Parameters.AddWithValue("isDeleted", 0);
                    SqlParameter pRandevuId = new SqlParameter();
                    pRandevuId.ParameterName = "@randevuId";
                    pRandevuId.DbType = DbType.Int32;
                    pRandevuId.Direction = ParameterDirection.Output;
                    com.Parameters.Add(pRandevuId);
                    con.Open();
                    com.ExecuteNonQuery();
                    con.Close();
                    sonRandevuId = Convert.ToInt32(com.Parameters["@randevuId"].Value);

                    MessageBox.Show("Belirttiğiniz tarih ve saatteki randevuya kaydınız yapıldı");

                    f_RandevuOzet = new Form_RandevuOzet();
                    f_RandevuOzet.Show();
                    f_RandevuOzet.Location = this.Location;
                    this.Hide();
                }
            }
        }
        private bool RandevuIzinCakisiyorMu(DateTime randevu)
        {
            bool randevuIzinCakisma = false;
            SqlDataAdapter daIzinler = new SqlDataAdapter(
                "SELECT BaslamaTarihi, BitisTarihi " +
                "FROM PersonelIzin WHERE PersonelId=@pPersonelId AND IsDeleted=0 " +
                "AND BitisTarihi>=@pRandevuTarihi", con);
            daIzinler.SelectCommand.Parameters.AddWithValue("pPersonelId", (int)cmb_doktorRandevuAl.SelectedValue);
            daIzinler.SelectCommand.Parameters.AddWithValue("pRandevuTarihi", randevu.Date);
            DataTable dtIzinler = new DataTable();
            daIzinler.Fill(dtIzinler);

            foreach (DataRow row in dtIzinler.Rows)
            {
                if (((DateTime)row[0]) <= randevu.Date)
                {
                    randevuIzinCakisma = true;
                    MessageBox.Show("Seçtiğiniz doktor randevu istediğiniz tarihte izinli" +
                        "\nİzin bitiş tarihi: " + ((DateTime)row[1]).ToShortDateString());
                    break;
                }
                else
                {
                    randevuIzinCakisma = false;
                }
            }
            return randevuIzinCakisma;
        }

        private void cmb_bolumRandevuAl_SelectionChangeCommitted(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter(
                "SELECT PersonelId, CONCAT(Ad, ' ', Soyad) AS TamAd FROM Personel " +
                "WHERE PersonelTipId=2 AND BolumId=@pBolumId", con);
            da.SelectCommand.Parameters.AddWithValue("pBolumId", cmb_bolumRandevuAl.SelectedValue);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmb_doktorRandevuAl.DataSource = dt;
            cmb_doktorRandevuAl.DisplayMember = "TamAd";
            cmb_doktorRandevuAl.ValueMember = "PersonelId";
        }
    }
}



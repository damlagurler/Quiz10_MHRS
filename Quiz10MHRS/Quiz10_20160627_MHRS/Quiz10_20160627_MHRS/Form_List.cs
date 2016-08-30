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
    public partial class Form_List : Form
    {
        public Form_List()
        {
            InitializeComponent();
        }
        Form form1;

        private void btn_menuPerList_Click(object sender, EventArgs e)
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

        private void btn_titlePerList_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void btn_titlePerList_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void btn_titlePerList_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
        #endregion



        private void Form_List_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Properties.Settings.Default.MHRSConDamla);
            SqlDataAdapter daPersonelTip = new SqlDataAdapter("SELECT PersonelTipId, Ad FROM PersonelTip WHERE PersonelTipId<>1", con);
            DataTable dtPersonelTip = new DataTable();
            daPersonelTip.Fill(dtPersonelTip);
            cmb_departman.DataSource = dtPersonelTip;
            cmb_departman.ValueMember = "PersonelTipId";
            cmb_departman.DisplayMember = "Ad";

            if (Form_UyeGiris.adminMod==true)
            {
                btn_guncelle.Visible = true;
            }
        }
        static SqlConnection con = new SqlConnection(Properties.Settings.Default.MHRSConDamla);
        static SqlDataAdapter daPer = new SqlDataAdapter(
            "SELECT CONCAT(p.Ad, p.Soyad) AS TamAd, p.DogumTarihi, p.Cinsiyet, b.BolumAd " +
            "FROM PersonelTip Pt " +
            "JOIN Personel p on p.PersonelTipId=pt.PersonelTipId " +
            "JOIN Bolum b on b.BolumId=p.BolumId " +
            "WHERE pt.PersonelTipId=@pId", con);

        private void cmb_departman_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                daPer.SelectCommand.Parameters.AddWithValue("pId", cmb_departman.SelectedValue);
                DataTable dtPersonel = new DataTable();
                daPer.Fill(dtPersonel);
                dgv_personel.DataSource = dtPersonel;
            }
            catch (Exception ex)
            {
                MessageBox.Show("IndexChanged Hatası:\n" + ex.Message);
            }
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            //YAPILACAK!!!
        }


        //static DataSet MHRSDataSet = new DataSet();        

        //static int ilk = 0;
    }
}
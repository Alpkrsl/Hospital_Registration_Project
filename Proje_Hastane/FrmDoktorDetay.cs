using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje_Hastane
{
    public partial class FrmDoktorDetay : Form
    {
        public FrmDoktorDetay()
        {
            InitializeComponent();
        }

        private void backgroundWorker3_DoWork(object sender, DoWorkEventArgs e)
        {

        }
        sqlbaglantısı sql = new sqlbaglantısı();


        public string taş,doktortc,doktoradsoyad,değişkennn;
        private void button2_Click(object sender, EventArgs e)
        {
            taş = label3.Text;
            doktortc=Lbltcno.Text;
            doktoradsoyad=lbladsoyad.Text;
            FrmDuyurular duyurular = new FrmDuyurular();
            duyurular.doktorr = taş;
            duyurular.doktortc= doktortc;
            duyurular.doktorad= doktoradsoyad;
            duyurular.Show();
            this.Close();
        }
        public string Tc;
        private void FrmDoktorDetay_Load(object sender, EventArgs e)
        {
        
            Lbltcno.Text= Tc;
            //InitializeComponent();
            veriyükle();
            veriyükle2();
            veriyükle3();

            listele();
        }

        private void veriyükle3()
        {
            if (değişkennn == "Değişş")
            {
                Lbltcno.Text = doktortc;
                lbladsoyad.Text = doktoradsoyad;
            }
        }

        private void listele()
        {
            SqlCommand liste = new SqlCommand("SELECT*FROM Tbl_Randevular",sql.baglanti());
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(liste); 
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;      
        }

        private void veriyükle2()
        {
            if (değişkenn=="Değiş") {
                Lbltcno.Text = tcd;
                lbladsoyad.Text = adoyadd;
            }
        }

        private void FrmDoktorBilgiDüzenle_Activated(object sender, EventArgs e)
        {
            // Form aktif olduğunda veri yüklenir
            veriyükle();
        }
        private void richtbRandevu_TextChanged(object sender, EventArgs e)
        {
          
        }
        public string tcd,adoyadd,değişkenn;
        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            FrmDoktorBilgiDüzenle fr =new FrmDoktorBilgiDüzenle();
            fr.tc = Lbltcno.Text;
            fr.Show();
            this.Hide();
        }
        private void Lbltcno_Click(object sender, EventArgs e)
        {
        }

        private void lbladsoyad_Click(object sender, EventArgs e)
        {

            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            //FrmDoktorBilgiDüzenle fr = new FrmDoktorBilgiDüzenle();
            //if (fr.ShowDialog() == DialogResult.OK)
            //{
            //    Lbltcno.Text = fr.tcc;
            //    lbladsoyad.Text = fr.ad + "" + fr.soyad;
            //}
        }
        private void veriyükle()
        {
            Lbltcno.Text = Tc;
            SqlCommand ad = new SqlCommand("SELECT Doktorad,Doktorsoyad FROM Tbl_Doktorlar WHERE DoktorTc=@P1", sql.baglanti());
            ad.Parameters.AddWithValue("@P1", Lbltcno.Text);
            SqlDataReader dr = ad.ExecuteReader();
            while (dr.Read())
            {
                lbladsoyad.Text = dr[0].ToString() + " " + dr[1].ToString();
            }
            sql.baglanti().Close();

            //Randevu Detay
            DataTable dt = new DataTable();
            SqlDataAdapter sdp = new SqlDataAdapter("SELECT*FROM Tbl_Randevular WHERE RandevuDoktor='" + lbladsoyad + "'", sql.baglanti());
            sdp.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.ReadOnly = true;
           int seçilen= dataGridView1.SelectedCells[0].RowIndex;
            richtbRandevu.Text = dataGridView1.Rows[seçilen].Cells[7].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmDoktorGiriş doktorGiriş = new FrmDoktorGiriş();
            doktorGiriş.Show();
            this.Close();
        }

        private void BtnÇıkış_Click(object sender, EventArgs e)
        {
            FrmDoktorGiriş doktorGiriş = new FrmDoktorGiriş();
            doktorGiriş.Show();
            this.Close();
        }
    }
}

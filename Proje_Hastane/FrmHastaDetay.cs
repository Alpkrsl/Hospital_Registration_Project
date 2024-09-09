using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Proje_Hastane
{
    public partial class FrmHastaDetay : Form
    {
        public FrmHastaDetay()
        {
            InitializeComponent();
        }
        public string tc;

        sqlbaglantısı sq = new sqlbaglantısı();
        private void FrmHastaDetay_Load(object sender, EventArgs e)
        {
            lbltc.Text= tc;
            VeriGöster();
            
            SqlCommand detay = new SqlCommand("SELECT Hastaad,Hastasoyad FROM Tbl_Hastalar Where HastaTc=@A1",sq.baglanti());
            detay.Parameters.AddWithValue("@A1",lbltc.Text);
            SqlDataReader dr=detay.ExecuteReader();
            while (dr.Read())
            {
                lbladsoyad.Text = dr[0]+" "+dr[1];
            }
            sq.baglanti().Close();

            // Randevu Geçmişi
            Listeleme2();
            Listeleme();


            //Branş Seçim
            SqlCommand branş = new SqlCommand("SELECT Branşad FROM Tbl_Branşlar", sq.baglanti());
            SqlDataReader dr2=branş.ExecuteReader();
            while (dr2.Read())
            {
                cmbbranş.Items.Add(dr2[0]);
            }

        }

        private void Listeleme2()
        {
            SqlCommand randevu = new SqlCommand("SELECT*FROM Tbl_Randevular_Yedek WHERE HastaTc=@p1", sq.baglanti());
            randevu.Parameters.AddWithValue("@p1", lbltc.Text);
            DataTable da = new DataTable();
            SqlDataAdapter daa = new SqlDataAdapter(randevu);
            daa.Fill(da);
            dataGridView1.DataSource = da;
        }

        private void VeriGöster()
        {
            if (değişken=="Değiş") {
                lbltc.Text = tcc;
                lbladsoyad.Text = adsoyad;
            }
        }

        //private void VeriGöster()
        //{
        //    lbltc.Text = tcc;
        //    lbladsoyad.Text = adsoyad;
        //}

        private void Listeleme()
        {
            SqlCommand randevu = new SqlCommand("SELECT*FROM Tbl_Randevular WHERE HastaTc=@p1", sq.baglanti());
            randevu.Parameters.AddWithValue("@p1", lbltc.Text);
            DataTable da = new DataTable();
            SqlDataAdapter daa = new SqlDataAdapter(randevu);
            daa.Fill(da);
            dataGridView2.DataSource = da;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            
                SqlCommand sqlCommand = new SqlCommand("SELECT*FROM Tbl_Randevular WHERE RandevuBranş=@p1 AND RandevuDoktor=@p2 AND HastaTC=@p3", sq.baglanti());
                sqlCommand.Parameters.AddWithValue("@p1", cmbbranş.Text);
                sqlCommand.Parameters.AddWithValue("@p2", cmbdoktor.Text);
                sqlCommand.Parameters.AddWithValue("@p3", txttc.Text);
                DataTable da = new DataTable();
                SqlDataAdapter daa = new SqlDataAdapter(sqlCommand);
                daa.Fill(da);
                dataGridView2.DataSource = da;
            
        }

        private void cmbbranş_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbdoktor.Items.Clear();
            cmbdoktor.Text = " ";
            SqlCommand det = new SqlCommand("SELECT Doktorad,Doktorsoyad FROM Tbl_Doktorlar where DoktorBranş=@P1",sq.baglanti());
            det.Parameters.AddWithValue("@P1",cmbbranş.Text);
            SqlDataReader dr3=det.ExecuteReader();
            while (dr3.Read()) {

                cmbdoktor.Items.Add(dr3[0] + " " + dr3[1]);
            }
            if (dr3.Read())
            {
                cmbdoktor.Items.Add(dr3[0] + " " + dr3[1]);
            }
            sq.baglanti().Close();
        }
        public string tcc, adsoyad,değişken;
        private void lblBilgileriniDüzenle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmBilgiDüzenle frmBilgiDüzenle=new FrmBilgiDüzenle();
            frmBilgiDüzenle.TcNoo = lbltc.Text;
            frmBilgiDüzenle.Show();
            this.Close();
        }
        
        private void btnrandevual_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txttc.Text)&& txttc.TextLength == 11  && txttc.Text==lbltc.Text &&
                    !string.IsNullOrEmpty(cmbbranş.Text) &&
                    !string.IsNullOrEmpty(cmbdoktor.Text) &&
                    !string.IsNullOrEmpty(rtbşikayet.Text))
                {
                    SqlCommand Şart = new SqlCommand("INSERT INTO Tbl_Randevular(HastaTc,RandevuBranş,RandevuDoktor,HastaŞikayet)VALUES(@R1,@R2,@R3,@R4)", sq.baglanti());
                    Şart.Parameters.AddWithValue("@R1", txttc.Text);
                    Şart.Parameters.AddWithValue("@R2", cmbbranş.Text);
                    Şart.Parameters.AddWithValue("@R3", cmbdoktor.Text);
                    Şart.Parameters.AddWithValue("@R4", rtbşikayet.Text);
                    DataTable dt = new DataTable();
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(Şart);
                    sqlDataAdapter.Fill(dt);
                    dataGridView2.DataSource = dt;
                    MessageBox.Show("Randevunuz Başarıyla eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Listeleme();
                }
            }
            catch(Exception ex) {
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sq.baglanti();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmHastaGiriş frmHastaGiriş = new FrmHastaGiriş();
            frmHastaGiriş.Show();
            this.Close();   
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.ReadOnly = true;
            dataGridView1.Enabled = true;
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView2.ReadOnly = true;
            dataGridView2.Enabled = true;
        }
    }
}

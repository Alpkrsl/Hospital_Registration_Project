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
    public partial class FrmDoktorBilgiDüzenle : Form
    {
        sqlbaglantısı sqll = new sqlbaglantısı();
        public FrmDoktorBilgiDüzenle()
        {
            InitializeComponent();
            FrmDoktorDetay frm = new FrmDoktorDetay();
        }

        private void Liste()
        {
            MskTc.Text = tc;
            if (MskTc.Text == tc)
            {
                SqlCommand sql = new SqlCommand("SELECT*FROM Tbl_Doktorlar WHERE DoktorTc=@p1", sqll.baglanti());
                sql.Parameters.AddWithValue("@P1", MskTc.Text);
                DataTable dt = new DataTable();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sql);
                sqlDataAdapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void BtnKayıt_Click(object sender, EventArgs e)
        {

           
            SqlCommand sql = new SqlCommand("UPDATE Tbl_Doktorlar SET Doktorad=@p1,Doktorsoyad=@p2,DoktorTc=@p3,DoktorŞifre=@p4,DoktorBranş=@p6 WHERE Doktorid=@p5",sqll.baglanti());
            try
            {
                if (!string.IsNullOrEmpty(Txtad.Text) && 
                    !string.IsNullOrEmpty(Txtsoyad.Text) &&
                    !string.IsNullOrEmpty(MskTc.Text) &&
                    !string.IsNullOrEmpty(txtsifre.Text) &&
                    !string.IsNullOrEmpty(txtid.Text) &&
                    !string.IsNullOrEmpty(TxtBranş.Text)) {
                    sql.Parameters.AddWithValue("@p1", Txtad.Text);
                    sql.Parameters.AddWithValue("@p2", Txtsoyad.Text);
                    sql.Parameters.AddWithValue("@p3", MskTc.Text);
                    sql.Parameters.AddWithValue("@p4", txtsifre.Text);
                    sql.Parameters.AddWithValue("@p5", txtid.Text);
                    sql.Parameters.AddWithValue("@p6", TxtBranş.Text);
                    sql.ExecuteNonQuery();
                    MessageBox.Show("Değerler güncellendi");
                }
            }
            catch (Exception )
            {
                MessageBox.Show("Yanlış değer girdiniz girdiğiniz değerleri kontrol ediniz");
            }
            finally
            {
                sqll.baglanti().Close();
                Liste();
            }
        }

        private void MskTc_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtid.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            Txtad.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            Txtsoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            MskTc.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            txtsifre.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            TxtBranş.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            dataGridView1.ReadOnly = true;
        }
        public string tc;
        private void FrmDoktorBilgiDüzenle_Load(object sender, EventArgs e)
        {

            Liste();
        }

        private void Txtad_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txtsoyad_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtBranş_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Liste();
        }
        public string tcc,adsoyad;
        private void button2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Txtad.Text) &&
                    !string.IsNullOrEmpty(Txtsoyad.Text) &&
                    !string.IsNullOrEmpty(MskTc.Text) &&
                    !string.IsNullOrEmpty(txtsifre.Text) &&
                    !string.IsNullOrEmpty(txtid.Text) &&
                    !string.IsNullOrEmpty(TxtBranş.Text))
            {
                tcc = MskTc.Text;
                adsoyad = Txtad.Text + " " + Txtsoyad.Text;
                FrmDoktorDetay frm = new FrmDoktorDetay();
                frm.tcd = tcc;
                frm.adoyadd = adsoyad;
                frm.değişkenn = label7.Text;
                frm.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Ad veya soyad veya tc boş lütfen bilgilerinizle doldurunuz");
            }
        }
    }
    }


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Proje_Hastane
{
    public partial class FrmRandevuListesi : Form
    {
        public FrmRandevuListesi()
        {
            InitializeComponent();
        }

        private void Listeleme()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter dr = new SqlDataAdapter("SELECT*FROM Tbl_Randevular", bağ.baglanti());
            dr.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        sqlbaglantısı bağ = new sqlbaglantısı();
        private void FrmRandevuListesi_Load(object sender, EventArgs e)
        {
            Listeleme();
        }
        public string tc, ad;
        private void button2_Click(object sender, EventArgs e)
        {
            lbltc.Text = tc;
            lbladsoyad.Text = ad;
            FrmSekreterDetay frm = new FrmSekreterDetay();
            frm.Tc=lbltc.Text;
            frm.addd = lbladsoyad.Text;
            frm.değişken = Değiş.Text;
            frm.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtıd.Text != null)
                {
                    SqlCommand sql = new SqlCommand("SELECT*FROM TBL_Randevular WHERE Randevuid=@P1", bağ.baglanti());
                    sql.Parameters.AddWithValue("@P1", txtıd.Text);
                    DataTable dt = new DataTable();
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sql);
                    sqlDataAdapter.Fill(dt);
                        dataGridView1.DataSource = dt;
                    
                }
            }
            catch(Exception ex) { 
            MessageBox.Show(ex.Message);
            }
            finally { bağ.baglanti().Close(); ; }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Listeleme();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.ReadOnly = true;
            dataGridView1.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtıd.Text != null && radioButton1.Checked==true)
                {
                    SqlCommand sql = new SqlCommand("DELETE TBL_Randevular WHERE Randevuid=@P1", bağ.baglanti());
                    sql.Parameters.AddWithValue("@P1", txtıd.Text);
                    sql.ExecuteNonQuery();
                    MessageBox.Show("Başarıyla Silindi");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { bağ.baglanti().Close();
                Listeleme();
            }
        }
    }
}

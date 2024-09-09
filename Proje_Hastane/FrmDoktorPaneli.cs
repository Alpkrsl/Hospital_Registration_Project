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
    public partial class FrmDoktorPaneli : Form
    {
        public FrmDoktorPaneli()
        {
            InitializeComponent();
        }

        sqlbaglantısı sqll = new sqlbaglantısı();
        private void FrmDoktorPaneli_Load(object sender, EventArgs e)
        {
            Cmbbranş.DropDownStyle = ComboBoxStyle.DropDownList;
            listele();

            DataTable dttt = new DataTable();
            SqlDataAdapter daaa = new SqlDataAdapter("SELECT DISTINCT(DoktorBranş) FROM Tbl_Doktorlar", sqll.baglanti());
            daaa.Fill(dttt);
            Cmbbranş.DataSource = dttt;
            Cmbbranş.DisplayMember = "DoktorBranş";
        }

        private void btnekle_Click(object sender, EventArgs e)
        {

            try
            {
                if (!string.IsNullOrEmpty(Txtad.Text) && txttc.Text.Length == 11 && Cmbbranş != null &&
                    !string.IsNullOrEmpty(Txtsoyad.Text) &&
                    !string.IsNullOrEmpty(txttc.Text) &&
                    !string.IsNullOrEmpty(Txtşifre.Text) &&
                    !string.IsNullOrEmpty(Cmbbranş.Text))
                {


                    SqlCommand ekle = new SqlCommand("INSERT INTO Tbl_Doktorlar(Doktorad,Doktorsoyad,DoktorTc,DoktorŞifre,DoktorBranş)VALUES(@P1,@P2,@P3,@P4,@P5)", sqll.baglanti());
                    ekle.Parameters.AddWithValue("@P1", Txtad.Text);
                    ekle.Parameters.AddWithValue("@P2", Txtsoyad.Text);
                    ekle.Parameters.AddWithValue("@P3", txttc.Text);
                    ekle.Parameters.AddWithValue("@P4", Txtşifre.Text);
                    ekle.Parameters.AddWithValue("@P5", Cmbbranş.Text);
                    ekle.ExecuteNonQuery();
                    sqll.baglanti().Close();
                    MessageBox.Show("Doktor eklendi");
                }
            }
            catch (Exception ex){
            MessageBox.Show(ex.Message);
            }
            finally { sqll.baglanti().Close(); }
            listele();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            SqlCommand sil = new SqlCommand("DELETE Tbl_Doktorlar WHERE DoktorTc=@r1",sqll.baglanti());
            sil.Parameters.AddWithValue("@r1", txttc.Text);
            sil.ExecuteNonQuery();
            sqll.baglanti() .Close();
            MessageBox.Show("Doktor Silindi");
            listele();
        }

        private void listele()
        {
            SqlCommand veri = new SqlCommand("SELECT*FROM Tbl_Doktorlar", sqll.baglanti());
            DataTable dt = new DataTable();
            SqlDataReader rdr = veri.ExecuteReader();
            dt.Load(rdr);
            dataGridView1.DataSource = dt;
            sqll.baglanti().Close();
            lbltcc.Text = tc;
            label7.Text = ad;
        }

        private void btngüncelle_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(Txtad.Text) && /*Convert.ToInt64(txttc.Text) == 11 &&*/
                    !string.IsNullOrEmpty(Txtsoyad.Text) &&
                    !string.IsNullOrEmpty(txttc.Text) &&
                    !string.IsNullOrEmpty(Txtşifre.Text) &&
                    !string.IsNullOrEmpty(Cmbbranş.Text))
                {
                    SqlCommand güncelle = new SqlCommand("UPDATE Tbl_Doktorlar SET Doktorad=@p1,Doktorsoyad=@p2,DoktorŞifre=@p4,DoktorBranş=@p5 WHERE DoktorTc=@p3", sqll.baglanti());
                    güncelle.Parameters.AddWithValue("@p1", Txtad.Text);
                    güncelle.Parameters.AddWithValue("@p2", Txtsoyad.Text);
                    güncelle.Parameters.AddWithValue("@p3", txttc.Text);
                    güncelle.Parameters.AddWithValue("@p4", Txtşifre.Text);
                    güncelle.Parameters.AddWithValue("@p5", Cmbbranş.Text);
                    güncelle.ExecuteNonQuery();
                    MessageBox.Show("Doktor Güncellendi");
                    listele();
                }
            }
            catch (Exception ex) { 
            MessageBox.Show(ex.Message);
            }
            finally
            {
                sqll.baglanti().Close();
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            Txtad.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            Txtsoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            txttc.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            Txtşifre.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            Cmbbranş.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
        }
        public string tc, ad;

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.ReadOnly = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lbltcc.Text = tc;
            label7.Text = ad;
            FrmSekreterDetay frmSekreterDetay = new FrmSekreterDetay();
            frmSekreterDetay.Tc=lbltcc.Text;
            frmSekreterDetay.add=label7.Text;
            frmSekreterDetay.değiş = Değ.Text;
            frmSekreterDetay.Show();
            this.Close();
        }
    }
}

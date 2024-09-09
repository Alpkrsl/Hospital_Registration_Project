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
    public partial class FrmBranşpaneli : Form
    {
        public FrmBranşpaneli()
        {
            InitializeComponent();
        }

        sqlbaglantısı sqll =new sqlbaglantısı();

        private void FrmBranşpaneli_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter DA = new SqlDataAdapter("SELECT*FROM Tbl_Branşlar", sqll.baglanti());
            DA.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            try
            {
                string ad = Txtad.Text;
                string query = "SELECT COUNT(*) FROM Tbl_Branşlar WHERE Branşad = @ad";
                SqlCommand cmd = new SqlCommand(query, sqll.baglanti());
                cmd.Parameters.AddWithValue("@ad", ad);

                int count = (int)cmd.ExecuteScalar();
                if (count == 0)
                {
                    if (!String.IsNullOrEmpty(Txtad.Text))
                    {
                        SqlCommand cm = new SqlCommand("INSERT INTO Tbl_Branşlar(Branşad)VALUES(@P1)", sqll.baglanti());
                        cm.Parameters.AddWithValue("@P1", Txtad.Text);
                        cm.ExecuteNonQuery();
                        sqll.baglanti().Close();
                        MessageBox.Show("Eklendi");
                    }
                }
                else
                {
                    MessageBox.Show("Bu ad zaten mevcut.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally { sqll.baglanti().Close();
                listele();
            }
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrEmpty(Txtid.Text))
                {
                    SqlCommand sil = new SqlCommand("DELETE Tbl_Branşlar WHERE Branşid=@P2", sqll.baglanti());
                    sil.Parameters.AddWithValue("@P2", Txtid.Text);
                    sil.ExecuteNonQuery();
                    MessageBox.Show("Silindi");
                }
            }
            catch(Exception ex) {
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally { sqll.baglanti().Close();
                listele();
            }

        }

        private void btngüncelle_Click(object sender, EventArgs e)
        {
            try
            {
                string ad = Txtad.Text;
                string query = "SELECT COUNT(*) FROM Tbl_Branşlar WHERE Branşad = @ad";
                SqlCommand cmd = new SqlCommand(query, sqll.baglanti());
                cmd.Parameters.AddWithValue("@ad", ad);

                int count = (int)cmd.ExecuteScalar();
                if (count == 0)
                {
                    if (!String.IsNullOrEmpty(Txtad.Text) &&
                    !String.IsNullOrEmpty(Txtid.Text))
                    {
                        SqlCommand güncel = new SqlCommand("UPDATE Tbl_Branşlar SET Branşad=@p1 WHERE Branşid=@p2", sqll.baglanti());
                        güncel.Parameters.AddWithValue("@p1", Txtad.Text);
                        güncel.Parameters.AddWithValue("@p2", Txtid.Text);

                        güncel.ExecuteNonQuery();
                        sqll.baglanti().Close();
                        MessageBox.Show("Güncellendi");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally { sqll.baglanti().Close();
                listele();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.ReadOnly = true;
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int seçilen = dataGridView1.SelectedCells[0].RowIndex;
            Txtid.Text = dataGridView1.Rows[seçilen].Cells[0].Value.ToString();
            Txtad.Text = dataGridView1.Rows[seçilen].Cells[1].Value.ToString();
        }
        public string tc, ad;
        private void button1_Click(object sender, EventArgs e)
        {
            lblad.Text = ad;
            lbltc.Text = tc;
            FrmSekreterDetay frmSekreterDetay = new FrmSekreterDetay();
            frmSekreterDetay.ad=lblad.Text;
            frmSekreterDetay.Tc=lbltc.Text;
            frmSekreterDetay.değişş = Değiş.Text;
            frmSekreterDetay.Show();
            this.Hide();
        }
    }
}

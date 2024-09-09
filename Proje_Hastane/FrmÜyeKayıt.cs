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
using System.Linq.Expressions;

namespace Proje_Hastane
{
    public partial class FrmÜyeKayıt : Form
    {
        public FrmÜyeKayıt()
        {
            InitializeComponent();
        }

        private void Mtbtel_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
        sqlbaglantısı bgl = new sqlbaglantısı();
        private void Cbcinsiyet_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnKayıt_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(Txtad.Text) && txttc.Text.Length == 11 && txttel.Text.Length == 11 &&
                    !string.IsNullOrEmpty(Txtsoyad.Text) &&
                    !string.IsNullOrEmpty(txttc.Text) &&
                    !string.IsNullOrEmpty(txttel.Text) &&
                    !string.IsNullOrEmpty(txtsifre.Text) &&
                    !string.IsNullOrEmpty(Cbcinsiyet.Text))
                {
                    SqlCommand kayıt = new SqlCommand("insert into Tbl_Hastalar(Hastaad,HastaSoyad,HastaTc,HastaTel,HastaŞifre,HastaCinsiyet)VALUES(@P1,@P2,@P3,@P4,@P5,@P6)", bgl.baglanti());
                    kayıt.Parameters.AddWithValue("@P1", Txtad.Text);
                    kayıt.Parameters.AddWithValue("@P2", Txtsoyad.Text);
                    kayıt.Parameters.AddWithValue("@P3", txttc.Text);
                    kayıt.Parameters.AddWithValue("@P4", txttel.Text);
                    kayıt.Parameters.AddWithValue("@P5", txtsifre.Text);
                    kayıt.Parameters.AddWithValue("@P6", Cbcinsiyet.Text);
                    kayıt.ExecuteNonQuery();
                    MessageBox.Show("Kaydınız Yapılmıştır Şifreniz:" + txtsifre.Text, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                bgl.baglanti().Close();
            }
            
        }

        private void FrmÜyeKayıt_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmHastaGiriş dsm = new FrmHastaGiriş();
            dsm.Show();
            this.Close();
        }
    }
}

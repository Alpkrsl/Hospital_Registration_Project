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

namespace Proje_Hastane
{
    public partial class FrmBilgiDüzenle : Form
    {
        public FrmBilgiDüzenle()
        {
            InitializeComponent();
        }
        public string TcNoo;
        sqlbaglantısı sql=new sqlbaglantısı();
        private void FrmBilgiDüzenle_Load(object sender, EventArgs e)
        {
            MskTc.Text= TcNoo;
            SqlCommand bilgi = new SqlCommand("SELECT*FROM Tbl_Hastalar WHERE HastaTc=@P1",sql.baglanti());
            bilgi.Parameters.AddWithValue("@P1",MskTc.Text);
            SqlDataReader dataReader = bilgi.ExecuteReader();
            while(dataReader.Read()) {
                Txtad.Text = dataReader[1].ToString();
                Txtsoyad.Text = dataReader[2].ToString();
                Mtbtel.Text = dataReader[4].ToString();
                txtsifre.Text = dataReader[5].ToString();
                Cbcinsiyet.Text = dataReader[6].ToString();
                sql.baglanti().Close();

            }

        }



        private void BtnKayıt_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(MskTc.Text)&&
                    !string.IsNullOrEmpty(Txtad.Text) &&
                    !string.IsNullOrEmpty(Txtsoyad.Text) &&
                    !string.IsNullOrEmpty(Mtbtel.Text) &&
                    !string.IsNullOrEmpty(txtsifre.Text) &&
                    !string.IsNullOrEmpty(Cbcinsiyet.Text)) {
                    SqlCommand güncelle = new SqlCommand("UPDATE Tbl_Hastalar SET Hastaad=@A1,Hastasoyad=@A2,HastaTel=@A3,HastaŞifre=@A4,HastaCinsiyet=@A5  WHERE HastaTc=@T1", sql.baglanti());
                    güncelle.Parameters.AddWithValue("@T1", MskTc.Text);
                    güncelle.Parameters.AddWithValue("@A1", Txtad.Text);
                    güncelle.Parameters.AddWithValue("@A2", Txtsoyad.Text);
                    güncelle.Parameters.AddWithValue("@A3", Mtbtel.Text);
                    güncelle.Parameters.AddWithValue("@A4", txtsifre.Text);
                    güncelle.Parameters.AddWithValue("@A5", Cbcinsiyet.Text);
                    güncelle.ExecuteNonQuery();
                    MessageBox.Show("Bilgileriniz Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch(Exception ex){
                MessageBox.Show(ex.Message,"Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            finally
            {
                sql.baglanti().Close();
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            FrmHastaDetay wd = new FrmHastaDetay();
            wd.tcc = MskTc.Text;
            wd.adsoyad =Txtad+" "+Txtsoyad;
            wd.değişken = label7.Text;
            wd.Show();
            this.Close();
        }
    }
}

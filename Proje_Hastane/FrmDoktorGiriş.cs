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
    public partial class FrmDoktorGiriş : Form
    {
        public FrmDoktorGiriş()
        {
            InitializeComponent();
        }
        sqlbaglantısı kal =new sqlbaglantısı();
        private void BtnGirişYap_Click(object sender, EventArgs e)
        {
            SqlCommand kall = new SqlCommand("Select*From Tbl_Doktorlar WHERE DoktorTc=@P1 and DoktorŞifre=@P2", kal.baglanti());
            kall.Parameters.AddWithValue("@P1", MskTc.Text);
            kall.Parameters.AddWithValue("@P2", txtsifre.Text);
            SqlDataReader dataReader = kall.ExecuteReader();
            if (dataReader.Read())
            {
                FrmDoktorDetay frmDoktorDetay = new FrmDoktorDetay();
                frmDoktorDetay.Tc = MskTc.Text;
                frmDoktorDetay.Show();               
                this.Hide();
                MessageBox.Show("Başarıyla giriş Yaptınız", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Hatalı Tc yada Şifre", "Hata Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            kal.baglanti().Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmGiriş dl = new FrmGiriş();
            dl.Show();
            this.Close();
        }
    }
}

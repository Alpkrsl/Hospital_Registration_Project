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
    public partial class FrmHastaGiriş : Form
    {
        public FrmHastaGiriş()
        {
            InitializeComponent();
        }

        private void Lnküyeol_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmÜyeKayıt üye=new FrmÜyeKayıt();
            üye.Show();
            this.Hide();
        }
        sqlbaglantısı bag=new sqlbaglantısı();
        private void FrmHastaGiriş_Load(object sender, EventArgs e)
        {
            
      
        }

        private void BtnGirişYap_Click(object sender, EventArgs e)
        {
            SqlCommand gir = new SqlCommand("Select*From Tbl_Hastalar WHERE HastaTc=@P1 and HastaŞifre=@P2", bag.baglanti());
            gir.Parameters.AddWithValue("@P1", MskTc.Text);
            gir.Parameters.AddWithValue("@P2", txtsifre.Text);
            SqlDataReader dataReader = gir.ExecuteReader();
            if (dataReader.Read())
            {
                FrmHastaDetay frmHastaDetay = new FrmHastaDetay();
                frmHastaDetay.tc = MskTc.Text;
                frmHastaDetay.Show();
                this.Hide();
                MessageBox.Show("Başarıyla giriş Yaptınız", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Hatalı Tc yada Şifre", "Hata Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            bag.baglanti().Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmGiriş frmGiriş = new FrmGiriş();
            frmGiriş.Show();
            this.Close();

        }
    }
}

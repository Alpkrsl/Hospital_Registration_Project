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
    public partial class FrmSekreterGiriş : Form
    {
        public FrmSekreterGiriş()
        {
            InitializeComponent();
        }

        private void FrmSekreterGiriş_Load(object sender, EventArgs e)
        {
            
            
        }

        sqlbaglantısı sqll = new sqlbaglantısı();
        private void BtnGirişYap_Click(object sender, EventArgs e)
        {

            SqlCommand gir = new SqlCommand("SELECT*FROM Tbl_Sekreter WHERE SekreterTc=@P1 AND SekreterŞifre=@P2",sqll.baglanti());
            gir.Parameters.AddWithValue("@P1",MskTc.Text);
            gir.Parameters.AddWithValue("@P2",txtsifre.Text);
            SqlDataReader oku=gir.ExecuteReader();
            if (oku.Read())
            {
                FrmSekreterDetay fsd=new FrmSekreterDetay();
                fsd.Tc = MskTc.Text;
                fsd.Show();
                this.Hide();
                MessageBox.Show("Başarıyla Giriş Yaptınız", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
               
            }
            else
            {
                MessageBox.Show("Yanlış Tc Yada Şifre","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            sqll.baglanti().Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmGiriş gir = new FrmGiriş();
            gir.Show();
            this.Close();
        }
    }
}

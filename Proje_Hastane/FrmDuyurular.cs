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
using System.Security.Cryptography.X509Certificates;

namespace Proje_Hastane
{
    public partial class FrmDuyurular : Form
    {
        public FrmDuyurular()
        {
            InitializeComponent();
        }
        sqlbaglantısı sql =new sqlbaglantısı();
        private void FrmDuyurular_Load(object sender, EventArgs e)
        {
            VeriGör();
            DataTable dt = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT*FROM Tbl_Duyurular",sql.baglanti());
            sqlDataAdapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void VeriGör()
        {
            label1.Text = doktorr;
            label2.Text = sekreterr;           
        }

        public string doktorr, sekreterr,doktorad,doktortc,sekreterad,sekretertc;

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            dataGridView1.ReadOnly = true;
            dataGridView1.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (label1.Text=="Doktor")
            {
                lbldoktoradsoyad.Text = doktorad;
                lbldoktortc.Text = doktortc;
                FrmDoktorDetay doktor = new FrmDoktorDetay();
                doktor.taş = label1.Text;
                doktor.doktoradsoyad = lbldoktoradsoyad.Text;
                doktor.doktortc = lbldoktortc.Text;
                doktor.değişkennn = lbldoktordeğişken.Text;
                doktor.Show();
                this.Close();
            }
            
          else if(label2.Text=="Sekreter")
            {
                lblSekreteradd.Text = sekreterad;
                lblSekretertcc.Text = sekretertc;
                FrmSekreterDetay sekreter = new FrmSekreterDetay();
                sekreter.taşı = label2.Text;
                sekreter.Tc = lblSekretertcc.Text;
                sekreter.sekreterasdoyad = lblSekreteradd.Text;
                sekreter.değişkenn = lblSekreterDeğişkenn.Text;
                sekreter.Show();
                this.Close();
            }
        }

    }
}

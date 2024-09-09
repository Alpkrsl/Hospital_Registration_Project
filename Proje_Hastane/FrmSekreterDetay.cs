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
    public partial class FrmSekreterDetay : Form
    {
        public FrmSekreterDetay()
        {
            InitializeComponent();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox3_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        //Branşlar geçiş
        public string ad, tc,değişş;
        private void button3_Click(object sender, EventArgs e)
        {
            tc = lbltcno.Text;
            ad=lbladsoyad.Text;
            FrmBranşpaneli frb = new FrmBranşpaneli();
            frb.tc = tc;
            frb.ad = ad;
            frb.Show();
            this.Close();
        }

        //Doktor Paneli geçiş
        public string tcc, add,değiş;
        private void button2_Click(object sender, EventArgs e)
        {
            tcc = lbltcno.Text;
            add = lbladsoyad.Text;
            FrmDoktorPaneli frmDoktorPanel  = new FrmDoktorPaneli();
            frmDoktorPanel.tc = tcc;
            frmDoktorPanel.ad=add;
            frmDoktorPanel.Show();
            this.Close();
        }

        //Randevu listesi geçiş
        public string tcno, addd, değişken;
        private void button4_Click(object sender, EventArgs e)
        {
            tcno= lbltcno.Text;
            addd=lbladsoyad.Text;
            FrmRandevuListesi fra = new FrmRandevuListesi();
            fra.ad = addd;  
            fra.tc=tcno;
            fra.Show();
            this.Close();

        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }
        public string Tc;
        sqlbaglantısı bağla = new sqlbaglantısı();
        private void FrmSekreterDetay_Load(object sender, EventArgs e)
        {
            verigöster();
            verigöster2();
            verigöster3();
            verigöster4();


            //Sekreter Listeleme
            Sekreterliste();

            //branş ekleme
            branşekleme();

            //Doktor ekleme
            Doktorekleme();


            //Comboboxa Branş Ekleme
            Combobranşekleme();

            cmbbranş.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbdoktor.DropDownStyle = ComboBoxStyle.DropDownList;
            //cmbdoktor.Text = " ";
            //cmbbranş.Text = " ";

        }

        private void verigöster4()
        {
            if (değişken == "Değiş")
            {
                lbltcno.Text = Tc;
                lbladsoyad.Text = addd;
            }
        }

        private void Sekreterliste()
        {
            lbltcno.Text = Tc;
            SqlCommand kom = new SqlCommand("SELECT Sekreteradsoyad FROM Tbl_Sekreter WHERE SekreterTc=@P1", bağla.baglanti());
            kom.Parameters.AddWithValue("@P1", lbltcno.Text);
            SqlDataReader dr = kom.ExecuteReader();
            while (dr.Read())
            {
                lbladsoyad.Text = dr[0].ToString();
            }

            bağla.baglanti().Close();
        }

        //ComboBranşEkleme Metodu
        private void Combobranşekleme()
        {
            DataTable dttt = new DataTable();
            SqlDataAdapter daaa = new SqlDataAdapter("SELECT BranşAd FROM Tbl_Branşlar", bağla.baglanti());
            daaa.Fill(dttt);
            cmbbranş.DataSource = dttt;
            cmbbranş.DisplayMember = "BranşAd";
        }

        //Doktor ekleme metodu
        private void Doktorekleme()
        {
            DataTable dtt = new DataTable();
            SqlDataAdapter daa = new SqlDataAdapter("SELECT*FROM Tbl_Doktorlar", bağla.baglanti());
            daa.Fill(dtt);
            dataGridView2.DataSource = dtt;

        }

        //Branş ekleme metodu
        private void branşekleme()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT Branşad FROM Tbl_Branşlar", bağla.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        //Randevuları gösterme
        private void verigöster3()
        {
            if (değişken == "Değiş")
            {
                lbltcno.Text =Tc;
                lbladsoyad.Text = addd;
            }
        }

        //Branşlar geçişi
        private void verigöster2()
        {
            if (değişş == "Değiş")
            {
                lbltcno.Text = Tc;
                lbladsoyad.Text = ad;
            }
        }

        //Doktor panel geçişi
        private void verigöster()
        {
            if (değiş == "Değiş")
            {
                lbltcno.Text = Tc;
                lbladsoyad.Text = add;
            }
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    if (!checkbdurum.Checked && mtbsaat.MaskFull)
            //    {
            //        if (!string.IsNullOrEmpty(mtbtarih.Text) &&
            //            !string.IsNullOrEmpty(mtbsaat.Text) &&
            //            !string.IsNullOrEmpty(cmbbranş.Text) &&
            //            !string.IsNullOrEmpty(cmbdoktor.Text))
            //        {
            //            SqlCommand kaydet = new SqlCommand("INSERT INTO Tbl_Randevular(RandevuTarih,RandevuSaat,RandevuBranş,RandevuDoktor)VALUES(@R1,@R2,@R3,@R4)", bağla.baglanti());
            //            kaydet.Parameters.AddWithValue("@R1", mtbtarih.Text);
            //            kaydet.Parameters.AddWithValue("@R2", mtbsaat.Text);
            //            kaydet.Parameters.AddWithValue("@R3", cmbbranş.Text);
            //            kaydet.Parameters.AddWithValue("@R4", cmbdoktor.Text);
            //            kaydet.ExecuteNonQuery();
            //            MessageBox.Show("Randevu Oluşturuldu", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        }
            //    }
            //    else
            //    {
            //        if (!string.IsNullOrEmpty(mtbtarih.Text) &&
            //            !string.IsNullOrEmpty(mtbsaat.Text) &&
            //            !string.IsNullOrEmpty(cmbbranş.Text) &&
            //            !string.IsNullOrEmpty(cmbdoktor.Text))
            //        {
            //            SqlCommand kaydet = new SqlCommand("INSERT INTO Tbl_Randevular_Yedek(RandevuTarih,RandevuSaat,RandevuBranş,RandevuDoktor)VALUES(@R1,@R2,@R3,@R4)", bağla.baglanti());
            //            kaydet.Parameters.AddWithValue("@R1", mtbtarih.Text);
            //            kaydet.Parameters.AddWithValue("@R2", mtbsaat.Text);
            //            kaydet.Parameters.AddWithValue("@R3", cmbbranş.Text);
            //            kaydet.Parameters.AddWithValue("@R4", cmbdoktor.Text);
            //            kaydet.ExecuteNonQuery();
            //            MessageBox.Show("Randevu Oluşturuldu", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        }
                //}
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
            //finally
            //{
            //    bağla.baglanti().Close();
            //}
        }

        private void cmbbranş_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbdoktor.Items.Clear();
            SqlCommand doktor = new SqlCommand("SELECT Doktorad,Doktorsoyad FROM Tbl_Doktorlar WHERE DoktorBranş=@P1",bağla.baglanti());
            doktor.Parameters.AddWithValue("@P1",cmbbranş.Text);
            SqlDataReader dataReader = doktor.ExecuteReader();
            while (dataReader.Read())
            {
                cmbdoktor.Items.Add(dataReader[0] +" "+ dataReader[1]);
            }
            bağla.baglanti().Close();
           
            

        }

        private void BtnOluştur_Click(object sender, EventArgs e)
        {
            SqlCommand Duyuru = new SqlCommand("INSERT INTO Tbl_Duyurular(Duyuru)VALUES(@a1)",bağla.baglanti());
            Duyuru.Parameters.AddWithValue("@a1",rtboluştur.Text);
            Duyuru.ExecuteNonQuery();
            bağla.baglanti().Close();
            MessageBox.Show("Duyuru Oluşturuldu");
            //DataTable dataTable = new DataTable();
            //SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(Duyuru);
            //sqlDataAdapter.Fill(dataTable);
            //FrmDuyurular frmDuyurular = new FrmDuyurular();
            //frmDuyurular.Datagridwi
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.ReadOnly = true;
            dataGridView1.Enabled = true;
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView2.ReadOnly = true;
            dataGridView2.Enabled = true;
        }

        //Randevu Güncelleme
        private void BtnGüncelle_Click(object sender, EventArgs e)
        {
            try
            {
                if (!checkbdurum.Checked && mtbsaat.MaskFull)
                {
                    if (!string.IsNullOrEmpty(mtbtarih.Text) &&
                        !string.IsNullOrEmpty(cmbbranş.Text) &&
                        !string.IsNullOrEmpty(cmbdoktor.Text)
                        && !string.IsNullOrEmpty(txbid.Text))
                    {
                        //INSERT INTO Tbl_Randevular(RandevuTarih,RandevuSaat,RandevuBranş,RandevuDoktor)VALUES(@R1,@R2,@R3,@R4)
                        SqlCommand kaydet = new SqlCommand("UPDATE Tbl_Randevular SET RandevuSaat=@R1,RandevuTarih=@R2,RandevuBranş=@R3,RandevuDoktor=@R4 WHERE Randevuid=@R5", bağla.baglanti());
                        kaydet.Parameters.AddWithValue("@R1", mtbsaat.Text);
                        kaydet.Parameters.AddWithValue("@R2", mtbtarih.Text);
                        kaydet.Parameters.AddWithValue("@R3", cmbbranş.Text);
                        kaydet.Parameters.AddWithValue("@R4", cmbdoktor.Text);
                        kaydet.Parameters.AddWithValue("@R5", txbid.Text);
                        kaydet.ExecuteNonQuery();
                        MessageBox.Show("Randevu Oluşturuldu", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Hata silinöiş değer güncellenemez silmek için duyurular kısmına gidiniz");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                bağla.baglanti().Close();
            }
        }

        //Duyurulara gidiş
        public string taşı,sekretertc,sekreterasdoyad,değişkenn;
        private void button1_Click(object sender, EventArgs e)
        {
            sekreterasdoyad=lbladsoyad.Text;
            sekretertc=lbltcno.Text;
            taşı=label3.Text;
            FrmDuyurular frmDuyurular = new FrmDuyurular();
            frmDuyurular.sekreterr = taşı;
            frmDuyurular.sekreterad = sekreterasdoyad;
            frmDuyurular.sekretertc = sekretertc;
            frmDuyurular.Show();
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            FrmSekreterGiriş frmSekreterGiriş = new FrmSekreterGiriş();
            frmSekreterGiriş.Show();
            this.Close();   
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
}

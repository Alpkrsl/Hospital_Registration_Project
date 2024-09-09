using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Proje_Hastane
{
    internal class Frm_Kişi_bilgi_sınıfı
    {

        private string ad;
        private string soyad;
        private char tc;
        private string şifre;
        private string branş;

        public string Ad { get => ad; set => ad = value; }
        public string Soyad { get => soyad; set => soyad = value; }
        public char Tc { get => tc; set => tc = value; }
        public string Şifre { get => şifre; set => şifre = value; }
        public string Branş { get => branş; set => branş = value; }



        public void bağlanma()
        {
            sqlbaglantısı sqlll = new sqlbaglantısı();
            SqlCommand sqll = new SqlCommand("SELECT Doktorad, Doktorsoyad, DoktorTc, DoktorŞifre, DoktorBranş FROM Tbl_Doktorlar WHERE Doktorad=@P1 AND Doktorsoyad=@P2 AND DoktorTc=@P3 AND DoktorŞifre=@P4 AND DoktorBranş=@P5 ", sqlll.baglanti());
            sqll.Parameters.AddWithValue("@P1", Ad);
            sqll.Parameters.AddWithValue("@P2", Soyad);
            sqll.Parameters.AddWithValue("@P3", Tc);
            sqll.Parameters.AddWithValue("@P4", Şifre);
            sqll.Parameters.AddWithValue("@P5", Branş);
            sqll.ExecuteNonQuery();

        }

    }
}


         
    


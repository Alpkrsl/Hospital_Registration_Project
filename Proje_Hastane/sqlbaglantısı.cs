using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Proje_Hastane
{
    internal class sqlbaglantısı
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection("Data Source=LAPTOP-HMITB4AP\\;Initial Catalog=HASTANEPROJE;Integrated Security=True");
            baglan.Open();
            return baglan;
        }
    }
}

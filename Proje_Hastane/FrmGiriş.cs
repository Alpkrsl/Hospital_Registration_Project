using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje_Hastane
{
    public partial class FrmGiriş : Form
    {
        public FrmGiriş()
        {
            InitializeComponent();
        }

        private void btnhasta_Click(object sender, EventArgs e)
        {
            FrmHastaGiriş fr=new FrmHastaGiriş();
            fr.Show();
            this.Hide();
        }

        private void Btndoktor_Click(object sender, EventArgs e)
        {
            FrmDoktorGiriş dr=new FrmDoktorGiriş();
            dr.Show();
            this.Hide();
        }

        private void btnsekreter_Click(object sender, EventArgs e)
        {
            FrmSekreterGiriş sek=new FrmSekreterGiriş();
            sek.Show();
            this.Hide();
        }
    }
}

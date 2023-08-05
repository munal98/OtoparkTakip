using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Otopark_Takip
{
    public partial class frm1AnaSayfa : Form
    {
        public frm1AnaSayfa()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm2AraçOtoparkKaydı kayit = new frm2AraçOtoparkKaydı();
            kayit.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frm3AraçOtoparkYerleri yer = new frm3AraçOtoparkYerleri();
            yer.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frm4AraçOtoparkÇıkışı çıkış = new frm4AraçOtoparkÇıkışı();
            çıkış.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmSatis satis = new frmSatis();
            satis.ShowDialog();
        }

        private void frm1AnaSayfa_Load(object sender, EventArgs e)
        {

        }
    }
}

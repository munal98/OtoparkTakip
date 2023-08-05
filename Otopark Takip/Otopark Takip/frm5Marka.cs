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

namespace Otopark_Takip
{
    public partial class frm5Marka : Form
    {
        public frm5Marka()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Server=185.169.52.79;Initial Catalog=Otopark_takip;User ID=180755023; Password=u!p6oT64;");

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into markabilgileri(marka) values('"+textBox1.Text+"')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Marka eklendi");
            textBox1.Clear();
            
        }

        private void frm5Marka_Load(object sender, EventArgs e)
        {

        }
    }
}

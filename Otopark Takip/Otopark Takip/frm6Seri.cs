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
    public partial class frm6Seri : Form
    {
        public frm6Seri()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Server=185.169.52.79;Initial Catalog=Otopark_takip;User ID=180755023; Password=u!p6oT64;");

        private void button1_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into seribilgileri(marka,seri) values('"+comboBox1.Text+"','" + textBox1.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Markaya bağlı araç serisi eklendi");
            textBox1.Clear();
            comboBox1.Text = "";
            comboBox1.Items.Clear();
            Marka();
        }

        private void frm6Seri_Load(object sender, EventArgs e)
        {
            Marka();

        }

        private void Marka()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select marka from markabilgileri", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                comboBox1.Items.Add(read["marka"].ToString());
            }
            baglanti.Close();
        }
    }
}

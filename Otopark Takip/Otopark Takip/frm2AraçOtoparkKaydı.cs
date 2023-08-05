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

namespace Otopark_Takip
{
    public partial class frm2AraçOtoparkKaydı : Form
    {
        public frm2AraçOtoparkKaydı()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Server=185.169.52.79;Initial Catalog=Otopark_takip;User ID=180755023; Password=u!p6oT64;");

        private void frm2AraçOtoparkKaydı_Load(object sender, EventArgs e)
        {
            BoşAraçlar();
            Marka();
           
        }

        private void Marka()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select marka from markabilgileri", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                comboMarka.Items.Add(read["marka"].ToString());
            }
            baglanti.Close();
        }

        private void BoşAraçlar()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from araçdurumu WHERE durumu='BOŞ'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                comboParkYeri.Items.Add(read["parkyeri"].ToString());
            }
            baglanti.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into araç_otopark_kaydı(tc,ad,soyad,email,plaka,marka,seri,renk,parkyeri,tarih) values(@tc,@ad,@soyad,@email,@plaka,@marka,@seri,@renk,@parkyeri,@tarih)",baglanti);
            komut.Parameters.AddWithValue("@tc", txtTc.Text);
            komut.Parameters.AddWithValue("@ad", txtAd.Text);
            komut.Parameters.AddWithValue("@soyad", TxtSoyad.Text);
            komut.Parameters.AddWithValue("@telefon", TxtTelefon.Text);
            komut.Parameters.AddWithValue("@email", txtEmail.Text);
            komut.Parameters.AddWithValue("@plaka", txtPlaka.Text);
            komut.Parameters.AddWithValue("@marka", comboMarka.Text);
            komut.Parameters.AddWithValue("@seri", comboSeri.Text);
            komut.Parameters.AddWithValue("@renk", txtRenk.Text);
            komut.Parameters.AddWithValue("@parkyeri", comboParkYeri.Text);
            komut.Parameters.AddWithValue("@tarih", DateTime.Now.ToString());

            komut.ExecuteNonQuery();

            SqlCommand komut2 = new SqlCommand("update araçdurumu set durumu='DOLU' where parkyeri='" + comboParkYeri.SelectedItem + "'", baglanti);
            komut2.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Araç kaydı oluşturuldu", "Kayıt");
            comboParkYeri.Items.Clear();
            BoşAraçlar();
            comboMarka.Items.Clear();
            Marka();
            comboSeri.Items.Clear();

            foreach (Control item in grupKişi.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
            foreach (Control item in grupAraç.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
               
            }
            foreach (Control item in grupAraç.Controls)
            {
                if (item is ComboBox)
                {
                    item.Text = "";
                }
            }
        }

        private void btnMarka_Click(object sender, EventArgs e)
        {
            frm5Marka marka = new frm5Marka();
            marka.ShowDialog();

        }

        private void btnSeri_Click(object sender, EventArgs e)
        {
            frm6Seri seri = new frm6Seri();
            seri.ShowDialog();
        }

        private void grupAraç_Enter(object sender, EventArgs e)
        {

        }

        private void comboMarka_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboSeri.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select marka,seri from seribilgileri where marka='"+comboMarka.SelectedItem+"'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                comboSeri.Items.Add(read["seri"].ToString());
            }
            baglanti.Close();
        }

    }
}

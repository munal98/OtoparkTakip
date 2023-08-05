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
    public partial class frm3AraçOtoparkYerleri : Form
    {
        public frm3AraçOtoparkYerleri()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Server=185.169.52.79;Initial Catalog=Otopark_takip;User ID=180755023; Password=u!p6oT64;");
        private void frm3AraçOtoparkYerleri_Load(object sender, EventArgs e)
        {
            BoşParkYerleri();
            DoluParkYerleri();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from araç_otopark_kaydı", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                foreach (Control item in Controls)
                {
                    if (item is Button)
                    {
                        if (item.Text == read["parkyeri"].ToString())
                        {
                            item.Name = read["plaka"].ToString();
                            item.Text = read["plaka"].ToString();
                        }
                    }
                }
            }
            baglanti.Close();
        }

        private void DoluParkYerleri()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from araçdurumu", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                foreach (Control item in Controls)
                {
                    if (item is Button)
                    {
                        if (item.Text == read["parkyeri"].ToString() && read["durumu"].ToString() == "DOLU")
                        {
                            item.BackColor = Color.Red;
                        }
                    }
                }
            }
            baglanti.Close();
        }



        private void BoşParkYerleri()
        {
            int sayac = 1;
            foreach (Control item in Controls)
            {
                if (item is Button)
                {
                    item.Text = "P-" + sayac;
                    item.Name = "P-" + sayac;
                    sayac++;
                }
            }
        }
    }
}

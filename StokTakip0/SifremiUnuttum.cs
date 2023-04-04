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

namespace StokTakip0
{
    public partial class SifremiUnuttum : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-SN77AA1;Initial Catalog=stokTakip;Integrated Security=True");
        public SifremiUnuttum()
        {
            InitializeComponent();
        }

        private void btnSifreAl_Click(object sender, EventArgs e)
        {
            {
                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();
                    string sorgu = "Select depoSorumlusuSifre From depoSorumlusu where depoSorumlusuEposta=@user and depoSorumlusuTC=@tc";
                    cmd = new SqlCommand(sorgu, baglanti);

                    cmd.Parameters.AddWithValue("@user", txtEPosta.Text);
                    cmd.Parameters.AddWithValue("@tc", txtTCNo.Text);


                    dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        string sifre;
                        sifre = dr.GetValue(0).ToString();
                        string mesaj = sifre;
                        MessageBox.Show("Şifreniz: " + mesaj);

                    }
                    else
                    {
                        picError.Visible = true;
                        lblError.Visible = true;
                        lblError.ForeColor = Color.DeepPink;
                        lblError.Text = "Lütfen Bilgileri Kontrol Ediniz.";
                    }
                }
                baglanti.Close();
            }
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void picMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}

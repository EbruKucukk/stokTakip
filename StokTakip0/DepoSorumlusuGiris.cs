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
    public partial class DepoSorumlusuGiris : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        public DepoSorumlusuGiris()
        {
            InitializeComponent();
            BeniHatirla();
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit(); //ekranda sağ üstteki çarpı butonuna basınca ekranı kapatma kodu
        }

        private void picMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized; //ekranda sağ üstte eksi butonuna basınca ekranı alt sekmeye alma kodu
        }

        private void picGeri_Click(object sender, EventArgs e)
        {
            //ekranda sol üstteki geri butonuna basınca bir önceki sayfaya dönme kodu
            Main anasayfa = new Main();
            anasayfa.Show();
            this.Close();
        }

        private void picEye_Click(object sender, EventArgs e)
        {
            //şifreyi gözükür yapmak için
            txtSifre.UseSystemPasswordChar = false;
            picEye.Visible = false;
            picHide.Visible = true; 
        }

        private void picHide_Click(object sender, EventArgs e)
        {
            //şifreyi gizlemek için
            txtSifre.UseSystemPasswordChar = true;
            picEye.Visible = true;
            picHide.Visible = false;
        }

        private void picClose_MouseHover(object sender, EventArgs e)
        {
            // fare close fotoğrafının üstüne gelince Kapat yazısını göster
            toolTip1.SetToolTip(picClose, "Kapat");
        }

        private void picMinimize_MouseHover(object sender, EventArgs e)
        {
            // fare minimize fotoğrafının üstüne gelince Küçült yazısını göster
            toolTip1.SetToolTip(picMinimize, "Küçült");
        }

        private void picGeri_MouseHover(object sender, EventArgs e)
        {
            // fare geri fotoğrafının üstüne gelince Geri Git yazısını göster
            toolTip1.SetToolTip(picGeri, "Geri Git");
        }

        private void picEye_MouseHover(object sender, EventArgs e)
        {
            // fare Eye fotoğrafının üstüne gelince Şifreyi Göster yazısını göster
            toolTip1.SetToolTip(picEye, "Şifreyi Göster");
        }

        private void picHide_MouseHover(object sender, EventArgs e)
        {
            // fare Hide fotoğrafının üstüne gelince Şifreyi Gizle yazısını göster
            toolTip1.SetToolTip(picHide, "Şifreyi Gizle");
        }
      private void BeniHatirla()
        {
            if (Properties.Settings.Default.Ad != String.Empty)
            {
                if(Properties.Settings.Default.Soyad != String.Empty)
                {
                    if (Properties.Settings.Default.Hatirla == true)
                    {
                        txtAd.Text = Properties.Settings.Default.Ad;
                        txtSoyad.Text =   Properties.Settings.Default.Soyad;
                        chckBeniHatirla.Checked = true;
                        Save_Data();
                    }
                }
            }
            else
            {
                txtAd.Text= Properties.Settings.Default.Ad;
                txtSoyad.Text= Properties.Settings.Default.Soyad;
            }
        }
        private void Save_Data()
        {
            if (chckBeniHatirla.Checked)
            {
                Properties.Settings.Default.Ad = txtAd.Text.Trim();
                Properties.Settings.Default.Soyad = txtSoyad.Text.Trim();
                Properties.Settings.Default.Hatirla = true;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.Ad = "";
                Properties.Settings.Default.Soyad = "";
                Properties.Settings.Default.Hatirla = false;
                Properties.Settings.Default.Save();
            }
        }

        private void btnGirişYap_Click(object sender, EventArgs e)
        {
            string sorgu = "SELECT * FROM depoSorumlusu where depoSorumlusuAd=@user AND depoSorumlusuSifre=@pass and depoSorumlusuSoyad=@surname";
            con = new SqlConnection(@"Data Source=DESKTOP-SN77AA1;Initial Catalog=stokTakip;Integrated Security=True");  
            cmd = new SqlCommand(sorgu, con);
            cmd.Parameters.AddWithValue("@user", txtAd.Text);
            cmd.Parameters.AddWithValue("@pass", txtSifre.Text);
            cmd.Parameters.AddWithValue("@surname", txtSoyad.Text);
            con.Open();  
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                DepoSorumlusuMain depomain = new DepoSorumlusuMain();
                depomain.Show();
                this.Hide();
                Save_Data();

            }
            else
            {
                labelError.Visible = true; 
                picError.Visible = true;   
            }
            con.Close(); 
        }

        private void DepoSorumlusuGiris_Load(object sender, EventArgs e)
        {

        }

        private void lblSifreUnut_Click(object sender, EventArgs e)
        {
            SifremiUnuttum sifreYenile = new SifremiUnuttum();
            sifreYenile.Show();
        }
    }
}

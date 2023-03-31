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
    public partial class DepoSorumlusuKontrol : Form
    {
        public DepoSorumlusuKontrol()
        {
            InitializeComponent();

        }
        SqlDataAdapter da;
        DataSet ds;
        SqlCommand komut;
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-SN77AA1;Initial Catalog=stokTakip;Integrated Security=True");
        private void kayitGetirPersonel()
        {
            baglanti.Open();
            string kayit = "SELECT personelAd AS 'Ad', personelSoyad AS 'Soyad', personelSifre AS 'Şifre',personelEposta AS 'E Posta', personelTelNo AS 'Tel No', personelAdres AS 'Adres', personelID AS 'ID', personelTC AS 'TC Kimlik' From personel";
            //musteriler tablosundaki tüm kayıtları çekecek olan sql sorgusu.
            SqlCommand komut = new SqlCommand(kayit, baglanti);
            //Sorgumuzu ve baglantimizi parametre olarak alan bir SqlCommand nesnesi oluşturuyoruz.
            SqlDataAdapter da = new SqlDataAdapter(komut);
            //SqlDataAdapter sınıfı verilerin databaseden aktarılması işlemini gerçekleştirir.
            DataTable dt = new DataTable();
            da.Fill(dt);
            //Bir DataTable oluşturarak DataAdapter ile getirilen verileri tablo içerisine dolduruyoruz.
            birimTablo.DataSource = dt;
            //Formumuzdaki DataGridViewin veri kaynağını oluşturduğumuz tablo olarak gösteriyoruz.
            baglanti.Close();
        }
        private void kayitGetirDepoSorumlusu()
        {
            baglanti.Open();
            string kayit = "SELECT depoSorumlusuAd AS 'Ad', depoSorumlusuSoyad AS 'Soyad', depoSorumlusuSifre AS 'Şifre', depoSorumlusuEposta AS 'E Posta', depoSorumlusuTelNo AS 'Tel No', depoSorumlusuAdres AS 'Adres', depoSorumlusuID AS 'ID', depoSorumlusuTC AS 'TC Kimlik' FROM depoSorumlusu";
            //musteriler tablosundaki tüm kayıtları çekecek olan sql sorgusu.
            SqlCommand komut = new SqlCommand(kayit, baglanti);
            //Sorgumuzu ve baglantimizi parametre olarak alan bir SqlCommand nesnesi oluşturuyoruz.
            SqlDataAdapter da = new SqlDataAdapter(komut);
            //SqlDataAdapter sınıfı verilerin databaseden aktarılması işlemini gerçekleştirir.
            DataTable dt = new DataTable();
            da.Fill(dt);
            //Bir DataTable oluşturarak DataAdapter ile getirilen verileri tablo içerisine dolduruyoruz.
            birimTablo.DataSource = dt;
            //Formumuzdaki DataGridViewin veri kaynağını oluşturduğumuz tablo olarak gösteriyoruz.
            baglanti.Close();
        }
        private void DepoSorumlusuKontrol_Load(object sender, EventArgs e)
        {
           
        }

        private void picMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized; //ekranda sağ üstte eksi butonuna basınca ekranı alt sekmeye alma kodu
        }

        private void picGeri_Click(object sender, EventArgs e)
        {

        }

        private void picClose_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit(); //ekranda sağ üstteki çarpı butonuna basınca ekranı kapatma kodu
        }

        private void birimCombo_KeyDown(object sender, KeyEventArgs e)
        {
            e.Handled = true;
        }

        private void birimCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (birimCombo.SelectedIndex == 0)
            {
                ekleBtn3.Visible = false;
                ekleBtn1.Visible = true;
                ekleBtn2.Visible = false;
                kayitGetirPersonel();
            }
            else if (birimCombo.SelectedIndex == 1)
            {
                ekleBtn3.Visible = false;
                ekleBtn1.Visible = false;
                ekleBtn2.Visible = true;
                kayitGetirDepoSorumlusu();
            }
        }

        private void birimTablo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtTCNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void birimTablo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtBirimAd.Text = birimTablo.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtBirimSoyad.Text = birimTablo.Rows[e.RowIndex].Cells[1].Value.ToString();
            birimSifre.Text = birimTablo.Rows[e.RowIndex].Cells[2].Value.ToString();
            birimSifre2.Text = birimTablo.Rows[e.RowIndex].Cells[2].Value.ToString();
            birimEposta.Text = birimTablo.Rows[e.RowIndex].Cells[3].Value.ToString();
            birimTelNo.Text = birimTablo.Rows[e.RowIndex].Cells[4].Value.ToString();
            birimAdres.Text = birimTablo.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtTCNo.Text = birimTablo.Rows[e.RowIndex].Cells[6].Value.ToString();
        }

        private void picEye_Click(object sender, EventArgs e)
        {
            //şifreyi gözükür yapmak için
            birimSifre.UseSystemPasswordChar = false;
            picEye.Visible = false;
            picHide.Visible = true;
        }

        private void picHide_Click(object sender, EventArgs e)
        {
            birimSifre.UseSystemPasswordChar = true;
            picEye.Visible = true;
            picHide.Visible = false;
        }
        private void picEye2_Click(object sender, EventArgs e)
        {
            birimSifre2.UseSystemPasswordChar = false;
            picEye2.Visible = false;
            picHide2.Visible = true;
        }

        private void picHide2_Click(object sender, EventArgs e)
        {
            //şifreyi gözükür yapmak için
            birimSifre2.UseSystemPasswordChar = true;
            picEye2.Visible = true;
            picHide2.Visible = false;
        }

        private void ekleBtn1_Click(object sender, EventArgs e)
        {
            //personel ekleme işlemleri

        }

        private void ekleBtn2_Click(object sender, EventArgs e)
        {
            //depo sorumlusu ekleme işlemleri
        }
    }
}

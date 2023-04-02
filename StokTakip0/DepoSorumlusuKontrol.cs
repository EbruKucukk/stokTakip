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
            string kayit = "SELECT personelAd AS 'Ad', personelSoyad AS 'Soyad', personelSifre AS 'Şifre',personelEposta AS 'E Posta', personelTelNo AS 'Tel No', personelAdres AS 'Adres', personelTC AS 'TC Kimlik' From personel";
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

            birimTablo.EnableHeadersVisualStyles = false;
            Color lacivert = ColorTranslator.FromHtml("#031A3D");
            birimTablo.ColumnHeadersDefaultCellStyle.BackColor = lacivert;
            birimTablo.Columns[6].DefaultCellStyle.BackColor = Color.Lavender;
            birimTablo.Columns[5].DefaultCellStyle.BackColor = Color.Lavender;
            birimTablo.Columns[4].DefaultCellStyle.BackColor = Color.Lavender;
            birimTablo.Columns[3].DefaultCellStyle.BackColor = Color.Lavender;
            birimTablo.Columns[2].DefaultCellStyle.BackColor = Color.Lavender;
            birimTablo.Columns[1].DefaultCellStyle.BackColor = Color.Lavender;
            birimTablo.Columns[0].DefaultCellStyle.BackColor = Color.Lavender;
            birimTablo.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            birimTablo.ColumnHeadersDefaultCellStyle.Font = new Font("tahoma", 11);
            birimTablo.Columns[0].DefaultCellStyle.Font = new Font("Verdana", 10);
            birimTablo.Columns[1].DefaultCellStyle.Font = new Font("Verdana", 10);
            birimTablo.Columns[2].DefaultCellStyle.Font = new Font("Verdana", 10);
            birimTablo.Columns[3].DefaultCellStyle.Font = new Font("Verdana", 10);
            birimTablo.Columns[4].DefaultCellStyle.Font = new Font("Verdana", 10);
            birimTablo.Columns[5].DefaultCellStyle.Font = new Font("Verdana", 10);
            birimTablo.Columns[6].DefaultCellStyle.Font = new Font("Verdana", 10);
        }
        private void kayitGetirDepoSorumlusu()
        {
            baglanti.Open();
            string kayit = "SELECT depoSorumlusuAd AS 'Ad', depoSorumlusuSoyad AS 'Soyad', depoSorumlusuSifre AS 'Şifre', depoSorumlusuEposta AS 'E Posta', depoSorumlusuTelNo AS 'Tel No', depoSorumlusuAdres AS 'Adres', depoSorumlusuTC AS 'TC Kimlik' FROM depoSorumlusu";
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

            birimTablo.EnableHeadersVisualStyles = false;
            Color lacivert = ColorTranslator.FromHtml("#031A3D");
            birimTablo.ColumnHeadersDefaultCellStyle.BackColor = lacivert;
            birimTablo.Columns[6].DefaultCellStyle.BackColor = Color.Lavender;
            birimTablo.Columns[5].DefaultCellStyle.BackColor = Color.Lavender;
            birimTablo.Columns[4].DefaultCellStyle.BackColor = Color.Lavender;
            birimTablo.Columns[3].DefaultCellStyle.BackColor = Color.Lavender;
            birimTablo.Columns[2].DefaultCellStyle.BackColor = Color.Lavender;
            birimTablo.Columns[1].DefaultCellStyle.BackColor = Color.Lavender;
            birimTablo.Columns[0].DefaultCellStyle.BackColor = Color.Lavender;
            birimTablo.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            birimTablo.ColumnHeadersDefaultCellStyle.Font = new Font("tahoma", 11);
            birimTablo.Columns[0].DefaultCellStyle.Font = new Font("Verdana", 10);
            birimTablo.Columns[1].DefaultCellStyle.Font = new Font("Verdana", 10);
            birimTablo.Columns[2].DefaultCellStyle.Font = new Font("Verdana", 10);
            birimTablo.Columns[3].DefaultCellStyle.Font = new Font("Verdana", 10);
            birimTablo.Columns[4].DefaultCellStyle.Font = new Font("Verdana", 10);
            birimTablo.Columns[5].DefaultCellStyle.Font = new Font("Verdana", 10);
            birimTablo.Columns[6].DefaultCellStyle.Font = new Font("Verdana", 10);
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
            YöneticiMain yoneticiMain = new YöneticiMain();
            yoneticiMain.Show();
            this.Close();
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
                butonGuncelleDepo.Visible = false;
                buton4.Visible = false;
                butonGuncellePersonel.Visible = true;

                silButonPersonel.Visible = true;
                buton3.Visible = false;
                silButonDepo.Visible = false;
                ekleBtn3.Visible = false;
                ekleBtn1.Visible = true;
                ekleBtn2.Visible = false;
                kayitGetirPersonel();
            }
            else if (birimCombo.SelectedIndex == 1)
            {
                butonGuncelleDepo.Visible = true;
                buton4.Visible = false;
                butonGuncellePersonel.Visible = false;
                silButonDepo.Visible = true;
                buton3.Visible = false;
                silButonPersonel.Visible = false;
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
            if (txtTCNo.TextLength == 11)
            {
                if (birimTelNo.TextLength == 11)
                {
                    if (birimSifre.Text == birimSifre2.Text && birimEposta.Text != "" && txtBirimSoyad.Text != ""
                     && birimSifre.Text != "" && txtTCNo.Text != "" &&
                     birimTelNo.Text != "" && txtBirimAd.Text != "" && birimAdres.Text != "")
                {
                    baglanti.Open();
                    string kayit = "INSERT INTO personel(personelAd, personelSoyad,personelSifre,personelEposta, personelTelNo, personelAdres, personelTC) VALUES ('" + txtBirimAd.Text + "', '" + txtBirimSoyad.Text + "','" + birimSifre.Text + "','" + birimEposta.Text + "','" + birimTelNo.Text + "','" + birimAdres.Text + "','" + txtTCNo.Text + "')";
                    SqlCommand komut = new SqlCommand(kayit, baglanti);
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    lblmesaj.Visible = true;
                    lblmesaj.ForeColor = Color.Green;
                    lblmesaj.Text = "Başarıyla Kaydedildi";
                    kayitGetirPersonel();
                }
                else
                {
                    lblmesaj.Visible = true;
                    lblmesaj.ForeColor = Color.Red;
                    lblmesaj.Text = "Bilgileri Kontrol Ediniz";

                }
                baglanti.Close();
                }
                else
                {
                    lblmesaj.Visible = true;
                    lblmesaj.ForeColor = Color.Red;
                    lblmesaj.Text = "Telefon Numarası Bilgilerini Kontrol Ediniz!";
                }
            }
            else
            {
                lblmesaj.Visible = true;
                lblmesaj.ForeColor = Color.Red;
                lblmesaj.Text = "TC Kimlik Bilgilerini Kontrol Ediniz";
            }
        }

        private void ekleBtn2_Click(object sender, EventArgs e)
        {
            if (txtTCNo.TextLength == 11)
            {
                if (birimTelNo.TextLength == 11)
                {
                    //depo sorumlusu ekleme işlemleri
                    if (birimSifre.Text == birimSifre2.Text && birimEposta.Text != "" && txtBirimSoyad.Text != ""
                         && birimSifre.Text != "" && txtTCNo.Text != "" &&
                         birimTelNo.Text != "" && birimCombo.Text != "" && txtBirimAd.Text != "" && birimAdres.Text != "")
                    {
                        if (baglanti.State == ConnectionState.Closed)
                        {
                            baglanti.Open();
                            string kayit = "insert into depoSorumlusu(depoSorumlusuAd, depoSorumlusuSoyad,depoSorumlusuSifre,depoSorumlusuEposta, depoSorumlusuTelNo, depoSorumlusuAdres, depoSorumlusuTC) values ('" + txtBirimAd.Text + "', '" + txtBirimSoyad.Text + "','" + birimSifre.Text + "','" + birimEposta.Text + "','" + birimTelNo.Text + "','" + birimAdres.Text + "','" + txtTCNo.Text + "')";
                            SqlCommand komut = new SqlCommand(kayit, baglanti);
                            komut.ExecuteNonQuery();
                            baglanti.Close();
                            lblmesaj.Visible = true;
                            lblmesaj.ForeColor = Color.Green;
                            lblmesaj.Text = "Başarıyla Kaydedildi";
                            kayitGetirDepoSorumlusu();
                        }

                        else
                        {
                            lblmesaj.Visible = true;
                            lblmesaj.ForeColor = Color.Red;
                            lblmesaj.Text = "Bilgileri Kontrol Ediniz";
                        }

                    }
                    else
                    {
                        lblmesaj.Visible = true;
                        lblmesaj.ForeColor = Color.Red;
                        lblmesaj.Text = "Bilgileri Kontrol Ediniz";

                    }
                    baglanti.Close();
                }
                else
                {
                    lblmesaj.Visible = true;
                    lblmesaj.ForeColor = Color.Red;
                    lblmesaj.Text = "Telefon Numarası Bilgilerini Kontrol Ediniz!";
                }
            }
                else
                {
                    lblmesaj.Visible = true;
                    lblmesaj.ForeColor = Color.Red;
                    lblmesaj.Text = "TC Kimlik Bilgilerini Kontrol Ediniz!";
                }
        }

        private void txtBirimAd_TextChanged(object sender, EventArgs e)
        {
 
        }
        void KayıtSil(string numara)
        {
            string sql = "DELETE FROM personel WHERE personelTC=@yeni";
            komut = new SqlCommand(sql, baglanti);
            komut.Parameters.AddWithValue("@yeni", numara);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
        }
        void KayıtSil2(string numara)
        {
            string sql = "DELETE FROM depoSorumlusu WHERE depoSorumlusuTC=@yeni";
            komut = new SqlCommand(sql, baglanti);
            komut.Parameters.AddWithValue("@yeni", numara);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
        }
        private void silButonPersonel_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow drow in birimTablo.SelectedRows)  //Seçili Satırları Silme
            {
                string numara = Convert.ToString(drow.Cells[6].Value);
                KayıtSil(numara);
                lblmesaj.Visible = true;
                lblmesaj.ForeColor = Color.Green;
                lblmesaj.Text = "Başarıyla Silindi";
            }
            kayitGetirPersonel();
        }

        private void silButonDepo_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow drow in birimTablo.SelectedRows)  //Seçili Satırları Silme
            {
                string numara = Convert.ToString(drow.Cells[6].Value);
                KayıtSil2(numara);
                lblmesaj.Visible = true;
                lblmesaj.ForeColor = Color.Green;
                lblmesaj.Text = "Başarıyla Silindi";
            }
            kayitGetirDepoSorumlusu();
        }

        private void butonGuncellePersonel_Click(object sender, EventArgs e)
        {
            if (txtTCNo.TextLength == 11)
            {
                if (birimTelNo.TextLength == 11)
                {
                    if (birimSifre.Text == birimSifre2.Text && birimEposta.Text != "" && txtBirimSoyad.Text != ""
                         && birimSifre.Text != "" && txtTCNo.Text != "" &&
                         birimTelNo.Text != "" && birimCombo.Text != "" && txtBirimAd.Text != "" && birimAdres.Text != "")
                    {
                        string ID = txtTCNo.Text;
                        //personel bilgilerinde güncelleme
                        if (!string.IsNullOrEmpty(ID)) // ID'nin Boş olup olmadığının kontrolü
                        {
                            string sql = "update personel set personelAd = '" + txtBirimAd.Text + "',personelSoyad = '" + txtBirimSoyad.Text + "', personelSifre = '" + birimSifre.Text + "', personelEposta = '" + birimEposta.Text + "', personelTelNo = '" + birimTelNo.Text + "', personelAdres = '" + birimAdres.Text + "' where personelTC = '" + ID + "' ";
                            SqlCommand komut = new SqlCommand(sql, baglanti);

                            if (baglanti.State != ConnectionState.Open) // bağlantı açık değilse açtırıyoruz.
                            {
                                baglanti.Open();
                            }
                            komut.ExecuteNonQuery(); // sql sorgusunu işleme koyuyoruz.
                            baglanti.Close(); // bağlantıyı kapatıyoruz
                            kayitGetirPersonel();
                            lblmesaj.Visible = true;
                            lblmesaj.ForeColor = Color.Green;
                            lblmesaj.Text = "Başarıyla Güncellendir!";
                        }
                    }
                    else
                    {
                        lblmesaj.Visible = true;
                        lblmesaj.ForeColor = Color.Red;
                        lblmesaj.Text = "Bilgileri Kontrol Ediniz!";

                    }
                }
                else
                {
                    lblmesaj.Visible = true;
                    lblmesaj.ForeColor = Color.Red;
                    lblmesaj.Text = "Telefon Numarası Bilgilerini Kontrol Ediniz!";
                }
            }
            else
            {
                lblmesaj.Visible = true;
                lblmesaj.ForeColor = Color.Red;
                lblmesaj.Text = "TC Kimlik Bilgilerini Kontrol Ediniz!";
            }
        }

        private void butonGuncelleDepo_Click(object sender, EventArgs e)
        {
            if (txtTCNo.TextLength == 11)
            {
                if (birimTelNo.TextLength == 11)
                {
                    if (birimSifre.Text == birimSifre2.Text && birimEposta.Text != "" && txtBirimSoyad.Text != ""
                         && birimSifre.Text != "" && txtTCNo.Text != "" &&
                         birimTelNo.Text != "" && birimCombo.Text != "" && txtBirimAd.Text != "" && birimAdres.Text != "")
                    {
                        string ID = txtTCNo.Text;
                        //personel bilgilerinde güncelleme
                        if (!string.IsNullOrEmpty(ID)) // ID'nin Boş olup olmadığının kontrolü
                        {
                            string sql = "update depoSorumlusu set depoSorumlusuAd = '" + txtBirimAd.Text + "',depoSorumlusuSoyad = '" + txtBirimSoyad.Text + "', depoSorumlusuSifre = '" + birimSifre.Text + "', depoSorumlusuEposta = '" + birimEposta.Text + "', depoSorumlusuTelNo = '" + birimTelNo.Text + "', depoSorumlusuAdres = '" + birimAdres.Text + "' where depoSorumlusuTC = '" + ID + "' ";
                            SqlCommand komut = new SqlCommand(sql, baglanti);

                            if (baglanti.State != ConnectionState.Open) // bağlantı açık değilse açtırıyoruz.
                            {
                                baglanti.Open();
                            }
                            komut.ExecuteNonQuery(); // sql sorgusunu işleme koyuyoruz.
                            baglanti.Close(); // bağlantıyı kapatıyoruz
                            kayitGetirDepoSorumlusu();
                            lblmesaj.Visible = true;
                            lblmesaj.ForeColor = Color.Green;
                            lblmesaj.Text = "Başarıyla Güncellendir!";
                        }
                    }
                    else
                    {
                        lblmesaj.Visible = true;
                        lblmesaj.ForeColor = Color.Red;
                        lblmesaj.Text = "Bilgileri Kontrol Ediniz!";

                    }
                }
                else
                {
                    lblmesaj.Visible = true;
                    lblmesaj.ForeColor = Color.Red;
                    lblmesaj.Text = "Telefon Numarası Bilgilerini Kontrol Ediniz!";
                }
                }
                else
                {
                    lblmesaj.Visible = true;
                    lblmesaj.ForeColor = Color.Red;
                    lblmesaj.Text = "TC Kimlik Bilgilerini Kontrol Ediniz!";
                }
            }

        private void buton3_Click(object sender, EventArgs e)
        {

        }
    }
}

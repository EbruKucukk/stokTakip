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
    public partial class FirmalarKontrol : Form
    {
        public FirmalarKontrol()
        {
            InitializeComponent();
        }
        SqlDataAdapter da;
        DataSet ds;
        SqlCommand komut;
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-SN77AA1;Initial Catalog=stokTakip;Integrated Security=True");
        private void kayitGetir()
        {
            baglanti.Open();
            string kayit = "SELECT firmaID AS 'ID', firmaAd AS 'Firma Adı', firmaAdres AS 'Firma Adresi',firmaTelNo AS 'Telefon Numarası', firmaEposta AS 'E Posta ', urunBarkod AS 'Ürün Barkodu', urunCesidi AS 'Ürün Çeşidi', vergiNo AS 'Vergi No', isTelNo AS 'İş Telefon Numarası', temsilci AS 'Temsilci Ad Soyad' From firmaBilgi";
            //musteriler tablosundaki tüm kayıtları çekecek olan sql sorgusu.
            SqlCommand komut = new SqlCommand(kayit, baglanti);
            //Sorgumuzu ve baglantimizi parametre olarak alan bir SqlCommand nesnesi oluşturuyoruz.
            SqlDataAdapter da = new SqlDataAdapter(komut);
            //SqlDataAdapter sınıfı verilerin databaseden aktarılması işlemini gerçekleştirir.
            DataTable dt = new DataTable();
            da.Fill(dt);
            //Bir DataTable oluşturarak DataAdapter ile getirilen verileri tablo içerisine dolduruyoruz.
            firmaTablo.DataSource = dt;
            //Formumuzdaki DataGridViewin veri kaynağını oluşturduğumuz tablo olarak gösteriyoruz.
            baglanti.Close();

            firmaTablo.EnableHeadersVisualStyles = false;
            Color lacivert = ColorTranslator.FromHtml("#031A3D");
            firmaTablo.ColumnHeadersDefaultCellStyle.BackColor = lacivert;
            firmaTablo.Columns[9].DefaultCellStyle.BackColor = Color.Lavender;
            firmaTablo.Columns[8].DefaultCellStyle.BackColor = Color.Lavender;
            firmaTablo.Columns[7].DefaultCellStyle.BackColor = Color.Lavender;
            firmaTablo.Columns[6].DefaultCellStyle.BackColor = Color.Lavender;
            firmaTablo.Columns[5].DefaultCellStyle.BackColor = Color.Lavender;
            firmaTablo.Columns[4].DefaultCellStyle.BackColor = Color.Lavender;
            firmaTablo.Columns[3].DefaultCellStyle.BackColor = Color.Lavender;
            firmaTablo.Columns[2].DefaultCellStyle.BackColor = Color.Lavender;
            firmaTablo.Columns[1].DefaultCellStyle.BackColor = Color.Lavender;
            firmaTablo.Columns[0].DefaultCellStyle.BackColor = Color.Lavender;
            firmaTablo.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            firmaTablo.ColumnHeadersDefaultCellStyle.Font = new Font("tahoma", 11);
            firmaTablo.Columns[0].DefaultCellStyle.Font = new Font("Verdana", 10);
            firmaTablo.Columns[1].DefaultCellStyle.Font = new Font("Verdana", 10);
            firmaTablo.Columns[2].DefaultCellStyle.Font = new Font("Verdana", 10);
            firmaTablo.Columns[3].DefaultCellStyle.Font = new Font("Verdana", 10);
            firmaTablo.Columns[4].DefaultCellStyle.Font = new Font("Verdana", 10);
            firmaTablo.Columns[5].DefaultCellStyle.Font = new Font("Verdana", 10);
            firmaTablo.Columns[6].DefaultCellStyle.Font = new Font("Verdana", 10);
            firmaTablo.Columns[7].DefaultCellStyle.Font = new Font("Verdana", 10);
            firmaTablo.Columns[8].DefaultCellStyle.Font = new Font("Verdana", 10);
            firmaTablo.Columns[9].DefaultCellStyle.Font = new Font("Verdana", 10);
        }
        public void firmaStokla()
        {

            baglanti.Open();
            string kayit2 = "INSERT INTO firmaStok( urunCesidi, urunBarkod, urunBoyutu, urunAdedi) VALUES ('" + urunCesidi.Text + "','" + urunBarkodu.Text + "', '0', '0')";
            SqlCommand komut2 = new SqlCommand(kayit2, baglanti);
            komut2.ExecuteNonQuery();
            baglanti.Close();
        }
        private void FirmalarKontrol_Load(object sender, EventArgs e)
        {
            kayitGetir();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void firmaTablo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ekleBtn3_Click(object sender, EventArgs e)
        {
            if (firmaTelNo.TextLength == 11)
            {
                if (firmaTel.TextLength == 11)
                {
                    if (firmaEposta.Text != "" && temsilciAdSoyad.Text != "" && firmaAd.Text != "" && firmaTelNo.Text != ""
                     && urunBarkodu.Text != "" && urunCesidi.Text != "" && firmaTel.Text != "" &&
                     firmaVergiNo.Text != "" && firmaAdres.Text != "")
                    {
                        baglanti.Open();
                        string kayit = "INSERT INTO firmaBilgi(firmaAd, firmaAdres, firmaTelNo , firmaEposta, urunBarkod, urunCesidi, vergiNo, isTelNo, temsilci) VALUES ('" + firmaAd.Text + "', '" + firmaAdres.Text + "','" + firmaTelNo.Text + "','" + firmaEposta.Text + "','" + urunBarkodu.Text + "','" + urunCesidi.Text + "','" + firmaVergiNo.Text + "', '" + firmaTel.Text + "', '" + temsilciAdSoyad.Text + "' )";
                        SqlCommand komut = new SqlCommand(kayit, baglanti);
                        komut.ExecuteNonQuery();
                        

                        baglanti.Close();
                        lblmesaj.Visible = true;
                        lblmesaj.ForeColor = Color.Green;
                        lblmesaj.Text = "Başarıyla Kaydedildi";
                        kayitGetir();
                        firmaStokla();
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
                    lblmesaj.Text = "Lütfen 11 haneli telefon numarası giriniz!";
                }
            }
            else
            {
                lblmesaj.Visible = true;
                lblmesaj.ForeColor = Color.Red;
                lblmesaj.Text = "Lütfen 11 haneli telefon numarası giriniz!";
            }
        }

        private void buton4_Click(object sender, EventArgs e)
        {

            if (firmaTelNo.TextLength == 11)
            {
                if (firmaTel.TextLength == 11)
                {
                    if (firmaEposta.Text != "" && temsilciAdSoyad.Text != "" && firmaAd.Text != "" && firmaTelNo.Text != ""
                     && urunBarkodu.Text != "" && urunCesidi.Text != "" && firmaTel.Text != "" &&
                     firmaVergiNo.Text != "" && firmaAdres.Text != "")
                     {
                        string ID = urunBarkodu.Text;
                        //personel bilgilerinde güncelleme
                        if (!string.IsNullOrEmpty(ID)) // ID'nin Boş olup olmadığının kontrolü
                        {
                            string sql = "update firmaBilgi set firmaAd = '" + firmaAd.Text + "',firmaAdres = '" + firmaAdres.Text + "', firmaTelNo = '" + firmaTelNo.Text + "', firmaEposta = '" + firmaEposta.Text + "', urunBarkod = '" + urunBarkodu.Text + "', urunCesidi = '" + urunCesidi.Text + "' ,vergiNo = '" + firmaVergiNo.Text + "',isTelNo = '" + firmaTel.Text + "',  temsilci = '"+ temsilciAdSoyad.Text + "' where urunBarkod = '" + ID + "' ";
                            SqlCommand komut = new SqlCommand(sql, baglanti);

                            if (baglanti.State != ConnectionState.Open) // bağlantı açık değilse açtırıyoruz.
                            {
                                baglanti.Open();
                            }
                            komut.ExecuteNonQuery(); // sql sorgusunu işleme koyuyoruz.
                            baglanti.Close(); // bağlantıyı kapatıyoruz
                            kayitGetir();
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
                    lblmesaj.Text = "Lütfen 11 haneli telefon numarası giriniz!";
                }
            }
            else
            {
                lblmesaj.Visible = true;
                lblmesaj.ForeColor = Color.Red;
                lblmesaj.Text = "Lütfen 11 haneli telefon numarası giriniz!";
            }
        }

        private void firmaTablo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            firmaAd.Text = firmaTablo.Rows[e.RowIndex].Cells[1].Value.ToString();
            firmaAdres.Text = firmaTablo.Rows[e.RowIndex].Cells[2].Value.ToString();
            firmaTelNo.Text = firmaTablo.Rows[e.RowIndex].Cells[3].Value.ToString();
            firmaEposta.Text = firmaTablo.Rows[e.RowIndex].Cells[4].Value.ToString();
            urunBarkodu.Text = firmaTablo.Rows[e.RowIndex].Cells[5].Value.ToString();
            urunCesidi.Text = firmaTablo.Rows[e.RowIndex].Cells[6].Value.ToString();
            firmaVergiNo.Text = firmaTablo.Rows[e.RowIndex].Cells[7].Value.ToString();
            firmaTel.Text = firmaTablo.Rows[e.RowIndex].Cells[8].Value.ToString();
            temsilciAdSoyad.Text = firmaTablo.Rows[e.RowIndex].Cells[9].Value.ToString();
        }
        void KayıtSil(string numara)
        {
            string sql = "DELETE FROM firmaBilgi WHERE firmaID=@yeni";
            komut = new SqlCommand(sql, baglanti);
            komut.Parameters.AddWithValue("@yeni", numara);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
        }
        private void silButonPersonel_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow drow in firmaTablo.SelectedRows)  //Seçili Satırları Silme
            {
                string numara = Convert.ToString(drow.Cells[0].Value);
                KayıtSil(numara);
                lblmesaj.Visible = true;
                lblmesaj.ForeColor = Color.Green;
                lblmesaj.Text = "Başarıyla Silindi";
            }
            kayitGetir();
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
            YöneticiMain yoneticiMain = new YöneticiMain();
            yoneticiMain.Show();
            this.Close();
        }
    }
}

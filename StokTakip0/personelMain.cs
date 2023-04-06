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
    public partial class personelMain : Form
    {
        public personelMain()
        {
            InitializeComponent();
        }

      

        private void picGeri_Click(object sender, EventArgs e)
        {
            personelGiris anasayfa = new personelGiris();
            anasayfa.Show();
            this.Close();
        }

        private void picMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized; //ekranda sağ üstte eksi butonuna basınca ekranı alt sekmeye alma kodu
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit(); //ekranda sağ üstteki çarpı butonuna basınca ekranı kapatma kodu
        }

      

        private void button1_Click_1(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection();  //sql bağlantısını sağlayan con nesnesini oluşturur
            con.ConnectionString = "Data Source=DESKTOP-SN77AA1;Initial Catalog=stokTakip;Integrated Security=True";  //con nesnesine bağlantı linkini atar

            SqlCommand cmd = new SqlCommand(); // cmd isimli sql komut nesnesini oluşturur
            cmd.Connection = con;  //cmd nesnesini ve con nesnesini birbirine bağlar

            //Ürün ID textbox'ına girilen sayıyı veritabanından çeker
            cmd.CommandText = "SELECT * FROM firmaStok where urunBarkod = '" + urunID.Text + "'";
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);

            if (DS.Tables[0].Rows.Count != 0) //girilen ürün ID numarası veritabanına kayıtlıysa if yapısının içine girer
            {
                SqlCommand cmd2 = new SqlCommand(); //cmd2 adlı yeni bir komut nesnesini oluşturur
                cmd2.Connection = con;  //yukarıdaki sql bağlantı nesnesi cona cmd2 komutunu bağlar

                //cmd2 komutuyla yeni bir komut oluşturulur
                cmd2.CommandText = "SELECT urunCesidi AS 'Ürün', urunBoyutu AS 'Beden', urunAdedi AS 'Stok Durumu' FROM firmaStok WHERE urunBarkod = '" + urunID.Text + "'";
                //komuttan gelen veriler datagriedview'a aktarılır
                SqlDataAdapter DA2 = new SqlDataAdapter(cmd2);
                DataSet DS2 = new DataSet();
                DA2.Fill(DS2);

                stokDurumuTablo.DataSource = DS2.Tables[0]; // stokdurumu tablosundaki 0. indeksteki değeri yani ürün çeşidini çeker

                //datagriedviewa kullanıcının manuel veri eklemesini engeller
                stokDurumuTablo.AllowUserToAddRows = false; 

                stokDurumuTablo.EnableHeadersVisualStyles = false;
                Color lacivert = ColorTranslator.FromHtml("#031A3D");
                stokDurumuTablo.ColumnHeadersDefaultCellStyle.BackColor = lacivert;
                stokDurumuTablo.Columns[0].DefaultCellStyle.BackColor = Color.Lavender;
                stokDurumuTablo.Columns[1].DefaultCellStyle.BackColor = Color.Lavender;
                stokDurumuTablo.Columns[2].DefaultCellStyle.BackColor = Color.Lavender;
                stokDurumuTablo.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

                stokDurumuTablo.ColumnHeadersDefaultCellStyle.Font = new Font("tahoma", 11);
                stokDurumuTablo.Columns[0].DefaultCellStyle.Font = new Font("Verdana", 10);
                stokDurumuTablo.Columns[1].DefaultCellStyle.Font = new Font("Verdana", 10);
                stokDurumuTablo.Columns[2].DefaultCellStyle.Font = new Font("Verdana", 10);

                urunCesidi.Text = DS2.Tables[0].Rows[0][0].ToString(); // yukarıda çektiğimiz 0. indeks değerini urunCesidi textbox'ına aktarır otomatik olarak aktarır
            }
            else
            {
                //uyarı mesajı oluşturur
                MessageBox.Show("Lütfen sistemde bulunan bir ID numarası giriniz", "Uyarı", MessageBoxButtons.OK);
            }
        }

        private void stokDurumuTablo_CellFormatting_1(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //datagriedview'daki 2. indekste bulunan değere yani ürün miktarının değerine göre cell'i kırmızı veya sarı yapar
            if (e.ColumnIndex == 2 & e.Value != null)
            {
                int sum1 = Convert.ToInt32(e.Value);
                //ürün miktarı 20'nin altındaysa cell'i kırmızı yapar
                if (sum1 < 20) 
                    e.CellStyle.BackColor = Color.Red;
                //ürün miktarı 20 ve 30 arasındaysa cell'i sarı yapar
                else if (sum1 >= 20 & sum1 < 30)
                    e.CellStyle.BackColor = Color.Yellow;
            }
        }

    
        private void onayButonu_Click(object sender, EventArgs e)
        {
            String talepTarih = talepTarihi.Text; // tarihi datetimepicker'dan çekebilmek için string tipinde nesnesini oluşturur
            String onayDrm = "Onaylanmadı";
            if(urunID.Text == "" || urunBoyutu.Text=="" || urunAdedi.Text == "") // ürün ID, boyut, adet değerleri boşsa if yapısının içine girer
            {
                onayButonu.BackColor = Color.Red; // butonu kırmızı yapar
            }
            else //değerler doluysa else yapısına geçer
            {
                onayButonu.BackColor = Color.Green; //Butonu yeşil yapar 

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=DESKTOP-SN77AA1;Initial Catalog=stokTakip;Integrated Security=True";
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                //veritabanına değer ekler
                cmd.CommandText = "INSERT INTO talepStok(urunBarkodu, urunCesidi, urunAdedi, urunBoyutu, talepTarihi, onayDurum) VALUES('" + urunID.Text + "', '" + urunCesidi.Text + "', '" + urunAdedi.Text + "', '"+urunBoyutu.Text+ "',  '" + talepTarih + "', '"+onayDrm+"')";
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        private void personelMain_Load(object sender, EventArgs e)
        {

        }
    }
}

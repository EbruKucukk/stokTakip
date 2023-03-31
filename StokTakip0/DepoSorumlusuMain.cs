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
    public partial class DepoSorumlusuMain : Form
    {
        public DepoSorumlusuMain()
        {
            InitializeComponent();
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
        private void DepoSorumlusuMain_Load(object sender, EventArgs e)
        {
            logoPicture.Visible = true;
            urunCesidi.Text = "";
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-SN77AA1;Initial Catalog=stokTakip;Integrated Security=True");  //sql bağlantısını sağlayan con nesnesini oluşturur
            SqlCommand cmd = new SqlCommand(); // cmd isimli sql komut nesnesini oluşturur
            cmd.Connection = con;  //cmd nesnesini ve con nesnesini birbirine bağlar

            //Ürün ID textbox'ına girilen sayıyı veritabanından çeker
            cmd.CommandText = "SELECT urunCesidi AS 'Ürün Çeşidi', urunBarkodu AS 'Ürün Barkodu', urunBoyutu AS 'Ürün Bedeni', urunAdedi AS 'Talep Miktarı', talepTarihi AS 'Talep Tarihi', onayDurum AS 'Onay Durumu', stoklamaDurum AS 'Stokla' FROM talepStok WHERE onayDurum = 'Onaylanmadı'";
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);

            talepTablo.DataSource = DS.Tables[0];
            talepTablo.AllowUserToAddRows = false;

            //datagridviewun görsel ayarları için kod satırları
            talepTablo.EnableHeadersVisualStyles = false;
            Color lacivert = ColorTranslator.FromHtml("#031A3D");
            talepTablo.ColumnHeadersDefaultCellStyle.BackColor = lacivert;
            talepTablo.Columns[6].DefaultCellStyle.BackColor = Color.Lavender;
            talepTablo.Columns[5].DefaultCellStyle.BackColor = Color.Teal;
            talepTablo.Columns[4].DefaultCellStyle.BackColor = Color.Snow;
            talepTablo.Columns[3].DefaultCellStyle.BackColor = Color.Snow;
            talepTablo.Columns[2].DefaultCellStyle.BackColor = Color.Snow;
            talepTablo.Columns[1].DefaultCellStyle.BackColor = Color.Snow;
            talepTablo.Columns[0].DefaultCellStyle.BackColor = Color.Snow;
            talepTablo.Columns[5].DefaultCellStyle.ForeColor = Color.White;
            talepTablo.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            talepTablo.ColumnHeadersDefaultCellStyle.Font = new Font("tahoma", 13);
            talepTablo.Columns[0].DefaultCellStyle.Font = new Font("Verdana", 10);
            talepTablo.Columns[1].DefaultCellStyle.Font = new Font("Verdana", 10);
            talepTablo.Columns[2].DefaultCellStyle.Font = new Font("Verdana", 10);
            talepTablo.Columns[3].DefaultCellStyle.Font = new Font("Verdana", 10);
            talepTablo.Columns[4].DefaultCellStyle.Font = new Font("Verdana", 8);
            talepTablo.Columns[0].DefaultCellStyle.Font = new Font("Verdana", 10);
            talepTablo.Columns[5].DefaultCellStyle.Font = new Font("Verdana", 8);


            SqlCommand cmd2 = new SqlCommand(); // cmd isimli sql komut nesnesini oluşturur
            cmd2.Connection = con;  //cmd nesnesini ve con nesnesini birbirine bağlar

            //Ürün ID textbox'ına girilen sayıyı veritabanından çeker
            cmd2.CommandText = "SELECT urunCesidi AS 'Ürün Çeşidi', urunBarkodu AS 'Ürün Barkodu', urunBoyutu AS 'Ürün Bedeni', urunAdedi AS 'Talep Miktarı', talepTarihi AS 'Talep Tarihi', onayDurum AS 'Onay Durumu', stoklamaDurum AS 'Stokla' FROM talepStok WHERE onayDurum = 'Onaylandı'";
            SqlDataAdapter DA2 = new SqlDataAdapter(cmd2);
            DataSet DS2 = new DataSet();
            DA2.Fill(DS2);

            onayTablo.DataSource = DS2.Tables[0];
            onayTablo.AllowUserToAddRows = false;

            //2. datagridvievwun görsel ayarları için kod satırları
            onayTablo.EnableHeadersVisualStyles = false;
            onayTablo.ColumnHeadersDefaultCellStyle.BackColor = lacivert;
            onayTablo.Columns[6].DefaultCellStyle.BackColor = Color.Lavender;
            onayTablo.Columns[5].DefaultCellStyle.BackColor = Color.Teal;
            onayTablo.Columns[4].DefaultCellStyle.BackColor = Color.Snow;
            onayTablo.Columns[3].DefaultCellStyle.BackColor = Color.Snow;
            onayTablo.Columns[2].DefaultCellStyle.BackColor = Color.Snow;
            onayTablo.Columns[1].DefaultCellStyle.BackColor = Color.Snow;
            onayTablo.Columns[0].DefaultCellStyle.BackColor = Color.Snow;
            onayTablo.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            onayTablo.Columns[5].DefaultCellStyle.ForeColor = Color.White;

            onayTablo.ColumnHeadersDefaultCellStyle.Font = new Font("tahoma", 13);
            onayTablo.Columns[0].DefaultCellStyle.Font = new Font("Verdana", 10);
            onayTablo.Columns[1].DefaultCellStyle.Font = new Font("Verdana", 10);
            onayTablo.Columns[2].DefaultCellStyle.Font = new Font("Verdana", 10);
            onayTablo.Columns[3].DefaultCellStyle.Font = new Font("Verdana", 10);
            onayTablo.Columns[4].DefaultCellStyle.Font = new Font("Verdana", 8);
            onayTablo.Columns[0].DefaultCellStyle.Font = new Font("Verdana", 10);
        }

        private void talepTablo_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

        }

        private void firmaButon_Click(object sender, EventArgs e)
        {
            //onayla butonuna bastığımızda aşağıdaki kodu döndürürüz ve istenilen stok artık onaylanmış olur
            //yani database verileri update'lenir

            //Onaylandı yazısını veritabanına aktarmak için onay nesnesi oluşturulur
            string onay = "Onaylandı";
            //True değerini veritabanında stoklama durumuna atıp seçili yapmak için içine 1 atılan secili nesnesi oluşturulur
            int secili = 1;

            SqlConnection con = new SqlConnection("Data Source=DESKTOP-SN77AA1;Initial Catalog=stokTakip;Integrated Security=True");  //sql bağlantısını sağlayan con nesnesini oluşturur
            SqlCommand cmd = new SqlCommand(); // cmd isimli sql komut nesnesini oluşturur
            cmd.Connection = con;  //cmd nesnesini ve con nesnesini birbirine bağlar
            con.Open();
            //Ürün ID textbox'ına girilen sayıyı veritabanından çeker

            //AND talepTarihi = '"+tarih.Text+"' burası sonra sql sorgusuna katmak için

            ////bilgileri kutuda yazan ürün değerleri için onay durumuna Onaylandı yazdıran ve stok durumunu true yani seçili yapan kod
            cmd.CommandText = "UPDATE talepStok SET OnayDurum = @OnayDurumu, stoklamaDurum = @stokDurumu WHERE urunCesidi = '" + urunCesidi.Text + "' AND urunBarkodu = '" + urunID.Text + "' AND urunBoyutu = '" + urunBoyutu.Text + "' AND urunAdedi = '" + urunAdedi.Text + "' ";
            cmd.Parameters.AddWithValue("@OnayDurumu", onay);
            cmd.Parameters.AddWithValue("@stokDurumu", secili);
            cmd.ExecuteNonQuery();
            con.Close();

            lblmesaj.Visible = true;
            lblmesaj.ForeColor = Color.Green;
            lblmesaj.Text = "Stok Onaylandı!";
        }
        private void talepTablo_CellValueChanged_1(object sender, DataGridViewCellEventArgs e)
        {
            var columnIndex = 6;
            if (e.ColumnIndex == columnIndex)
            {
               //datagridviewda 6. satır yani stoklama durumu seçildiğinde 'true' olduğunda kutucukları ve sipariş onaylama butonlarını görünür hale getirir
                var isChecked = (bool)talepTablo.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                if (isChecked)
                {
                    firmaButon.Visible = true;
                    urunAdediTxt.Visible = true;
                    urunAdedi.Visible = true;
                    urunCesidiTxt.Visible = true;
                    urunCesidi.Visible = true;
                    urunBoyutuTxt.Visible = true;
                    urunBoyutu.Visible = true;
                    logoPicture.Visible = false;
                    iptalBtn.Visible = true;
                    panel1.Visible = true;
                    panel2.Visible = true;
                    panel3.Visible = true;
                }
            }
        }

        private void talepTablo_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 6)
            {
                // eğer 6. satırdaki stok durumu kutucuklarından biri seçiliyse yani ture ise diğerlerini false yani boş yapar
                //bu sayede girişte aynı anda birkaç ürün seçili gözükmez
                foreach (DataGridViewRow row in talepTablo.Rows)
                {
                    if (row.Index == e.RowIndex)
                    {
                        row.Cells[6].Value = !Convert.ToBoolean(row.Cells[6].EditedFormattedValue);
                    }
                    else
                    {
                        row.Cells[6].Value = false;
                    }
                }

                //kutucuğunu seçtiğimiz satırdaki değerleri otomatik olarak veritabanından aşağıdaki sipariş onaylama formuna aktarır
                if (talepTablo.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    talepTablo.CurrentRow.Cells[6].Selected = true;
                    urunCesidi.Text = talepTablo.Rows[e.RowIndex].Cells[0].Value.ToString();
                    urunBoyutu.Text = talepTablo.Rows[e.RowIndex].Cells[2].Value.ToString();
                    urunAdedi.Text = talepTablo.Rows[e.RowIndex].Cells[3].Value.ToString();
                    urunID.Text = talepTablo.Rows[e.RowIndex].Cells[1].Value.ToString();
                    tarih.Text = talepTablo.Rows[e.RowIndex].Cells[4].Value.ToString();
                }
            }
        }

        private void güncelleBtn_Click(object sender, EventArgs e)
        {
            //güncelle butonuna bastığımızda onaylamış olduğumuz ürünler 2. datagridviewda görünür

            SqlConnection con = new SqlConnection("Data Source=DESKTOP-SN77AA1;Initial Catalog=stokTakip;Integrated Security=True");
            SqlCommand cmd = new SqlCommand(); // cmd isimli sql komut nesnesini oluşturur
            cmd.Connection = con;  //cmd nesnesini ve con nesnesini birbirine bağlar

            //Ürün ID textbox'ına girilen sayıyı veritabanından çeker
            cmd.CommandText = "SELECT urunCesidi AS 'Ürün Çeşidi', urunBoyutu AS 'Ürün Bedeni',urunBarkodu AS 'Ürün Barkodu', urunAdedi AS 'Talep Miktarı', onayDurum AS 'Onay Durumu', stoklamaDurum AS 'Stokla', talepTarihi AS 'Talep Tarihi' FROM talepStok WHERE onayDurum = 'Onaylandı'";
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);

            onayTablo.DataSource = DS.Tables[0];
            onayTablo.AllowUserToAddRows = false;

            SqlCommand cmd2 = new SqlCommand(); // cmd isimli sql komut nesnesini oluşturur
            cmd2.Connection = con;  //cmd nesnesini ve con nesnesini birbirine bağlar

            //Ürün ID textbox'ına girilen sayıyı veritabanından çeker
            cmd2.CommandText = "SELECT urunCesidi AS 'Ürün Çeşidi', urunBoyutu AS 'Ürün Bedeni',urunBarkodu AS 'Ürün Barkodu', urunAdedi AS 'Talep Miktarı', onayDurum AS 'Onay Durumu', stoklamaDurum AS 'Stokla', talepTarihi AS 'Talep Tarihi' FROM talepStok WHERE onayDurum = 'Onaylanmadı'";
            SqlDataAdapter DA2 = new SqlDataAdapter(cmd2);
            DataSet DS2 = new DataSet();
            DA2.Fill(DS2);

            talepTablo.DataSource = DS2.Tables[0];
            talepTablo.AllowUserToAddRows = false;
        }

        private void onayTablo_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void onayTablo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var columnIndex = 6;
            if (e.ColumnIndex == columnIndex)
            {
                //2. datagridviewda 6. satır yani stoklama durumu seçildiğinde 'true' olduğunda kutucukları ve sipariş onaylama butonlarını görünür hale getirir
                var isChecked = (bool)onayTablo.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                if (isChecked)
                {
                    firmaButon.Visible = true;
                    urunAdediTxt.Visible = true;
                    urunAdedi.Visible = true;
                    urunCesidiTxt.Visible = true;
                    urunCesidi.Visible = true;
                    urunBoyutuTxt.Visible = true;
                    urunBoyutu.Visible = true;
                    logoPicture.Visible = false;
                    iptalBtn.Visible = true;
                    panel1.Visible = true;
                    panel2.Visible = true;
                    panel3.Visible = true;
                }
            }
            if (e.RowIndex >= 0 && e.ColumnIndex == 6)
            {
                // eğer 2. datagridviewda 4. satırdaki stok durumu kutucuklarından biri seçiliyse yani ture ise diğerlerini false yani boş yapar
                //bu sayede girişte aynı anda birkaç ürün seçili gözükmez
                foreach (DataGridViewRow row in onayTablo.Rows)
                {
                    if (row.Index == e.RowIndex)
                    {
                        row.Cells[6].Value = !Convert.ToBoolean(row.Cells[6].EditedFormattedValue);
                    }
                    else
                    {
                        row.Cells[6].Value = false;
                    }
                }
                //2. datagridview için kutucuğunu seçtiğimiz satırdaki değerleri otomatik olarak veritabanından aşağıdaki sipariş onaylama formuna aktarır
                if (onayTablo.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    onayTablo.CurrentRow.Cells[6].Selected = true;
                    urunCesidi.Text = onayTablo.Rows[e.RowIndex].Cells[0].Value.ToString();
                    urunBoyutu.Text = onayTablo.Rows[e.RowIndex].Cells[2].Value.ToString();
                    urunAdedi.Text = onayTablo.Rows[e.RowIndex].Cells[3].Value.ToString();
                    urunID.Text = onayTablo.Rows[e.RowIndex].Cells[1].Value.ToString();
                    tarih.Text = onayTablo.Rows[e.RowIndex].Cells[4].Value.ToString();
                }
            }
        }

        private void tarih_TextChanged(object sender, EventArgs e)
        {

        }

        private void iptalBtn_Click(object sender, EventArgs e)
        {
            //onayla butonuna bastığımızda aşağıdaki kodu döndürürüz ve istenilen stok artık onaylanmış olur
            //yani database verileri update'lenir

            //Onaylandı yazısını veritabanına aktarmak için onay nesnesi oluşturulur
            string onay2 = "Onaylanmadı";
            //True değerini veritabanında stoklama durumuna atıp seçili yapmak için içine 1 atılan secili nesnesi oluşturulur
            int secili2 = 0;

            SqlConnection con = new SqlConnection("Data Source=DESKTOP-SN77AA1;Initial Catalog=stokTakip;Integrated Security=True");  //sql bağlantısını sağlayan con nesnesini oluşturur
            SqlCommand cmd = new SqlCommand(); // cmd isimli sql komut nesnesini oluşturur
            cmd.Connection = con;  //cmd nesnesini ve con nesnesini birbirine bağlar
            con.Open();
            //Ürün ID textbox'ına girilen sayıyı veritabanından çeker

            //AND talepTarihi = '"+tarih.Text+"' burası sonra sql sorgusuna katmak için

            ////bilgileri kutuda yazan ürün değerleri için onay durumuna Onaylandı yazdıran ve stok durumunu true yani seçili yapan kod
            cmd.CommandText = "UPDATE talepStok SET OnayDurum = @OnayDurumu, stoklamaDurum = @stokDurumu WHERE urunCesidi = '" + urunCesidi.Text + "' AND urunBarkodu = '" + urunID.Text + "' AND urunBoyutu = '" + urunBoyutu.Text + "' AND urunAdedi = '" + urunAdedi.Text + "' ";
            cmd.Parameters.AddWithValue("@OnayDurumu", onay2);
            cmd.Parameters.AddWithValue("@stokDurumu", secili2);
            cmd.ExecuteNonQuery();
            con.Close();

            lblmesaj.Visible = true;
            lblmesaj.ForeColor = Color.Green;
            lblmesaj.Text = "İptal Edildi";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

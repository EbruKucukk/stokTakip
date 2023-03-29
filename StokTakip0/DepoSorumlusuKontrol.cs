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

        private void DepoSorumlusuKontrol_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(); //sql bağlantısını sağlayan con nesnesini oluşturur
            con.ConnectionString = "Data Source=DESKTOP-SN77AA1;Initial Catalog=stokTakip;Integrated Security=True";  //con nesnesine bağlantı linkini atar
            SqlCommand cmd = new SqlCommand(); // cmd isimli sql komut nesnesini oluşturur

            cmd.Connection = con;  //cmd nesnesini ve con nesnesini birbirine bağlar
            con.Open(); //sql bağlantısını açar


            //depo sorumlularının listesini database'den tabloya aktaran sql komutu
            cmd.CommandText = "SELECT depoSorumlusuAd AS 'İsim', depoSorumlusuSoyad AS 'Soyad', depoSorumlusuEposta AS 'E-Posta', depoSorumlusuTelNo AS 'Telefon Bilgisi', depoSorumlusuSifre AS 'Şifre Bilgisi', depoSorumlusuAdres AS 'Adres Bilgisi' FROM depoSorumlusu";
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);

            depoSorumlusuTablo.DataSource = DS.Tables[0];

            depoSorumlusuTablo.AllowUserToAddRows = false; //datagriedviewa kullanıcının manuel veri eklemesini engeller
        }

        private void picGeri_Click(object sender, EventArgs e)
        {
            //geri gitme butonu
            YöneticiMain yoneticiMain = new YöneticiMain();
            yoneticiMain.Show();
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
    }
}

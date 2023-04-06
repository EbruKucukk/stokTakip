using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StokTakip0
{
    public partial class YöneticiMain : Form
    {
        public YöneticiMain()
        {
            InitializeComponent();
        }

        private void YöneticiMain_Load(object sender, EventArgs e)
        {

        }

        private void picGeri_Click(object sender, EventArgs e)
        {
            //ekranda sol üstteki geri butonuna basınca bir önceki sayfaya dönme kodu
            YöneticiGiris anasayfa = new YöneticiGiris();
            anasayfa.Show();
            this.Close();
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit(); //ekranda sağ üstteki çarpı butonuna basınca ekranı kapatma kodu
        }

        private void picMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized; //ekranda sağ üstte eksi butonuna basınca ekranı alt sekmeye alma kodu
        }

        private void depoButon_Click(object sender, EventArgs e)
        {
            DepoSorumlusuKontrol depogiris = new DepoSorumlusuKontrol();
            depogiris.Show();
            this.Close();
        }

        private void firmaButon_Click(object sender, EventArgs e)
        {
            FirmalarKontrol firmaKntrl = new FirmalarKontrol();
            firmaKntrl.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}

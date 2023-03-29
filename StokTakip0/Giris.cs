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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void picClose_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit(); //ekranda sağ üstteki çarpı butonuna basınca ekranı kapatma kodu
        }

        private void picMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized; //ekranda sağ üstte eksi butonuna basınca ekranı alt sekmeye alma kodu
        }

        private void lblDepoSorumlusu_Click(object sender, EventArgs e)
        {
            DepoSorumlusuGiris depoSorumlusuGiris = new DepoSorumlusuGiris();
            depoSorumlusuGiris.Show();
            this.Hide();
        }

        private void lblYöneticiGiris_Click(object sender, EventArgs e)
        {
            YöneticiGiris yöneticiGiris = new YöneticiGiris();
            yöneticiGiris.Show();
            this.Hide();
        }

        private void lblPersonelGiris_Click(object sender, EventArgs e)
        {

        }

        private void lblDepoSorumlusu_MouseHover(object sender, EventArgs e)
        {

        }

        private void lblDepoSorumlusu_MouseLeave(object sender, EventArgs e)
        {

        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            personelGiris personelGiris = new personelGiris();
            personelGiris.Show();
            this.Hide();
        }
    }
}

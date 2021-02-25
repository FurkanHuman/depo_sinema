using System;
using System.Windows.Forms;

namespace depo_sinema
{
    public partial class ana_menu : Form
    {
        public ana_menu()
        {
            InitializeComponent();
        }

        private void Ana_menu_Load(object sender, EventArgs e)
        {
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Ekle x = new Ekle();
            x.ShowDialog();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Goster x = new Goster();
            x.ShowDialog();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Duzenle x = new Duzenle();
            x.ShowDialog();
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hakkinda x = new Hakkinda();
            x.ShowDialog();
        }
        
    }
}
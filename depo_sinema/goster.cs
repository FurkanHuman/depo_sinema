using System;
using System.Windows.Forms;

namespace depo_sinema
{
    public partial class Goster : Form
    {
        public Goster()
        {
            InitializeComponent();
        }

        private void Goster_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'depoDataSet.s_depo' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.s_depoTableAdapter.Fill(this.depoDataSet.s_depo);
            dataGridView1.Refresh();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
using System;
using System.Windows.Forms;
using System.Data.OleDb;

namespace depo_sinema
{
    public partial class Duzenle : Form
    {
        public Duzenle()
        {
            InitializeComponent();
        }

        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0; Data Source=depo.accdb");
        OleDbCommand komut;
        public static OleDbDataReader rd;
        
        private void Sil()
        {
            int yhu = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            komut = new OleDbCommand();
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = "delete from s_depo Where sira=@pno ";
            komut.Parameters.AddWithValue("@pno", yhu);
            komut.ExecuteNonQuery();
            baglanti.Close();
            this.s_depoTableAdapter.Fill(this.depoDataSet.s_depo);
            dataGridView1.Refresh();
        }
        private void Guncelle()
        {
            int yhu = Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            komut = new OleDbCommand();
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = "select * from s_depo";
            rd = komut.ExecuteReader();
            Duzenlekran duzenlekran = new Duzenlekran();
            duzenlekran.ShowDialog();
            baglanti.Close();
        }


        private void Duzenle_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'depoDataSet.s_depo' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.s_depoTableAdapter.Fill(this.depoDataSet.s_depo);
            dataGridView1.Refresh();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
             Close();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                Sil();
            }
            catch
            {
                MessageBox.Show("Hata");
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            try
            {
                Guncelle();
            }
            catch
            {
                MessageBox.Show("Hata");
            }
        }
    }
}
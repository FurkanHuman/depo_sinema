using System;
using System.Windows.Forms;
using System.Data.OleDb;

namespace depo_sinema
{
    public partial class Ekle : Form
    {
        public Ekle()
        {
            InitializeComponent();
        }

        // Değişkenler

        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0; Data Source=depo.accdb");
        OleDbCommand komut;
        string faditr, fadien = "-", seri, secilenveri = "", fturu, fyapimcis, fyapimci, fyonetmen, fkonu;
        double imdb, kfilm, sure;

     

        DateTime fyapimyili = new DateTime(), fyuklemet = new DateTime(), kayit_t = new DateTime();

        private void Girdi()
        {
            faditr = textBox1.Text;

            if (checkBox1.Checked == true)
                fadien = textBox2.Text;
            else if (checkBox1.Checked == false)
                fadien = "-";

            fyapimyili = Convert.ToDateTime(maskedTextBox1.Text);

            if (radioButton1.Checked == true)
            {
                kfilm = Convert.ToDouble(maskedTextBox2.Text);
                seri = "Evet";
            }

            else if (radioButton2.Checked == true)
                seri = "Hayır";

            imdb = Convert.ToDouble(maskedTextBox3.Text);
            sure = Convert.ToDouble(maskedTextBox4.Text);

            for (int i = 0; i < checkedListBox1.CheckedItems.Count; i++)
            {
                secilenveri += checkedListBox1.CheckedItems[i].ToString() + " / ";
            }

            fturu = secilenveri;
            fyapimcis = textBox3.Text;
            fyapimci = textBox4.Text;
            fyonetmen = textBox5.Text;
            fyuklemet = Convert.ToDateTime(maskedTextBox5.Text);
            fkonu = Convert.ToString(richTextBox1.Text);
            label15.Text = DateTime.Now.ToString();
            kayit_t = Convert.ToDateTime(label15.Text);
        }
        private void Cikti()
        {
            komut = new OleDbCommand();
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = "insert into s_depo (f_adi_tr,f_adi_en,f_yapim_yili,seri,kacinci_f,f_imdb_puani,f_suresi,f_turu,f_yapimci_s,f_yapimcisi,f_yonetmeni,f_yukleme_tarih,f_konusu,f_kayit_tarih) values (@pAditr,@padien,@pyapimyili,@peri,@pkacf,@pimdb,@psure,@ptur,@pyapimcis,@pyapimci,@pyonet,@pyukt,@pkonu,@pkayt)";

            komut.Parameters.AddWithValue("@pAditr", faditr);
            komut.Parameters.AddWithValue("@padien", fadien); 
            komut.Parameters.AddWithValue("@pyapimyili", fyapimyili); 
            komut.Parameters.AddWithValue("@peri", seri);
            komut.Parameters.AddWithValue("@pkacf", kfilm);
            komut.Parameters.AddWithValue("@pimdb", imdb); 
            komut.Parameters.AddWithValue("@psure", sure); 
            komut.Parameters.AddWithValue("@ptur", fturu);  
            komut.Parameters.AddWithValue("@pyapimcis", fyapimcis); 
            komut.Parameters.AddWithValue("@pyapimci", fyapimci); 
            komut.Parameters.AddWithValue("@pyonet", fyonetmen);
            komut.Parameters.AddWithValue("@pyukt", fyuklemet);
            komut.Parameters.AddWithValue("@pkonu", fkonu);
            komut.Parameters.AddWithValue("@pkayt", kayit_t);

            komut.ExecuteNonQuery();
            komut.Dispose();
            baglanti.Close();
        }
        
        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
                textBox2.Enabled = true;
            else if (checkBox1.Checked == false)
                textBox2.Enabled = false;           
        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
                maskedTextBox2.Enabled = true;
        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
                maskedTextBox2.Enabled = false;
        }

        private void Ekle_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                Girdi();
                Cikti();
            }
            catch
            {
                MessageBox.Show("Hata, Lütfen kontrol edin!!!");
            }
           // https://www.microsoft.com/en-US/download/details.aspx?id=39358
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            maskedTextBox5.Text = DateTime.Now.ToString();
        }
    }
}
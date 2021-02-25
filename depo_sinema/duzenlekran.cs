using System;
using System.Windows.Forms;
using System.Data.OleDb;

namespace depo_sinema
{
    public partial class Duzenlekran : Form
    {
        public Duzenlekran()
        {
            InitializeComponent();
        }

        // değişkenler 
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0; Data Source=depo.accdb");
        OleDbCommand komut;
        string adtr, aden = "-", serig, trer, tur, fyapimcis, fyapimci, yonetmen, fkonu;
        double f_kac, imdbg, sureg,xdp;
        DateTime yapimyilig =new DateTime(), fyuktarig=new DateTime(), kayit_t = new DateTime();
        
        //kapsülleme 
        private void Yukle()
        {
            while (Duzenle.rd.Read())
            {
                xdp = Convert.ToDouble(Duzenle.rd["sira"].ToString());
                textBox1.Text =Duzenle.rd["f_adi_tr"].ToString();
                textBox2.Text = Duzenle.rd["f_adi_en"].ToString();
                maskedTextBox1.Text = Duzenle.rd["f_yapim_yili"].ToString();
                serig = Duzenle.rd["seri"].ToString();
                trer = Duzenle.rd["f_turu"].ToString();
                maskedTextBox2.Text = Duzenle.rd["kacinci_f"].ToString();
                maskedTextBox3.Text = Duzenle.rd["f_imdb_puani"].ToString();
                maskedTextBox4.Text = Duzenle.rd["f_suresi"].ToString();
                textBox3.Text = Duzenle.rd["f_yapimci_s"].ToString();
                textBox4.Text = Duzenle.rd["f_yapimcisi"].ToString();
                textBox5.Text = Duzenle.rd["f_yonetmeni"].ToString();
                maskedTextBox5.Text = Duzenle.rd["f_yukleme_tarih"].ToString();
                richTextBox1.Text = Duzenle.rd["f_konusu"].ToString();                
            }
        }
        private void Secim()
        {

            if (serig == "Evet")
            {
                textBox4.Enabled = true;
                radioButton1.Checked = true;
            }

            else if (serig == "Hayır")
                radioButton2.Checked = true;

 
        }
        private void Girdi()
        {
            adtr = textBox1.Text;

            if (checkBox1.Checked == true)
                aden = textBox2.Text;
            else if (checkBox1.Checked == false)
                aden = "-";


            yapimyilig = Convert.ToDateTime(maskedTextBox1.Text);

            if (radioButton1.Checked == true)
            {
                f_kac = Convert.ToDouble(maskedTextBox2.Text);
                serig = "Evet";
            }

            else if (radioButton2.Checked == true)
                serig = "Hayır";
            

            imdbg = Convert.ToDouble(maskedTextBox3.Text);
            sureg = Convert.ToDouble(maskedTextBox4.Text);

            if (checkBox2.Checked == false)
            {
                string secilenveri = "-";

                for (int i = 0; i < checkedListBox1.CheckedItems.Count; i++)
                {
                    secilenveri += checkedListBox1.CheckedItems[i].ToString() + " / ";
                }

                tur = secilenveri;
            }

            else if (checkBox2.Checked == true)
            {
                tur = trer;
            }

            fyapimcis = textBox3.Text;
            fyapimci = textBox4.Text;
            yonetmen = textBox5.Text;
            fyuktarig = Convert.ToDateTime(maskedTextBox5.Text);
            fkonu = Convert.ToString(richTextBox1.Text);
            label15.Text = DateTime.Now.ToString();
            kayit_t = Convert.ToDateTime(label15.Text);
        }
        private void Cikti()
        {
            komut = new OleDbCommand();
            baglanti.Open();
            komut.Connection = baglanti;

            komut.CommandText = "UPDATE s_depo SET f_adi_tr='" + adtr + "', f_adi_en='" + aden + "', f_yapim_yili='" + yapimyilig + "' , seri='" + serig + "', kacinci_f='" + f_kac + "', f_imdb_puani='" + imdbg + "', f_suresi='" + sureg + "', f_turu='" + tur + "', f_yapimci_s='" + fyapimcis + "', f_yapimcisi='" + fyapimci + "', f_yonetmeni='" + yonetmen + "', f_yukleme_tarih='" + fyuktarig + "', f_konusu='" + fkonu + "', f_kayit_tarih='" + kayit_t + "' Where sira=" + xdp + "";
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void Duzenlekran_Load(object sender, EventArgs e)
        {
            try
            {
                Yukle();
                Secim();
            }
            catch
            {
                MessageBox.Show("Hata");
                Close();
            }
        }


        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
                textBox2.Enabled = true;
            else if (checkBox1.Checked == false)
                textBox2.Enabled = false;
        }

        private void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
                checkedListBox1.Enabled = false;
            else if (checkBox2.Checked == false)
                checkedListBox1.Enabled = true;
        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
                maskedTextBox2.Enabled = true;     
        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked==true)
                maskedTextBox2.Enabled = false;
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
                MessageBox.Show("Hata, Kontrol edin!!!");
            }
        }
    }
}
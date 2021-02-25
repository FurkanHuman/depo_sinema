using System;
using System.Windows.Forms;

namespace depo_sinema
{
    public partial class Kapat : Form
    {
        ana_menu x1 = new ana_menu();
      
        
        public Kapat()
        {
            InitializeComponent();
        }

        private void Kapat_Load(object sender, EventArgs e)
        {
            x1.Close();         
            Close();
        }
    }
}

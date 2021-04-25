using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_PAW
{
    public partial class FormDashboard : Form
    {
       
        public FormDashboard()
        {
            InitializeComponent();
        }

        private void gunaImgBtnX_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gunaBtnLogout_Click(object sender, EventArgs e)
        {
            FormLogin f = new FormLogin();
            f.Show();
            this.Close();

        }
        private void gunaBtnHome_Click(object sender, EventArgs e)
        {

        }

        private void gunaBtnRecenzati_Click(object sender, EventArgs e)
        {
            UC_PanouRecenzati uc2 = new UC_PanouRecenzati();
            uc2.Show();
        }

       

        private void gunaBtnRecenzori_Click(object sender, EventArgs e)
        {
            UC_PanouRecenzori uc3 = new UC_PanouRecenzori();
            uc3.Show();
            
        }

        private void FormDashboard_Load(object sender, EventArgs e)
        {

        }
    }
}

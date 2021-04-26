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
    public partial class FormSignIn : Form
    {
        public FormSignIn()
        {
            InitializeComponent();
        }


        private void gunaBtnAnulare_Click(object sender, EventArgs e)
        {
            this.Close();
            FormLogin f = new FormLogin();
            f.Show();
        }

        private void gunaImgBtnX_Click(object sender, EventArgs e)
        {
            
            FormLogin f = new FormLogin();
            f.Show();
            this.Close();
        }

        private void gunaBtnCreareCont_Click(object sender, EventArgs e)
        { 
        
        FormDashboard f = new FormDashboard();
            f.Show();
            this.Close();
            
        }
    }
}

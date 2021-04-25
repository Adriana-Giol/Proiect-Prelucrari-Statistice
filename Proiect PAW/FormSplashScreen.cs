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
    public partial class FormSplashScreen : Form
    {
        public FormSplashScreen()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(guna2CircleProgressBar1.Value == 100)
            {
                timer1.Stop();
                FormLogin f = new FormLogin();
                f.Show();
                this.Hide();
            }
            else
            {
                guna2CircleProgressBar1.Value += 1;
                label1.Text = "Vă rugăm să așteptați..." + guna2CircleProgressBar1.Value.ToString() + "%";
            }

        }

        private void FormSplashScreen_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}

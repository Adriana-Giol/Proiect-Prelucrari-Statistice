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
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
               

                FormDashboard f = new FormDashboard();
                f.Show();
                this.Close();
            }
        
            
        }

        private void gunaTbNume_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(gunaTbNume.Text))
            {
                e.Cancel = true;
                gunaTbNume.Focus();
                errorProvider1.SetError(gunaTbNume, "Introduceti un nume valid!");
            }
            else{
                e.Cancel = false;
                errorProvider1.SetError(gunaTbNume, null);
                guna2ImageCheckBox1.Checked = true;
            }
        }

        private void guna2Email_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(guna2Email.Text))
            {
                e.Cancel = true;
                guna2Email.Focus();
                errorProvider1.SetError(guna2Email, "Introduceti o adresa de mail valida!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(guna2Email, null);
                guna2ImageCheckBox2.Checked = true;
            }
        }

        private void guna2Parola_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(guna2Parola.Text))
            {
                e.Cancel = true;
                guna2Parola.Focus();
                errorProvider1.SetError(guna2Parola, "Introduceti o parola!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(guna2Parola, null);
                guna2ImageCheckBox3.Checked = true;
            }
        }

        private void gunaImgBtnX_Click_1(object sender, EventArgs e)
        {
            this.Close();
            FormLogin f = new FormLogin();
            f.Show();
        }
    }
}

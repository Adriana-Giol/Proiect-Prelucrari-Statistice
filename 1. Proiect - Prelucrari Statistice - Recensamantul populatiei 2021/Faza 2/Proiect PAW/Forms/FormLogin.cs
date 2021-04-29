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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        
        private void gunaImgBtnSeen_MouseDown(object sender, MouseEventArgs e)
        {

            if (gunaTbParola.PasswordChar == '*')
            {
                gunaImgBtnSeen.BringToFront();
                gunaTbParola.PasswordChar = '\0';
            }
        }

        private void gunaImgBtnSeen_MouseUp(object sender, MouseEventArgs e)
        {
            if (gunaTbParola.PasswordChar == '\0')
            {
                gunaImgBtnSeen.BringToFront();
                gunaTbParola.PasswordChar = '*';
            }
        }

        private void gunaBtnInregistrare_Click(object sender, EventArgs e)
        {
            FormSignIn f = new FormSignIn();
            f.Show();
            this.Close();
        }

        private void gunaBtnAutentificare_Click(object sender, EventArgs e)
        {

            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                FormDashboard f = new FormDashboard();
                f.Show();
            }
                this.Close();
            
        }

        private void gunaImgBtnX_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void gunaTbEmail_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(gunaTbEmail.Text))
            {
                e.Cancel = true;
                gunaTbEmail.Focus();
                errorProvider1.SetError(gunaTbEmail, "Introduceti adresa de email!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(gunaTbEmail, null);
                guna2ImageCheckBox1.Checked = true;
            }
        }

        private void gunaTbParola_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(gunaTbParola.Text))
            {
                e.Cancel = true;
                gunaTbParola.Focus();
                errorProvider1.SetError(gunaTbParola, "Introduceti adresa de email!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(gunaTbParola, null);
                guna2ImageCheckBox2.Checked = true;
            }
        }

        private void gunaImgBtnX_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

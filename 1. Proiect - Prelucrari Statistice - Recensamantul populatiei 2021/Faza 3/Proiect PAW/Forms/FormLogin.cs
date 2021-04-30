using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;


namespace Proiect_PAW
{
    public partial class FormLogin : Form
    {
        public static String username;

        public FormLogin()
        {
            InitializeComponent();
            
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            guna2TbAtentionare.Visible = false;
        }

        private void gunaBtnInregistrare_Click(object sender, EventArgs e)
        {
            FormSignIn f = new FormSignIn();
            f.ShowDialog();
            this.Close();
            this.Hide();
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

        private void gunaTbEmail_TextChanged_1(object sender, EventArgs e)
        {
            string pattern = "^([\\w\\.\\-]+)@([\\w\\-]+)((\\.(\\w){2,3})+)$";
            if (gunaTbEmail.Text == null || (!Regex.IsMatch(gunaTbEmail.Text, pattern)))
            {
                
                errorProvider1.SetError(gunaTbEmail, "Introduceti adresa de email valida!");
                guna2ImageCheckBox1.Checked = false;

            }
            else
            {

                guna2ImageCheckBox1.Checked = true;
                errorProvider1.SetError(gunaTbEmail, null);

            }
        }

        private void gunaTbParola_TextChanged_1(object sender, EventArgs e)

        {
            if ((gunaTbParola.Text == null)||(gunaTbParola.Text.Length < 8 )|| (gunaTbParola.Text.Length > 15))
            {
                    errorProvider1.SetError(gunaTbParola, "Introduceti parola de 8-15 caractere!");
                    guna2ImageCheckBox2.Checked = false;

            }
            else
            {
               
                guna2ImageCheckBox2.Checked = true;
                errorProvider1.SetError(gunaTbParola, null);
            }

        }

        private void gunaBtnAutentificare_Click(object sender, EventArgs e)
        {
            if ((guna2ImageCheckBox1.Checked == true) && (guna2ImageCheckBox2.Checked == true))
            {
                username = gunaTbEmail.Text;
                FormDashboard f = new FormDashboard();
                f.ShowDialog();
                this.Close();
            }
            else
            {
                guna2TbAtentionare.Visible = true;
            }
        }

        private void gunaImgBtnX_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       
    }
}


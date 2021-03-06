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
using System.Net;
using System.Net.Mail;

namespace Proiect_PAW
{
    public partial class FormSignIn : Form
    {
        public FormSignIn()
        {
            InitializeComponent();
        }

        private void FormSignIn_Load(object sender, EventArgs e)
        {
            labelAtentionare.Visible = false;
            labelAcord.Visible = false;
        }

        private void gunaTbNume_TextChanged(object sender, EventArgs e)
        {
            if ((gunaTbNume.Text == null) || (gunaTbNume.Text.Length < 3) || (gunaTbNume.Text.Length > 10))
            {
                errorProvider1.SetError(gunaTbNume, "Introduceti nume de 3-10 caractere!");
                guna2ImageCheckBox1.Checked = false;

            }
            else
            {

                guna2ImageCheckBox1.Checked = true;
                errorProvider1.SetError(gunaTbNume, null);
            }
        }

        private void guna2Email_TextChanged(object sender, EventArgs e)
        {
            string pattern = "^([\\w\\.\\-]+)@([\\w\\-]+)((\\.(\\w){2,3})+)$";
            if (guna2Email.Text == null || (!Regex.IsMatch(guna2Email.Text, pattern)))
            {

                errorProvider1.SetError(guna2Email, "Introduceti adresa de email valida!");
                guna2ImageCheckBox2.Checked = false;

            }
            else
            {

                guna2ImageCheckBox2.Checked = true;
                errorProvider1.SetError(guna2Email, null);

            }
        }

        private void guna2Parola_TextChanged(object sender, EventArgs e)
        {
            if ((guna2Parola.Text == null) || (guna2Parola.Text.Length < 8) || (guna2Parola.Text.Length > 15))
            {
                errorProvider1.SetError(guna2Parola, "Introduceti parola de 8-15 caractere!");
                guna2ImageCheckBox3.Checked = false;

            }
            else
            {

                guna2ImageCheckBox3.Checked = true;
                errorProvider1.SetError(guna2Parola, null);
            }

        }
        private void gunaBtnAnulare_Click(object sender, EventArgs e)
        {
            this.Close();
            FormLogin f = new FormLogin();
            f.Show();
        }

    

        private void gunaBtnCreareCont_Click(object sender, EventArgs e)
        {
            if ((guna2ImageCheckBox1.Checked == true) && (guna2ImageCheckBox2.Checked == true) && (guna2ImageCheckBox3.Checked == true))
            {
                 if(gunaCkAcord.Checked == true)
                {
                    FormDashboard f = new FormDashboard();
                    f.Show();
                    this.Close();
                }
                else
                {
                    labelAcord.Visible = true;
                }
            }
                
            else
            {
                labelAtentionare.Visible = true;
                
            }
        }

        private void gunaImgBtnX_Click(object sender, EventArgs e)
        {
            this.Close();
            FormLogin f = new FormLogin();
            f.Show();
        }

      
    }
}

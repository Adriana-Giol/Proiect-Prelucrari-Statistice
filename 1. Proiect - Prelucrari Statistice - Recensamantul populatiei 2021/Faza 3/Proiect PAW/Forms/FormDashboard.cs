using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

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
            Application.Exit();
        }

        private void gunaBtnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Hide();
            FormLogin f = new FormLogin();
            f.ShowDialog();
            

        }
        private void gunaBtnHome_Click(object sender, EventArgs e)
        {
            UC_PanouAcasa uc1 = new UC_PanouAcasa();
            this.gunaBtnHome.ForeColor = Color.White;
            this.gunaBtnHome.BorderColor = Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(165)))), ((int)(((byte)(172)))));
            this.gunaBtnHome.FillColor = Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(165)))), ((int)(((byte)(172)))));
            this.gunaBtnHome.ForeColor = Color.Firebrick;

            this.gunaBtnRecenzati.ForeColor = Color.White;
            this.gunaBtnRecenzati.FillColor = Color.Indigo;

            this.gunaBtnRecenzori.ForeColor = Color.White;
            this.gunaBtnRecenzori.FillColor = Color.Indigo;


            showControl(uc1);
        }

        private void gunaBtnRecenzati_Click(object sender, EventArgs e)
        {
            UC_PanouRecenzati uc2 = new UC_PanouRecenzati();
            
            this.gunaBtnRecenzati.BorderColor = Color.Gold;
            this.gunaBtnRecenzati.CustomBorderColor = Color.Orange;
            this.gunaBtnRecenzati.FillColor = Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(196)))));
            this.gunaBtnRecenzati.ForeColor = Color.Gold;

            this.gunaBtnHome.ForeColor = Color.White;
            this.gunaBtnHome.FillColor =Color.Indigo;

            this.gunaBtnRecenzori.ForeColor = Color.White;
            this.gunaBtnRecenzori.FillColor = Color.Indigo;

            showControl(uc2);
        }

       

        private void gunaBtnRecenzori_Click(object sender, EventArgs e)
        {
            UC_PanouRecenzori uc3 = new UC_PanouRecenzori();
            this.gunaBtnRecenzori.BorderColor = Color.Navy;
            this.gunaBtnRecenzori.CustomBorderColor =Color.Navy;
            this.gunaBtnRecenzori.FillColor =Color.SkyBlue;
            this.gunaBtnRecenzori.ForeColor =Color.Navy;

            this.gunaBtnHome.ForeColor = Color.White;
            this.gunaBtnHome.FillColor = Color.Indigo;

            this.gunaBtnRecenzati.ForeColor = Color.White;
            this.gunaBtnRecenzati.FillColor = Color.Indigo;

            showControl(uc3);

        }

        private void FormDashboard_Load(object sender, EventArgs e)
        {
            labelUser.Text = FormLogin.username;
            labelUser.TextAlign = ContentAlignment.MiddleCenter;
        }
        public void showControl(Control control)
        {
            gunaPannelContainer.Controls.Clear();

            control.Dock = DockStyle.Fill;
            control.BringToFront();
            control.Focus();

            gunaPannelContainer.Controls.Add(control);
        }


        private void guna2BtnSecol_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://insse.ro/cms/files/evenimente/RoCentenar/ROCentenar.pdf");
        }

        private void gunaBtn1930_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://ro.wikipedia.org/wiki/Recens%C4%83m%C3%A2ntul_din_1930");
        }

        private void gunaImgBtnGov_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.gov.ro/");
        }

        private void gunaImgBtnInsse_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://insse.ro/cms/");
        }

        private void gunaImgBtnUE_Click(object sender, EventArgs e)
        {

            System.Diagnostics.Process.Start("https://ec.europa.eu/info/index_en");
        }

       
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;



namespace Proiect_PAW
{
    public partial class FormAddPers_Date : Form
    {
       

        public FormAddPers_Date()
        {
            InitializeComponent();
         
        }

        private void gunaImgBtnX_Click(object sender, EventArgs e)
        {
            FormDashboard f = new FormDashboard();
            f.Show();
            this.Close();
        }

        private void gunaaBtnCancel_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void gunaBtnSalvare_Click(object sender, EventArgs e)
        {

        }

        private void gunaHScrollBarNrCamere_Scroll(object sender, ScrollEventArgs e)
        {
            gunaTbNr.Text = gunaHScrollBarNrCamere.Value.ToString();
            if (gunaHScrollBarNrCamere.Value == 0)
            {
                gunaTbNr.Visible = false;
            }
            else
            {
                gunaTbNr.Visible = true;
            }

            try
            {
                int nrTb = gunaHScrollBarNrCamere.Value;
                int pointX1 = 0;
                int pointX2 = 0;
                int pointX3 = 0;

                int pointY1 = 5;
                int pointY2 = 5;
                int pointY3 = 5;

                gunaPanelSuprafete1.Controls.Clear();
                gunaPanelSuprafete2.Controls.Clear();
                gunaPanelSuprafete3.Controls.Clear();


                for (int i = 0; i < nrTb; i++)
                {
                    TextBox tb1 = new TextBox();
                    TextBox tb2 = new TextBox();
                    TextBox tb3 = new TextBox();

                    //Caracteristici vizuale
                    tb1.BackColor = ColorTranslator.FromHtml("#FFFFC4");
                    tb1.ForeColor = Color.Orange;
                    tb1.Name = "tbDim1";
                    tb1.Font = new Font("Segoe UI", 10);

                    tb2.BackColor = Color.White;
                    tb2.ForeColor = Color.DarkOrange;
                    tb2.Name = "tbDim2";
                    tb2.Font = new Font("Segoe UI", 10);

                    tb3.BackColor = ColorTranslator.FromHtml("#FFFFC4");
                    tb3.ForeColor = Color.Orange;
                    tb3.Name = "tbDim3";
                    tb3.Font = new Font("Segoe UI", 10);


                    //Functionalitate
                    tb1.Location = new Point(pointX1, pointY1);
                    tb1.Text = (i + 1).ToString();
                    tb1.ReadOnly = true;

                    tb2.Location = new Point(pointX2, pointY2);

                    tb3.Location = new Point(pointX3, pointY3);
                    tb3.Text = "mp";
                    tb3.ReadOnly = true;

                    gunaPanelSuprafete1.Controls.Add(tb1);
                    gunaPanelSuprafete2.Controls.Add(tb2);
                    gunaPanelSuprafete3.Controls.Add(tb3);

                    gunaPanelSuprafete1.Show();
                    gunaPanelSuprafete2.Show();
                    gunaPanelSuprafete3.Show();

                    pointY1 += 35;
                    pointY2 += 35;
                    pointY3 += 35;




                }
            }
            catch (Exception)
            {
                MessageBox.Show(e.ToString());
            }

        }
       

            private void gunaHScrollBarNrPers_Scroll(object sender, ScrollEventArgs e)
            {
                gunaTbNrPers.Text = gunaHScrollBarNrPers.Value.ToString();
                if (gunaHScrollBarNrPers.Value == 0)
                {
                    gunaTbNrPers.Visible = false;
                }
                else
                {
                    gunaTbNrPers.Visible = true;
                }
            }

        private void guna2DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            
            int currentAge = DateTime.Today.Year - guna2DateTimePicker1.Value.Year;
            int currentMonth = DateTime.Today.Month - guna2DateTimePicker1.Value.Month;
            if(guna2DateTimePicker1.Value > DateTime.Now)
            {
                gunaTbAni.Text = "Nu s-a născut încă!";
            }
            else
            {
                gunaTbAni.Text = currentAge.ToString() + " ani" + " si " + currentMonth.ToString() + " luni";
            }
        
        }

        private void gunaBtnMigrant_Click(object sender, EventArgs e)
        {
            Forms.FormAddPers_Migrant migrant = new Forms.FormAddPers_Migrant();
            migrant.ShowDialog();
            this.Close();
        }

        private void gunaBtnCultura_Click(object sender, EventArgs e)
        {
            Forms.FormAddPers_Cultura fc = new Forms.FormAddPers_Cultura();
            fc.ShowDialog();
        }

        private void gunaGbSex_Click(object sender, EventArgs e)
        {

            if (gunaCkFemeie.Checked = true)
            {
                gunaCkBarbat.Checked = false;
            }else {
                gunaCkBarbat.Checked = true;
            }

            
        }
    }
}

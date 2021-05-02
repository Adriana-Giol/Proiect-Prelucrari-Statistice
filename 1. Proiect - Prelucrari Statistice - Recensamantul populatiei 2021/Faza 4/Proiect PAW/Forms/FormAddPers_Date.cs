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
        private void FormAddPers_Date_Load(object sender, EventArgs e)
        {
            labelAni.Visible = false;
            labelNrPers.Visible = false;
            labelNrCam.Visible = false;
            labelSuprafataTotalaCamereLocuit.Visible = false;
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
            
            labelNrCam.Text = gunaHScrollBarNrCamere.Value.ToString();
            if (gunaHScrollBarNrCamere.Value == 0)
            {
                labelNrCam.Visible = false;
            }
            else
            {
                labelNrCam.Visible = true;
            }

            try
            {
                int nrTb = gunaHScrollBarNrCamere.Value;
                int[] suma = new int[nrTb];
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
                    Label l1 = new Label();
                    TextBox tb2 = new TextBox();
                    Label l3 = new Label();

                    

                    //Caracteristici vizuale
                    l1.BackColor = ColorTranslator.FromHtml("#FFFFC4");
                    l1.ForeColor = Color.Orange;
                    l1.Name = "LDim1";
                    l1.Font = new Font("Segoe UI", 10);

                    tb2.BackColor = ColorTranslator.FromHtml("#FFFFC4");
                    tb2.ForeColor = Color.DarkOrange;
                    tb2.Name = "tbDim2";
                    tb2.Font = new Font("Segoe UI", 10);
                    tb2.BorderStyle = BorderStyle.None;

                    l3.BackColor = ColorTranslator.FromHtml("#FFFFC4");
                    l3.ForeColor = Color.Orange;
                    l3.Name = "LDim3";
                    l3.Font = new Font("Segoe UI", 10);


                    //Functionalitate
                    l1.Location = new Point(pointX1, pointY1);
                    l1.Text = (i + 1).ToString();


                    tb2.Location = new Point(pointX2, pointY2);
                 

                    l3.Location = new Point(pointX3, pointY3);
                    l3.Text = "mp";


                    gunaPanelSuprafete1.Controls.Add(l1);
                    gunaPanelSuprafete2.Controls.Add(tb2);
                    gunaPanelSuprafete3.Controls.Add(l3);


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
                labelNrPers.Text = gunaHScrollBarNrPers.Value.ToString();
                if (gunaHScrollBarNrPers.Value == 0)
                {
                    labelNrPers.Visible = false;
                }
                else
                {
                    labelNrPers.Visible = true;
                }
            }

        private void guna2DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            
            int currentAge = DateTime.Now.Year - guna2DateTimePicker1.Value.Year;
            int currentMonth = DateTime.Now.Month - guna2DateTimePicker1.Value.Month;
            if(guna2DateTimePicker1.Value > DateTime.Now)
            {
                labelAni.Visible = true;
                labelAni.Text = "Nu s-a născut încă!";
            }
            else
            {
                labelAni.Visible = true;
                labelAni.Text = currentAge.ToString() + " ani" + " si " + currentMonth.ToString() + " luni";
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

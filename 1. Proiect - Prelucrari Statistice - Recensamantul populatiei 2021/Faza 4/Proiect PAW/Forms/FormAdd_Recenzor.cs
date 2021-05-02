using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_PAW.Forms
{
    public partial class FormAdd_Recenzor : Form
    {
        //List<Classes.Recenzor> listaRecenzori = new List<Classes.Recenzor>();
        public FormAdd_Recenzor()
        {
            InitializeComponent();
        }
        private void FormAdd_Recenzor_Load(object sender, EventArgs e)
        {
            labelAni.Visible = false;

        }



        private void gunaImgBtnX_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gunaaBtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /*private void gunaBtnSalvare_Click(object sender, EventArgs e)
        {
            try
            {
                string nume = gunaTbNume.Text;
                string cnp = gunaTbCNP.Text;
                DateTime dataNasterii = Convert.ToDateTime(guna2DateTimePicker1.Text);
                string localitate = gunaTbLocalitate.Text;
                int nrMape = Convert.ToInt32(gunaTbNumar.Text);

                Classes.Recenzor r = new Classes.Recenzor();

                listaRecenzori.Add(r);
                UC_PanouRecenzori uc1 = new UC_PanouRecenzori(listaRecenzori);
                uc1.Show();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                gunaTbNume.Clear();
                gunaTbCNP.Clear();
                DateTime dataNasterii = System.DateTime.Now;
                gunaCbRegiune.Text = "";
                gunaCbJudet.Text = "";
                gunaTbLocalitate.Clear();
                gunaTbNumar.Clear();
            }
        }*/


        //******************************** VALIDARI ***************************************************************

        //NUME
        private void gunaTbNume_TextChanged(object sender, EventArgs e)
        {
            if ((gunaTbNume.Text == "") || (gunaTbNume.Text.Length < 4))
            {
                errorProvider1.SetError(gunaTbNume, "Introduceti numele complet!");
                gunaImgCkNume.Checked = false;
            }
            else
            {
                gunaImgCkNume.Checked = true;
                errorProvider1.SetError(gunaTbNume, null);
            }
        }

        private void gunaTbNume_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 'a' && e.KeyChar <= 'z' || e.KeyChar >= 'A' && e.KeyChar <= 'Z' || e.KeyChar == (char)8)
                e.Handled = false;
            else
                e.Handled = true;
        }

        //DATA
        private void guna2DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            int currentAge = DateTime.Now.Year - guna2DateTimePicker1.Value.Year;
            int currentMonth = DateTime.Now.Month - guna2DateTimePicker1.Value.Month;
            if (guna2DateTimePicker1.Value > DateTime.Now)
            {
                labelAni.Visible = true;
                labelAni.Text = "Nu s-a născut încă!";
                errorProvider1.SetError(guna2DateTimePicker1, "Introduceti data nu este valida!");
                gunaImgCkData.Checked = false;
            }
            else
            {
                labelAni.Visible = true;
                labelAni.Text = currentAge.ToString() + " ani" + currentMonth.ToString() + " luni";
                gunaImgCkData.Checked = true;
                errorProvider1.SetError(guna2DateTimePicker1, null);
            }

        }
        //CNP
        private void gunaTbCNP_TextChanged(object sender, EventArgs e)
        {
            if ((gunaTbCNP.Text == "") || (gunaTbCNP.Text.Length != 15))
            {
                errorProvider1.SetError(gunaTbCNP, "Introduceti CNP-ul de 15 caractere!");
                gunaImgCkCNP.Checked = false;
            }
            else
            {
                gunaImgCkCNP.Checked = true;
                errorProvider1.SetError(gunaTbCNP, null);
            }
        }

        private void gunaTbCNP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)8)
                e.Handled = false;
            else
                e.Handled = true;
        }



        //SEX
        /* if ((gunaImgCkFem.Checked == false) || (gunaImgCkMasc.Checked = false))
                 errorProvider1.SetError(gunaGbSex, "Selectati sexul!");*/
        //JUDET
        private void gunaCbJudet_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (gunaCbJudet.SelectedIndex == -1)
            {
                errorProvider1.SetError(gunaCbJudet, "Alegeti judetul recenzat!");
                gunaimgCkJudet.Checked = false;

            }
           
            else
            {
                gunaimgCkJudet.Checked = true;
                errorProvider1.SetError(gunaCbJudet, null);
            }
        }


        //LOCALITATE
        private void gunaTbLocalitate_TextChanged(object sender, EventArgs e)
        {
            if (gunaTbLocalitate.Text == "")
            {
                errorProvider1.SetError(gunaTbLocalitate, "Introduceti localitatea recenzata!");
                gunaImgCkLocalitate.Checked = false;
            }
          

            else
            {
                gunaImgCkLocalitate.Checked = true;
                errorProvider1.SetError(gunaTbLocalitate, null);
            }
        }

        //REGIUNE
        private void gunaCkRegiune_SelectedIndexChanged(object sender, EventArgs e) 
        {
            if (gunaCbRegiune.SelectedIndex == -1)
            {
                errorProvider1.SetError(gunaCbRegiune, "Alegeti regiunea recenzata!");
                gunaCkImgRegiune.Checked = false;
            }
 
            else
            {

                gunaCkImgRegiune.Checked = true;
                errorProvider1.SetError(gunaCbJudet, null);
            }
        }



        //NUMAR MAPE
        private void gunaTbNumar_TextChanged(object sender, EventArgs e)
        {
            if (gunaTbNumar.Text == "")
            {
                errorProvider1.SetError(gunaTbNumar, "Introduceti un numar");
                gunaImgCkNrMape.Checked = false;
            }
            else
            {
                gunaImgCkNrMape.Checked = true;
                errorProvider1.SetError(gunaTbNumar, null);
            }

        }
        private void gunaTbNumar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)8)
                e.Handled = false;
            else
                e.Handled = true;
        }

      
    }
}

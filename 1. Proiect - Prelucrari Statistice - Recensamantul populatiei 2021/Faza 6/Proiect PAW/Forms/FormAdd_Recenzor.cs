using Proiect_PAW.Classes;
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
        public object gunagdvRecenzori { get; private set; }


        public FormAdd_Recenzor()
        {
            InitializeComponent();

        }
        private void FormAdd_Recenzor_Load(object sender, EventArgs e)
        {
            labelAni.Visible = false;
       

            //CREARE DATA TABLE PENTRU REGIUNE
            DataTable tbReg = new DataTable();
            tbReg.Columns.Add("id");
            tbReg.Columns.Add("Valoare");

            tbReg.Rows.Add("1", "Dobrogea");
            tbReg.Rows.Add("2", "Muntenia");
            tbReg.Rows.Add("3", "Moldova");
            tbReg.Rows.Add("4", "Transilvania");
            tbReg.Rows.Add("5", "Bucovina");
            tbReg.Rows.Add("6", "Maramures");
            tbReg.Rows.Add("7", "Crisana");
            tbReg.Rows.Add("8", "Banat");
            tbReg.Rows.Add("9", "Oltenia");

            gunaCbRegiune.DataSource = tbReg;
            gunaCbRegiune.DisplayMember = "Valoare";
            gunaCbRegiune.ValueMember = "id";
  

        }

        private void gunaImgBtnX_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gunaaBtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //******************************** VALIDARI ***************************************************************

        //NUME
        private void gunaTbNume_TextChanged(object sender, EventArgs e)
        {
            if ((gunaTbNume.Text == "") || (gunaTbNume.Text.Length < 5))
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
                labelAni.Text = currentAge.ToString() + " ani " + currentMonth.ToString() + " luni";
                gunaImgCkData.Checked = true;
                errorProvider1.SetError(guna2DateTimePicker1, null);
            }

        }
        //COD RECENZOR
        private void gunaTbCodRecenzor_TextChanged(object sender, EventArgs e)
        {
            if ((gunaTbCodRecenzor.Text == "") || (gunaTbCodRecenzor.Text.Length != 4))
            {
                errorProvider1.SetError(gunaTbCodRecenzor, "Introduceti codul de 4 caractere!");
                gunaImgCkCNP.Checked = false;
            }
            else
            {
                gunaImgCkCNP.Checked = true;
                errorProvider1.SetError(gunaTbCodRecenzor, null);
            }
        }

        private void gunaTbCodRecenzor_KeyPress(object sender, KeyPressEventArgs e)
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
            if ((gunaTbLocalitate.Text == "") || (gunaTbLocalitate.Text.Length < 3))
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

        private void gunaTbLocalitate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 'a' && e.KeyChar <= 'z' || e.KeyChar >= 'A' && e.KeyChar <= 'Z' || e.KeyChar == (char)8)
                e.Handled = false;
            else
                e.Handled = true;

        }

        //REGIUNE
        private void gunaCbRegiune_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable tbJud = new DataTable();
            tbJud.Columns.Add("id");
            tbJud.Columns.Add("Valoare");



            if (gunaCbRegiune.SelectedIndex == -1)
            {
                errorProvider1.SetError(gunaCbRegiune, "Alegeti regiunea recenzata!");
                gunaCkImgRegiune.Checked = false;
            }
            else if (gunaCbRegiune.SelectedIndex == 0)
            {
                tbJud.Rows.Add("14", "Constanta");
                tbJud.Rows.Add("38", "Tulcea");

                gunaCbJudet.DataSource = tbJud;
                gunaCbJudet.DisplayMember = "Valoare";
                gunaCbJudet.ValueMember = "id";

                gunaCkImgRegiune.Checked = true;
                errorProvider1.SetError(gunaCbJudet, null);
            }
            else if (gunaCbRegiune.SelectedIndex == 1)
            {
                tbJud.Rows.Add("3", "Arges");
                tbJud.Rows.Add("9", "Braila");
                tbJud.Rows.Add("10", "Buzau");
                tbJud.Rows.Add("12", "Calarasi");
                tbJud.Rows.Add("16", "Dambovita");
                tbJud.Rows.Add("19", "Giurgiu");
                tbJud.Rows.Add("23", "Ialomita");
                tbJud.Rows.Add("25", "Ilfov");
                tbJud.Rows.Add("31", "Prahova");
                tbJud.Rows.Add("36", "Teleorman");
                tbJud.Rows.Add("42", "Municipiul Bucuresti");

                gunaCbJudet.DataSource = tbJud;
                gunaCbJudet.DisplayMember = "Valoare";
                gunaCbJudet.ValueMember = "id";

                gunaCkImgRegiune.Checked = true;
                errorProvider1.SetError(gunaCbJudet, null);
            }

            else if (gunaCbRegiune.SelectedIndex == 2)
            {
                tbJud.Rows.Add("4", "Bacau");
                tbJud.Rows.Add("7", "Botosani");
                tbJud.Rows.Add("18", "Galati");
                tbJud.Rows.Add("24", "Iasi");
                tbJud.Rows.Add("29", "Neamt");
                tbJud.Rows.Add("39", "Vaslui");
                tbJud.Rows.Add("41", "Vrancea");

                gunaCbJudet.DataSource = tbJud;
                gunaCbJudet.DisplayMember = "Valoare";
                gunaCbJudet.ValueMember = "id";

                gunaCkImgRegiune.Checked = true;
                errorProvider1.SetError(gunaCbJudet, null);
            }

            else if (gunaCbRegiune.SelectedIndex == 3)
            {
                tbJud.Rows.Add("1", "Alba");
                tbJud.Rows.Add("6", "Bistrita-Nasaud");
                tbJud.Rows.Add("8", "Brasov");
                tbJud.Rows.Add("13", "Cluj");
                tbJud.Rows.Add("15", "Covasna");
                tbJud.Rows.Add("21", "Harghita");
                tbJud.Rows.Add("22", "Hunedoara");
                tbJud.Rows.Add("28", "Mures");
                tbJud.Rows.Add("34", "Sibiu");

                gunaCbJudet.DataSource = tbJud;
                gunaCbJudet.DisplayMember = "Valoare";
                gunaCbJudet.ValueMember = "id";

                gunaCkImgRegiune.Checked = true;
                errorProvider1.SetError(gunaCbJudet, null);
            }

            else if (gunaCbRegiune.SelectedIndex == 4)
            {
                tbJud.Rows.Add("35", "Suceava");

                gunaCbJudet.DataSource = tbJud;
                gunaCbJudet.DisplayMember = "Valoare";
                gunaCbJudet.ValueMember = "id";

                gunaCkImgRegiune.Checked = true;
                errorProvider1.SetError(gunaCbJudet, null);
            }

            else if (gunaCbRegiune.SelectedIndex == 5)
            {
                tbJud.Rows.Add("26", "Maramures");
                tbJud.Rows.Add("32", "Satu-Mare");

                gunaCbJudet.DataSource = tbJud;
                gunaCbJudet.DisplayMember = "Valoare";
                gunaCbJudet.ValueMember = "id";

                gunaCkImgRegiune.Checked = true;
                errorProvider1.SetError(gunaCbJudet, null);
            }

            else if (gunaCbRegiune.SelectedIndex == 6)
            {
                tbJud.Rows.Add("2", "Arad");
                tbJud.Rows.Add("5", "Bihor");
                tbJud.Rows.Add("33", "Salaj");

                gunaCbJudet.DataSource = tbJud;
                gunaCbJudet.DisplayMember = "Valoare";
                gunaCbJudet.ValueMember = "id";

                gunaCkImgRegiune.Checked = true;
                errorProvider1.SetError(gunaCbJudet, null);
            }


            else if (gunaCbRegiune.SelectedIndex == 7)
            {
                tbJud.Rows.Add("11", "Caras-Severin");
                tbJud.Rows.Add("37", "Timis");

                gunaCbJudet.DataSource = tbJud;
                gunaCbJudet.DisplayMember = "Valoare";
                gunaCbJudet.ValueMember = "id";

                gunaCkImgRegiune.Checked = true;
                errorProvider1.SetError(gunaCbJudet, null);
            }

            else if (gunaCbRegiune.SelectedIndex == 8)
            {
                tbJud.Rows.Add("17", "Dolj");
                tbJud.Rows.Add("20", "Gorj");
                tbJud.Rows.Add("27", "Mehedinti");
                tbJud.Rows.Add("30", "Olt");
                tbJud.Rows.Add("40", "Valcea");

                gunaCbJudet.DataSource = tbJud;
                gunaCbJudet.DisplayMember = "Valoare";
                gunaCbJudet.ValueMember = "id";

                gunaCkImgRegiune.Checked = true;
                errorProvider1.SetError(gunaCbJudet, null);
            }
        }

        private void gunaBtnSalvare_Click(object sender, EventArgs e)
        {

            List<Recenzor> listaRecenzori = new List<Recenzor>();

           
                try
                {

                    string numeComplet = gunaTbNume.Text;
                    string codRecenzor = gunaTbCodRecenzor.Text;
                    DateTime dataNasterii = Convert.ToDateTime(guna2DateTimePicker1.Text);
                    string sex = string.Empty;
                    if (guna2ImageRadioButtonFeminin.Checked)
                        sex = "Feminin";
                    else
                        sex = "Masculin";
                    string regiuneRecenzata = gunaCbRegiune.Text;
                    string judetRecenzat = gunaCbJudet.Text;
                    string localitateRecenzata = gunaTbLocalitate.Text;

                    Recenzor recenzor = new Recenzor(codRecenzor, numeComplet, dataNasterii, sex, regiuneRecenzata, judetRecenzat, localitateRecenzata);
                    MessageBox.Show(recenzor.ToString());
                }



                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    gunaTbNume.Clear();
                    gunaTbCodRecenzor.Clear();
                    gunaTbLocalitate.Clear();
                    guna2ImageRadioButtonFeminin.Checked = false;
                    guna2ImageRadioButtonMasculin.Checked = false;
                    guna2DateTimePicker1.Value = System.DateTime.Now;
                    gunaCbRegiune.SelectedIndex = -1;
                    gunaCbJudet.SelectedIndex = -1;
                    errorProvider1.Clear();
                    

                }
            
            
        }
    }
}
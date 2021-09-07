using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proiect_PAW.Forms;
using Proiect_PAW.Classes;

namespace Proiect_PAW
{
    public partial class UC_PanouRecenzori : UserControl
    {
        DataTable dt = new DataTable();
        FormAdd_Recenzor formAdd_Recenzor = new FormAdd_Recenzor();
        List<Recenzor> listaRecenzori2 = new List<Recenzor>();


        public UC_PanouRecenzori(List<Recenzor> listaRecenzori)
        {
            InitializeComponent();
            listaRecenzori2 = listaRecenzori;
            
        }

        public UC_PanouRecenzori()
        {
            InitializeComponent();
        }


        private void previzualizareToolStripMenuItem_Click(object sender, EventArgs e)
        {/*
            FormPrevizualizareRecenzori previzualizare = new FormPrevizualizareRecenzori();
            previzualizare.ShowDialog();*/
        }

        private void gunaImgBtnDashboard_Click(object sender, EventArgs e)
        {
            this.Hide();
            
        }

        private void gunaaBtnAdauga_Click(object sender, EventArgs e)
        {

            Forms.FormAdd_Recenzor r = new Forms.FormAdd_Recenzor();
            r.ShowDialog();

        }
       

        private void gunaImgBtnLocuinta_Click(object sender, EventArgs e)
        {
            Forms.FormRegiuni_Recenzor rg = new Forms.FormRegiuni_Recenzor();
            rg.ShowDialog();
        }

        private void gunaTbCauta_TextChanged(object sender, EventArgs e)
        {
            /*if (gunaTbCauta.Text != "")
            {
                for (int i = gunagdvRecenzori.Items.Count - 1; i >= 0; i--)
                {
                    var item = listViewRecenzori.Items[i];
                    if (item.Text.ToLower().Contains(gunaTbCauta.Text.ToLower()))
                    {
                        item.BackColor = SystemColors.Highlight;
                        item.ForeColor = SystemColors.HighlightText;
                    }
                    else
                    {
                        listViewRecenzori.Items.Remove(item);
                    }
                }
                if (listViewRecenzori.SelectedItems.Count == 1)
                {
                    listViewRecenzori.Focus();
                }
            }*/
        
        }

        private void afisarePersoaneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach(Recenzor recenzor in listaRecenzori2)
            {
                ListViewItem item = new ListViewItem(recenzor.NumeComplet);
                item.SubItems.Add(recenzor.CodRecenzor);
                item.SubItems.Add(recenzor.DataNasterii.ToString());
                item.SubItems.Add(recenzor.Sex);
                item.SubItems.Add(recenzor.RegiuneRecenzata);
                item.SubItems.Add(recenzor.JudetRecenzat);
                item.SubItems.Add(recenzor.LocalitateRecenzata);
                item.SubItems.Add(recenzor.DirectorRegional);
            }
        }

        private void gunaBtnSterge_Click(object sender, EventArgs e)
        {
          
        }

        
    }
}

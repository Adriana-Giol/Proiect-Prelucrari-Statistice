using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_PAW
{
    public partial class UC_PanouRecenzori : UserControl
    {
        //List<Classes.Recenzor> listaRecenzoriForm2;
       
        public UC_PanouRecenzori()
        {
            InitializeComponent();
            //listaRecenzoriForm2 = listaRecenzori;
            
        }
      /*  private void UC_PanouRecenzori_Load(object sender, EventArgs e)
        {
            foreach (Classes.Recenzor r in listaRecenzoriForm2)
                listViewRecenzori.Items.Add(r.ToString());
        }*/

        private void previzualizareToolStripMenuItem_Click(object sender, EventArgs e)
        {/*
            FormPrevizualizareRecenzori previzualizare = new FormPrevizualizareRecenzori();
            previzualizare.ShowDialog();*/
        }

        private void gunaImgBtnDashboard_Click(object sender, EventArgs e)
        {
            FormDashboard ds = new FormDashboard();
            ds.Show();
        }

        private void gunaaBtnAdauga_Click(object sender, EventArgs e)
        {
            
            Forms.FormAdd_Recenzor r = new Forms.FormAdd_Recenzor();
            r.ShowDialog();

        }

        private void gunaBtnSterge_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem recenzor in listViewRecenzori.Items)
                if (recenzor.Checked)
                    recenzor.Remove();
        }

        private void stergeRecenzorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem recenzor in listViewRecenzori.Items)
                if (recenzor.Checked || recenzor.Selected)
                    recenzor.Remove();
        }

       

        private void gunaImgBtnLocuinta_Click(object sender, EventArgs e)
        {
            Forms.FormRegiuni_Recenzor rg = new Forms.FormRegiuni_Recenzor();
            rg.ShowDialog();
        }

        private void gunaTbCauta_TextChanged(object sender, EventArgs e)
        {
            if (gunaTbCauta.Text != "")
            {
                for (int i = listViewRecenzori.Items.Count - 1; i >= 0; i--)
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
            }
        
        }
    
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proiect_PAW.Classes;
using Guna.UI2.WinForms;

namespace Proiect_PAW
{
    public partial class UC_PanouRecenzori : UserControl
    {

        

        public UC_PanouRecenzori(List<Recenzor> listaRecenzori)
        {
            InitializeComponent();
          
            
        }

        public UC_PanouRecenzori()
        {
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

    }
}

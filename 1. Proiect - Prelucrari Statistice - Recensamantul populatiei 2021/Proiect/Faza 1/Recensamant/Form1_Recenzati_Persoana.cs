using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Recensamant
{
    public partial class Form1_Recenzati_Persoana : Form
    {
        public Form1_Recenzati_Persoana()
        {
            InitializeComponent();
        }

        private void golireFormularToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tbNume.Clear();
            tbPrenume.Clear();
            tbCNP.Clear();
        }

        private void btn_Anulare_Click(object sender, EventArgs e)
        {
            FormPrincipal frm = new FormPrincipal();
            frm.Show();
        }

        private void fisierTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "(*.txt)|*.txt";
            if (dlg.ShowDialog() == DialogResult.OK)
            {

                StreamWriter sw = new StreamWriter(dlg.FileName);
                sw.WriteLine(tbNume.Text);
                sw.WriteLine(tbPrenume.Text);
                sw.WriteLine(tbCNP.Text);
                sw.Close();

                tbNume.Clear();
                tbPrenume.Clear();
                tbCNP.Clear();
            }
        }

        private void fisierTextToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "(*.txt)|*.txt";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(dlg.FileName);
                tbNume.Text = sr.ReadToEnd();
                tbPrenume.Text = sr.ReadToEnd();
                tbCNP.Text = sr.ReadToEnd();
                sr.Close();
            }
        }

        private void fisierBinarToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }
    }
}

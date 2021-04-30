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
            FormDashboard ds = new FormDashboard();
            ds.Show();
        }
    }
}

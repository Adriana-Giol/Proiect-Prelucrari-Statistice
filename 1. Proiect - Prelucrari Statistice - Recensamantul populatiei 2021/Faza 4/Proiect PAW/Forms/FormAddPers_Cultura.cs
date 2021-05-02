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
    public partial class FormAddPers_Cultura : Form
    {
        public FormAddPers_Cultura()
        {
            InitializeComponent();
        }

        private void gunaImgBtnX_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gunaaBtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

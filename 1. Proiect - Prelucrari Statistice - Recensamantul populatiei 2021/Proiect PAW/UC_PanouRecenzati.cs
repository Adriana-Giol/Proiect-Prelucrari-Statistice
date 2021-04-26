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
    public partial class UC_PanouRecenzati : UserControl
    {
       

        public UC_PanouRecenzati()
        {
            InitializeComponent();
        }

        private void gunaaBtnAdauga_Click(object sender, EventArgs e)
        {
            FormAddPers_Date f1 = new FormAddPers_Date();
            f1.Show();
           
        }

   
    }
}

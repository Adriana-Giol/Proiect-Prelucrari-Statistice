using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Proiect_PAW.Forms
{
    public partial class FormRegiuni_Recenzor : Form
    {
        public FormRegiuni_Recenzor()
        {
            InitializeComponent();
        }

        private void gunaImgBtnX_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormRegiuni_Recenzor_Load(object sender, EventArgs e)
        {
            treeView1.ExpandAll();
        }

        private void gunaaBtnSalvareInXML_Click(object sender, EventArgs e)
        {
            MemoryStream memStream = new MemoryStream();
            XmlTextWriter writer = new XmlTextWriter(memStream, Encoding.UTF8);
            writer.Formatting = Formatting.Indented;

            writer.WriteStartDocument();

            foreach (TreeNode nod in treeView1.Nodes)
            {
                writer.WriteStartElement(nod.Text);

                foreach (TreeNode copil in nod.Nodes)
                {
                    writer.WriteStartElement(copil.Text);
                    foreach (TreeNode nepot in copil.Nodes)
                    {
                        writer.WriteStartElement(nepot.Text);

                        foreach (TreeNode stranepot in nepot.Nodes)
                        {
                            writer.WriteStartElement(stranepot.Text);

                            writer.WriteEndElement();
                        }

                        writer.WriteEndElement();
                    }
                    writer.WriteEndElement();
                }
                writer.WriteEndElement();
            }
            writer.WriteEndDocument();
            writer.Close();

            string str = Encoding.UTF8.GetString(memStream.ToArray());
            memStream.Close();

            StreamWriter sw = new StreamWriter("Regiunile_romaniei_EXPORT.xml");
            sw.WriteLine(str);
            sw.Close();
            MessageBox.Show("Salvat cu succes in locatia bin/Debug!");
        }

     
    }
}

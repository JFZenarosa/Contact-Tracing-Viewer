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

namespace Contact_Tracing_Form_Viewer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Stream writer;
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.InitialDirectory = "C:\\Example";            

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                if((writer = ofd.OpenFile()) !=null) 
                {
                    string contactForm = ofd.FileName;
                    string filetext = File.ReadAllText(contactForm);

                    DisplayBox.Text = filetext;
                }

            }
            else if (ofd.ShowDialog() == DialogResult.Cancel)
            {
                MessageBox.Show("Cancelled");
            }
            else { }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}

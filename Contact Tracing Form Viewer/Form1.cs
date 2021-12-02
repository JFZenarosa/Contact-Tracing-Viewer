using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.InitialDirectory = "C:\\Example";            

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                

            }
            else if (ofd.ShowDialog() == DialogResult.Cancel)
            {
                MessageBox.Show("Cancelled");
            }
            else { }
        }
    }
}

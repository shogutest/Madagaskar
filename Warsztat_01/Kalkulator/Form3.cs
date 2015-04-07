using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalkulator
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void form1ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void formularz1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 formularz = new Form1();
            formularz.MdiParent = this;
            formularz.Show();
        }

        private void formularz2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 formularz = new Form2();
            formularz.MdiParent = this;
            formularz.Show();
        }

        private void zamknijAplikacjeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

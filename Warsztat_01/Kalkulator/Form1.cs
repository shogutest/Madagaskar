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
    public partial class Form1 : Form
    {
         double a, b, wynik;

           
        public Form1()
        {
            InitializeComponent();
        }

      
        private void Dodawanie_Click(object sender, EventArgs e)
        {
            wynik = 0;
            try
            {
                a = Double.Parse(txtA.Text);
                b = Double.Parse(txtB.Text);
                txtWynik.Text = Convert.ToString(a + b);
            }
            catch
            {
                txtWynik.BackColor = Color.Red;
            }
           
        }

        private void txtWynik_TextChanged(object sender, EventArgs e)
        {

        }

        private void Odejmowanie_Click(object sender, EventArgs e)
        {
            wynik = 0;
            try
            {
                a = Double.Parse(txtA.Text);
                b = Double.Parse(txtB.Text);
                txtWynik.Text = Convert.ToString(a - b);
            }
            catch
            {
                txtWynik.BackColor = Color.Red;
            }
            
        }

        private void Mnozenie_Click(object sender, EventArgs e)
        {
            wynik = 0;
            try
            {
                a = Double.Parse(txtA.Text);
                b = Double.Parse(txtB.Text);
                txtWynik.Text = Convert.ToString(a * b);
            }
            catch
            {
                txtWynik.BackColor = Color.Red;
            }
           
            
        }

        private void Dzielenie_Click(object sender, EventArgs e)
        {
            wynik = 0;
            try
            {
                a = Double.Parse(txtA.Text);
                b = Double.Parse(txtB.Text);
                txtWynik.Text = Convert.ToString(a / b);
            }
            catch
            {
                txtWynik.BackColor = Color.Red;
            }
            
        }

        private void Wyjscie_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

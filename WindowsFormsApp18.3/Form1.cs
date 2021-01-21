using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp18._3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Punt punt;
        Cirkel cirkel;
        Cilinder cilinder = new Cilinder();

        private void btnPunt_Click(object sender, EventArgs e)
        {
            punt = new Punt(Convert.ToDouble(txtX.Text), Convert.ToDouble(txtY.Text));
            MessageBox.Show($"{punt.Gegevens()}", "Result. ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        double eenStraal = 0;
        private void btnCikel_Click(object sender, EventArgs e)
        {
            cirkel = new Cirkel(Convert.ToDouble(txtX.Text), Convert.ToDouble(txtY.Text), eenStraal);
            eenStraal = Math.Sqrt(Math.Pow(cirkel.X, 2) + Math.Pow(cirkel.Y, 2));
            cirkel.R = eenStraal;
            MessageBox.Show($"{cirkel.Gegevens()}", "Result. ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCilinder_Click(object sender, EventArgs e)
        {
            cilinder = new Cilinder(Convert.ToDouble(txtX.Text), Convert.ToDouble(txtY.Text), eenStraal, Convert.ToDouble(txtHoogte.Text));
            cilinder.R = eenStraal;
            MessageBox.Show($"{cilinder.Gegevens()} ", "Result. ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

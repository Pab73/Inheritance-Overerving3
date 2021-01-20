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

        private void btnPunt_Click(object sender, EventArgs e)
        {
            Punt punt = new Punt(3, 4);
            MessageBox.Show($"{punt.Gegevens()}", "Result. ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCikel_Click(object sender, EventArgs e)
        {
            Cirkel cirkel = new Cirkel(3, 4, 5);
            MessageBox.Show($"{cirkel.Gegevens()}", "Result. ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCilinder_Click(object sender, EventArgs e)
        {
            Cilinder cilinder = new Cilinder(3, 4, 1, 2);
            MessageBox.Show($"{cilinder.Gegevens()} ", "Result. ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

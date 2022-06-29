using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Combustivel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtAbastecer.Clear();
            txtEtanol.Clear();
            txtGasolina.Clear();
            txtGasolina.Focus();
        }

        Classe n = new Classe();
        private void btnVerificar_Click(object sender, EventArgs e)
        {
            
            double gasolina, etanol;
            gasolina = double.Parse(txtGasolina.Text);
            etanol = double.Parse(txtEtanol.Text);
            txtAbastecer.Text = n.QualAbastecer(gasolina, etanol);

        }
    }
}

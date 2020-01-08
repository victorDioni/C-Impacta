using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula08.Ativi1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnSomar_Click(object sender, EventArgs e)
        {
            lblResultado.Visible = true;
            int n1 = Convert.ToInt32(txbNumero1.Text);
            int n2 = Convert.ToInt32(txbNumero2.Text);
            int resposta = n1 + n2;

            lblResultado.Text = Convert.ToString(resposta);

        }

        private void BtnSubtrair_Click(object sender, EventArgs e)
        {
            lblResultado.Visible = true;
            int n1 = Convert.ToInt32(txbNumero1.Text);
            int n2 = Convert.ToInt32(txbNumero2.Text);
            int resposta = n1 - n2;

            lblResultado.Text = Convert.ToString(resposta);
        }

        private void BtnMultiplicar_Click(object sender, EventArgs e)
        {
            lblResultado.Visible = true;
            int n1 = Convert.ToInt32(txbNumero1.Text);
            int n2 = Convert.ToInt32(txbNumero2.Text);
            int resposta = n1 * n2;

            lblResultado.Text = Convert.ToString(resposta);
        }

        private void BtnDividir_Click(object sender, EventArgs e)
        {
            lblResultado.Visible = true;
            int n1 = Convert.ToInt32(txbNumero1.Text);
            int n2 = Convert.ToInt32(txbNumero2.Text);
            int resposta = n1 / n2;

            lblResultado.Text = Convert.ToString(resposta);
        }
    }
}

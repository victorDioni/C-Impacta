using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula08.Ativ2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnTabuada_Click(object sender, EventArgs e)
        {
            lstTabuada.Items.Clear();
            int tabuada = Convert.ToInt32(txtNumero.Text);
            for (int i = 0; i <=10 ; i++)
            {
                string linha = string.Format("{0} X {1} = {2}", i, tabuada, i * tabuada);
                lstTabuada.Items.Add(linha);
            }
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn7_Click(object sender, EventArgs e)
        {
            int n7 = Convert.ToInt32(btn7.Text);
            txtCaixa.Text = Convert.ToString(n7);
        }
    }
}

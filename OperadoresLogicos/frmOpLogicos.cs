using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CursoCSharp.OperadoresLogicos
{
    public partial class frmOpLogicos : Form
    {
        public frmOpLogicos()
        {
            InitializeComponent();
        }

        double numero1;
        double numero2;
        bool resultado;

        private void btnAND_Click(object sender, EventArgs e)
        {
            OperadorAND();
        }

        private void OperadorAND()
        {
            Asignar();
            if (numero1 > 5 && numero2 < 10)
            {
                resultado = true;
            }
            else
            {
                resultado = false;
            }

            lblresultado.Text = resultado.ToString();
        }
        private void Asignar()
        {
            numero1 = Convert.ToDouble(txtnumero1.Text);
            numero2 = Convert.ToDouble(txtnumero2.Text);

        }

        private void btnOR_Click(object sender, EventArgs e)
        {
            OperadorOR();
        }

        private void OperadorOR()
        {
            Asignar();
            if (numero1 > 5 || numero2 < 10)
            {
                resultado = true;
            }
            else
            {
                resultado = false;
            }

            lblresultado.Text = resultado.ToString();
        }

        private void btnNOT_Click(object sender, EventArgs e)
        {
            OperadorNOT();
        }

        private void OperadorNOT()
        {
            Asignar();
            if (!(numero1 > 5 && numero2 < 10))
            {
                resultado = true;
            }
            else
            {
                resultado = false;
            }

            lblresultado.Text = resultado.ToString();
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CursoCSharp.OperadoresAritmeticos
{
    public partial class fmOpAritmeticos : Form
    {
        public fmOpAritmeticos()
        {
            InitializeComponent();
        }


        double numero1;
        double numero2;
        double resultado;


        private void fmOpAritmeticos_Load(object sender, EventArgs e)
        {

        }

        private void btnsuma_Click(object sender, EventArgs e)
        {
            Suma();
        }


        private void Suma()
        {
            try
            {
                txtnumero1.Text = txtnumero1.Text.Replace(",", ".");
                txtnumero2.Text = txtnumero2.Text.Replace(",", ".");

                numero1 = Convert.ToDouble(txtnumero1.Text);
                numero2 = Convert.ToDouble(txtnumero2.Text);
                
                resultado = numero1 + numero2;

                lblresultado.Text = Convert.ToString(resultado);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }
            
        }

        private void btnresta_Click(object sender, EventArgs e)
        {
            Resta();
        }

        private void Resta()
        {
            numero1 = Convert.ToDouble(txtnumero1.Text);
            numero2 = Convert.ToDouble(txtnumero2.Text);
            resultado = numero1 - numero2;

            lblresultado.Text = Convert.ToString(resultado);
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnmultiplicacion_Click(object sender, EventArgs e)
        {
            Multiplicacion();
        }

        private void Multiplicacion()
        {
            numero1 = Convert.ToDouble(txtnumero1.Text);
            numero2 = Convert.ToDouble(txtnumero2.Text);
            resultado = numero1 * numero2;

            lblresultado.Text = Convert.ToString(resultado);
        }

        private void btndivision_Click(object sender, EventArgs e)
        {
            Division();
        }

        private void Division()
        {
            numero1 = Convert.ToDouble(txtnumero1.Text);
            numero2 = Convert.ToDouble(txtnumero2.Text);
            resultado = numero1 / numero2;

            lblresultado.Text = Convert.ToString(resultado);
        }

    }
}

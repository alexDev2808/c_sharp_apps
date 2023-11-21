using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CursoCSharp.OperadoresRelacionales
{
    public partial class frmOpRelacionales : Form
    {
        public frmOpRelacionales()
        {
            InitializeComponent();
        }

        double numero1;
        double numero2;
        bool resultado;



        private void btnmayor_Click(object sender, EventArgs e)
        {
            MayorQue();
        }

        private void MayorQue()
        {
            Asignacion();
            if ( numero1 > numero2 )
            {
                resultado = true;
            }
            else
            {
                resultado = false;
            }

            lblresultado.Text = resultado.ToString();
        }

        private void Asignacion()
        {
            numero1 = Convert.ToDouble(txtnumero1.Text);
            numero2 = Convert.ToDouble(txtnumero2.Text);
        }

        private void btnmenor_Click(object sender, EventArgs e)
        {
            MenorQue();
        }

        private void MenorQue()
        {
            Asignacion();
            if (numero1 < numero2)
            {
                resultado = true;
            }
            else
            {
                resultado = false;
            }

            lblresultado.Text = resultado.ToString();
        }

        private void btnmayorigual_Click(object sender, EventArgs e)
        {
            MayorIgualQue();
        }

        private void MayorIgualQue()
        {
            Asignacion();
            if (numero1 >= numero2)
            {
                resultado = true;
            }
            else
            {
                resultado = false;
            }

            lblresultado.Text = resultado.ToString();
        }

        private void btnmenorigual_Click(object sender, EventArgs e)
        {
            MenorIgualQue();
        }

        private void MenorIgualQue()
        {
            Asignacion();
            if (numero1 <= numero2)
            {
                resultado = true;
            }
            else
            {
                resultado = false;
            }

            lblresultado.Text = resultado.ToString();
        }

        private void btnigual_Click(object sender, EventArgs e)
        {
            IgualQue();
        }

        private void IgualQue()
        {
            Asignacion();
            if (numero1 == numero2)
            {
                resultado = true;
            }
            else
            {
                resultado = false;
            }

            lblresultado.Text = resultado.ToString();
        }

        private void btndiferente_Click(object sender, EventArgs e)
        {
            DiferenteQue();
        }

        private void DiferenteQue()
        {
            Asignacion();
            if (numero1 != numero2)
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

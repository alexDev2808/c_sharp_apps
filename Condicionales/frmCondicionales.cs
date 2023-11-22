using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CursoCSharp.Condicionales
{
    public partial class frmCondicionales : Form
    {
        public frmCondicionales()
        {
            InitializeComponent();
        }

        double numero;


        private void AsignarValores()
        {
            numero = double.Parse(txtNum.Text, CultureInfo.InvariantCulture);
        }


        private void Calcular()
        {
            if (numero == 0)
            {
                lblRes.Text = "Es un cero";
            }
            else if(numero > 0)
            {
                lblRes.Text = "Es un numero positivo";
            }
            else
            {
                lblRes.Text = "Es un numero negativo";
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            AsignarValores();
            Calcular();
        }
    }
}

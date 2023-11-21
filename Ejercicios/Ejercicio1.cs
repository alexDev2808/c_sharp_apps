using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CursoCSharp.Ejercicios
{
    public partial class Ejercicio1 : UserControl
    {
        public Ejercicio1()
        {
            InitializeComponent();
        }

        double a;
        double b;
        double c;
        double resultado;
        public string titulo;

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            AsignarDatos();
            Calcular();
        }

        private void AsignarDatos()
        {
            a = Convert.ToDouble(txta.Text);
            b = Convert.ToDouble(textb.Text);
            c = Convert.ToDouble(textc.Text);
        }

        private void Calcular()
        {
            resultado = ((c + 5) * (Math.Pow(b, 2) - (3 * a * c))) * Math.Pow(a, 2) / (4 * a);
            lblresultado.Text = resultado.ToString();
        }

        private void Ejercicio1_Load(object sender, EventArgs e)
        {
            lblEjercicio.Text = titulo;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}

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

namespace CursoCSharp.Ejercicios
{
    public partial class Ejercicio3 : UserControl
    {
        public Ejercicio3()
        {
            InitializeComponent();
        }

        double peso;
        double altura;
        double imc;
        public string titulo;

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            AsignarDatos();
            calcularIMC();
            Condicion();
        }

        private void AsignarDatos()
        {
           
            peso = double.Parse(txtPeso.Text, CultureInfo.InvariantCulture);
            altura = double.Parse(txtAltura.Text, CultureInfo.InvariantCulture);

        }

        private void calcularIMC()
        {

            imc = peso / Math.Pow(altura, 2);

            lblIMCRes.Text = imc.ToString(("N2"));

        }

        private void Ejercicio3_Load(object sender, EventArgs e)
        {
            lblEjercicio3.Text = titulo;
        }


        private void Condicion()
        {
            if (imc < 18.5)
            {
                lblCondicion.Text = "Por debajo de lo ideal.";
            }
            else if(imc >= 18.5 && imc <= 24.9)
            {
                lblCondicion.Text = "Peso Normal. Sigue asi.";
            }
            else if(imc > 24.9 && imc <= 29.9)
            {
                lblCondicion.Text = "Sobrepeso. Deberias consultar un medico";
            }
            else
            {
                lblCondicion.Text = "Obesidad. Necesitas ser tratado por un medico.";
            }
        }
    }
}

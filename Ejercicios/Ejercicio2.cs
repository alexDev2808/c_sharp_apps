using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CursoCSharp.Ejercicios
{
    public partial class Ejercicio2 : UserControl
    {
        public Ejercicio2()
        {
            InitializeComponent();
        }


        double radio;
        double area;
        double pi = Math.PI;
        double longitud;
        public string titulo;

        private void AsignacionDatos()
        {
            area = Convert.ToDouble(txtArea.Text);
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            AsignacionDatos();
            obtenerRadio();
            obtenerLongitud();
        }

        private void obtenerRadio()
        {
            radio = Math.Sqrt(area / pi);
            lblRadioResult.Text = radio.ToString(("N2"));
        }

        private void obtenerLongitud()
        {
            longitud = 2 * pi * radio;
            lblLonResult.Text = longitud.ToString(("N2"));
        }

        private void Ejercicio2_Load(object sender, EventArgs e)
        {
            lblEjercicio2.Text = titulo;
        }

    }
}

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
    public partial class Ejercicio4_Condicionales : UserControl
    {
        public Ejercicio4_Condicionales()
        {
            InitializeComponent();
        }

        public string titulo;

        private void Ejercicio4_Condicionales_Load(object sender, EventArgs e)
        {
            lblTitulo4.Text = titulo;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Calcular();
        }

        private void Calcular()
        {
            int total = 0;
            string detalle = "";

            if (rbLarge.Checked)
            {
                total += 190;
                detalle += "Talla: Large \r\n";
            }
            if (rbMedium.Checked)
            {
                total += 149;
                detalle += "Talla: Medium \r\n";
            }
            if (rbSmall.Checked)
            {
                total += 99;
                detalle += "Talla: Small \r\n";
            }

            if (rbRojo.Checked)
            {
                total += 10;
                detalle += "Color: Rojo";
            }
            if (rbNaranja.Checked)
            {
                total += 15;
                detalle += "Color: Naranja";
            }
            if (rbAzul.Checked)
            {
                total += 20;
                detalle += "Color: Azul";
            }
            detalle += "\r\n\nEl total a pagar es $" + total + " MXN";
            tbPreview.Text = detalle;

        }
    }
}

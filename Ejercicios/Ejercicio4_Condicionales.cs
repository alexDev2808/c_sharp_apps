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

    }
}

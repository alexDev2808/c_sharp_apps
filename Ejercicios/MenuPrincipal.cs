using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CursoCSharp.Ejercicios;

namespace CursoCSharp.Ejercicios
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void btnE1_Click(object sender, EventArgs e)
        {
            Ejercicio1();
        }

        private void Ejercicio1()
        {
            Ejercicio1 ctl = new Ejercicio1();
            ctl.titulo = btnE1.Text;
            ctl.Dock = DockStyle.Fill;
            panelVisor.Controls.Add(ctl);
            ctl.Show();

        }
    }
}

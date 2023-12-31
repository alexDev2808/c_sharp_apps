﻿using System;
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
            panelVisor.Controls.Clear();
            Ejercicio1 ctl = new Ejercicio1();
            ctl.titulo = btnE1.Text;
            ctl.Dock = DockStyle.Fill;
            panelVisor.Controls.Add(ctl);
            ctl.Show();

        }

        private void btnE2_Click(object sender, EventArgs e)
        {
            Ejercicio2();
        }

        private void Ejercicio2()
        {
            panelVisor.Controls.Clear();
            Ejercicio2 ctl = new Ejercicio2();
            ctl.titulo = btnE2.Text;
            ctl.Dock = DockStyle.Fill;
            panelVisor.Controls.Add(ctl);
            ctl.Show();
        }

        private void btnE3_Click(object sender, EventArgs e)
        {
            Ejercicio3();
        }

        private void Ejercicio3()
        {
            panelVisor.Controls.Clear();
            Ejercicio3 ctl = new Ejercicio3();
            ctl.titulo = btnE3.Text;
            ctl.Dock = DockStyle.Fill;
            panelVisor.Controls.Add(ctl);
            ctl.Show();
        }

        private void btnE4_Click(object sender, EventArgs e)
        {
            Ejercicio4();
        }

        private void Ejercicio4()
        {
            panelVisor.Controls.Clear();
            Ejercicio4_Condicionales ctl = new Ejercicio4_Condicionales();
            ctl.titulo = btnE4.Text;
            ctl.Dock = DockStyle.Fill;
            panelVisor.Controls.Add(ctl);
            ctl.Show();
        }

        private void btnE5_Click(object sender, EventArgs e)
        {
            Ejercicio5();
        }

        private void Ejercicio5()
        {
            panelVisor.Controls.Clear();
            Ejercicio5_Condicionales ctl = new Ejercicio5_Condicionales();
            ctl.titulo = btnE5.Text;
            ctl.Dock = DockStyle.Fill;
            panelVisor.Controls.Add(ctl);
            ctl.Show();
        }
    }
}

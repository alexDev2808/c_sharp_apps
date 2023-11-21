using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CursoCSharp
{
    public partial class Form1 : Form
    {
        public Form1() // constructor
        {
            InitializeComponent();
        }

        private void lblHolaMundo_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Console.WriteLine("Hola Mundo");
            Console.ReadLine();
        }
    }
}

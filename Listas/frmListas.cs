using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CursoCSharp.Listas
{
    public partial class frmListas_Arrays : Form
    {
        public frmListas_Arrays()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //agregarLista();
            agregarArray();
        }

        private void agregarLista()
        {
            List<string> nombres = new List<string>();
            nombres.Add("Alexis");
            nombres.Add("Jesus");
            nombres.Add("Ruby");
            nombres.Add("Tania");
            nombres.Add("Brenda");

            foreach (string nombre in nombres)
            {
                lbListasArrays.Items.Add(nombre);
            }
        }

        private void agregarArray()
        {
            string[] names = { "Alexis", "Jesus", "Ruby", "Fernanda", "Brenda" };
            
            
            foreach (string nombre in names)
            {
                lbListasArrays.Items.Add(nombre);
            }


        }

        private void frmListas_Arrays_Load(object sender, EventArgs e)
        {
            char[] numeros;
            numeros = "1234567890".ToCharArray();

            panelNumerico.Controls.Clear();

            foreach(char numero in numeros)
            {
                Button btnNum = new Button();
                btnNum.Text = numero.ToString();
                btnNum.Size = new Size(72, 72);
                btnNum.FlatStyle = FlatStyle.Flat;
                btnNum.ForeColor = Color.FromArgb(45, 149, 150);
                btnNum.FlatAppearance.BorderSize = 3;

                panelNumerico.Controls.Add(btnNum);

                btnNum.Click += BtnNum_Click;
            }
        }

        private void BtnNum_Click(object sender, EventArgs e)
        {
            //throw new NotImplementedException();

            string numero = ((Button)sender).Text;
            tbPantalla.Text += numero;
        }
    }
}

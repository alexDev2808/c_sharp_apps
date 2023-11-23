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
    public partial class Ejercicio5_Condicionales : UserControl
    {
        public Ejercicio5_Condicionales()
        {
            InitializeComponent();
        }

        public string titulo;
        int num1;
        int num2;
        string resultado;

        private void btnComprobar_Click(object sender, EventArgs e)
        {
            AsignarValores();
            Calcular();
        }

        private void AsignarValores()
        {
            num1 = Convert.ToInt32(tbNum1.Text);
            num2 = Convert.ToInt32(tbNum2.Text);
        }

        private void Calcular()
        {
            if (num1 % 2 == 0 && num2 % 2 == 0)
            {
                resultado += "Ambos numeros son pares\r\n";
            }
            
            if(num1 % 2 == 0)
            {
                resultado += $"El numero {num1} es par\r\n";
            }
            else
            {
                resultado += $"El numero {num1} es impar\r\n";
            }

            if (num2 % 2 == 0)
            {
                resultado += $"El numero {num2} es par\r\n";
            }
            else
            {
                resultado += $"El numero {num2} es impar\r\n";
            }

            tbRes.Text = resultado;
        }
    }
}

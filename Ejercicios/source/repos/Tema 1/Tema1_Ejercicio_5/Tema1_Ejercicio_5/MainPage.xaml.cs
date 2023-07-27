using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Tema1_Ejercicio_5
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void B1_Clicked(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(E1.Text);
            int num2 = Convert.ToInt32(E2.Text);

            int resta = num2 - num1;
            double resultado = 0;
            string numeros = "";
            for (int i = 0; i <= resta; i++)
            {
                if (num1 <= num2)
                    resultado = num1 % 2;
                if (resultado != 0)
                    Console.WriteLine(num1 + " es impar");
                else
                   numeros = numeros + " " + Convert.ToString(num1);
                num1 = num1 + 1;
            }
            L1.Text = numeros;
        }
    }
}

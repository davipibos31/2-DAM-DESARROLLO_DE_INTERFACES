using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Tema1_Ejercicio_3
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Suma_Clicked(object sender, EventArgs e)
        {
            int numero1 = Convert.ToInt32(num1.Text);
            int numero2 = Convert.ToInt32(num2.Text);
            int resultado = 0;

            if (num1.Text != null && num1.Text != null)
                resultado = numero1 + numero2;
            Resultado_final.Text = resultado.ToString();
        }

        private void Resta_Clicked(object sender, EventArgs e)
        {
            int numero1 = Convert.ToInt32(num1.Text);
            int numero2 = Convert.ToInt32(num2.Text);
            int resultado = 0;

            if (num1.Text != null && num1.Text != null)
                resultado = numero1 - numero2;
            Resultado_final.Text = resultado.ToString();
        }

        private void Multiplicacion_Clicked(object sender, EventArgs e)
        {
            int numero1 = Convert.ToInt32(num1.Text);
            int numero2 = Convert.ToInt32(num2.Text);
            int resultado = 0;

            if (num1.Text != null && num1.Text != null)
                resultado = numero1 * numero2;
            Resultado_final.Text = resultado.ToString();
        }

        private void Division_Clicked(object sender, EventArgs e)
        {
            int numero1 = Convert.ToInt32(num1.Text);
            int numero2 = Convert.ToInt32(num2.Text);
            int resultado = 0;
            try
            {
                if (num1.Text != null && num1.Text != null)
                    resultado = numero1 / numero2;
                Resultado_final.Text = resultado.ToString();
            }
            catch (Exception)
            {
                Resultado_final.Text = "No se puede dividir";
            }
        }
    }
}

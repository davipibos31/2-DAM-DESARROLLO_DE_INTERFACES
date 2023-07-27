using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Tema1_Ejercicio_2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void B1_Clicked(object sender, EventArgs e)
        {
            if (L1.Text == "Hola")
                L1.Text = "Mundo";
            else
                L1.Text = "Hola";
        }
    }
}

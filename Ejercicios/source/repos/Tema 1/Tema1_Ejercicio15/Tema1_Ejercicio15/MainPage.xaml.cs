using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Tema1_Ejercicio15
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void B1_Clicked(object sender, EventArgs e)
        {

            imagen1.IsVisible = true;
            imagen2.IsVisible = false;
            imagen3.IsVisible = false;
        }

        private void B2_Clicked(object sender, EventArgs e)
        {

            imagen1.IsVisible = false;
            imagen2.IsVisible = true;
            imagen3.IsVisible = false;
        }

        private void B3_Clicked(object sender, EventArgs e)
        {

            imagen1.IsVisible = false;
            imagen2.IsVisible = false;
            imagen3.IsVisible = true;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Tema1_Ejercicio16
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        bool fuera = false;
        private void b1_Clicked(object sender, EventArgs e)
        {
            
            switch (cont) {
                case 0:
                    imagen1.IsVisible = true;
                    imagen2.IsVisible = false;
                    imagen3.IsVisible = false;
                    cont++;
                    break;
                case 1:
                    imagen2.IsVisible = true;
                    imagen1.IsVisible = false;
                    imagen3.IsVisible = false;
                    cont++;
                    break;
                case 2:
                    imagen3.IsVisible = true;
                    imagen1.IsVisible = false;
                    imagen2.IsVisible = false;
                    cont = 0;
                    break;
            }
            cont2 = cont;
        }
        public static int cont = 0;
        public static int cont2 = cont;
        private void b2_Clicked(object sender, EventArgs e)
        {
            switch (cont2)
            {
                case 0:
                    imagen1.IsVisible = true;
                    imagen2.IsVisible = false;
                    imagen3.IsVisible = false;
                    cont2++;
                    break;
                case 1:
                    imagen2.IsVisible = true;
                    imagen1.IsVisible = false;
                    imagen3.IsVisible = false;
                    cont2++;
                    break;
                case 2:
                    imagen3.IsVisible = true;
                    imagen1.IsVisible = false;
                    imagen2.IsVisible = false;
                    cont2 =0;
                    break;
            }
            cont = cont2;
        }
    }
}
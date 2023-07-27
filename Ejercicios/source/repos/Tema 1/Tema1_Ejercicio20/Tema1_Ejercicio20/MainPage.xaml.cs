using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Tema1_Ejercicio20
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void bborrar_Clicked(object sender, EventArgs e)
        {
            Random r = new Random();
            int Red = r.Next(250);
            int Blue = r.Next(250);
            int Green = r.Next(250);
            Label l1 = new Label();
           // BackgroundColor = Color.FromRgb();
        }

        private void bañadir_Clicked(object sender, EventArgs e)
        {

        }
    }
}

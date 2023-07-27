using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Tema1_Ejercicio7
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

            for (int i = 0; i < num1; i++)
            {
                Label l = new Label();
                l.Text = "Hola Mundo!";
                lMiStackLayout.Children.Add(l);
            }
        }
    }
}

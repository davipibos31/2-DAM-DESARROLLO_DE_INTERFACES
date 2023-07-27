using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Tema1_Ejercicio19
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void b1_Clicked(object sender, EventArgs e)
        {
            BV1.BackgroundColor = Color.Green;
        }

        private void b2_Clicked(object sender, EventArgs e)
        {
            BV1.BackgroundColor = Color.Red;
        }

        private void b3_Clicked(object sender, EventArgs e)
        {
            BV1.BackgroundColor = Color.Blue;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Tema1_Ejercicio_4
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void E1_TextChanged(object sender, TextChangedEventArgs e)
        {
            l1.Text = E1.Text;
            if (l1.Text.Length < 5)
                l1.TextColor = Color.Red;
            else if (l1.Text.Length >= 5 && l1.Text.Length <= 10)
                l1.TextColor = Color.Black;
            else if (l1.Text.Length > 10)
                l1.TextColor = Color.Red;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Ejercicio2Examen
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void CheckRojo_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            if (CheckRojo.IsChecked)
                LabelRojo2.IsVisible = true;
            else
                LabelRojo2.IsVisible = false;

        }

        private void CheckVerde_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            if (CheckVerde.IsChecked)
                LabelVerde2.IsVisible = true;
            else
                LabelVerde2.IsVisible = false;
        }

        private void CheckAzul_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            if (CheckAzul.IsChecked)
                LabelAzul2.IsVisible = true;
            else
                LabelAzul2.IsVisible = false;
        }
    }
}

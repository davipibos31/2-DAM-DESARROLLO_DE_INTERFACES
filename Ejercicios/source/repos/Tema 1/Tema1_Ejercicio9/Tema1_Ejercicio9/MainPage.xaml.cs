using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Tema1_Ejercicio9
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            
            Label L1 = new Label();
            L1.Text = "Ejercicio 8";
            L1.VerticalTextAlignment = TextAlignment.Start;
            L1.TextColor = Color.Black;
            L1.BackgroundColor = Color.Red;
            L1.HorizontalTextAlignment = TextAlignment.Center;
            L1.FontSize = 28;

            Label L2 = new Label();
            L2.Text = "Label";
            L2.BackgroundColor = Color.Blue;
            L2.VerticalOptions = LayoutOptions.CenterAndExpand;
            L2.HorizontalOptions = LayoutOptions.CenterAndExpand;
            L2.FontSize = 28;

            Button B1 = new Button();
            B1.Text = "BOTON";
            B1.BackgroundColor = Color.Gray;
            B1.VerticalOptions = LayoutOptions.EndAndExpand;
            B1.HorizontalOptions = LayoutOptions.EndAndExpand;


            principal.Children.Add(L1);
            principal.Children.Add(L2);
            principal.Children.Add(B1);


        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Tema1_Ejercicio14
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void BotonAñadir_Clicked(object sender, EventArgs e)
        {
            Random r1 = new Random();
            int c1 = r1.Next(1, 255);
            int c2 = r1.Next(1, 255);
            int c3 = r1.Next(1, 255);

            StackLayout SL = new StackLayout();
            SL.Orientation = StackOrientation.Horizontal;

            Label L1 = new Label();
            L1.Text = "Label";
            L1.FontSize = 20;
            L1.HorizontalOptions = LayoutOptions.StartAndExpand;
            L1.VerticalOptions = LayoutOptions.EndAndExpand;
            L1.BackgroundColor = Color.FromRgb(c1,c2,c3);
            L1.WidthRequest = 195;

            c1 = r1.Next(1, 255);
            c2 = r1.Next(1, 255);
            c3 = r1.Next(1, 255);

            Label L2 = new Label();
            L2.Text = "Label";
            L2.FontSize = 20;
            L2.HorizontalOptions = LayoutOptions.StartAndExpand;
            L2.VerticalOptions = LayoutOptions.EndAndExpand;
            L2.BackgroundColor = Color.FromRgb(c1, c2, c3);
            L2.WidthRequest = 190;

            SL.Children.Add(L1);
            SL.Children.Add(L2);

            Principal.Children.Add(SL);
        }
    }
}
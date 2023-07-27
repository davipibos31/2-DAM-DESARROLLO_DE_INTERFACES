using System;
using System.Collections.Generic;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Practica3.Views
{
    public partial class Articulos : ContentPage
    {
        public Articulos()
        {
            
            InitializeComponent();

            listar.Add("Articulo 1");
            listar.Add("Articulo 2");
            listar.Add("Articulo 3");
            listar.Add("Articulo 4");

            listArticulos.ItemsSource = listar;
            listArticulos.SelectedItem = null;
            
        }
        public static List<string> listar = new List<string>();
        private async void listArticulos_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Articulo_1.Sl1.Children.Clear();
            Articulo_1.Sl2.Children.Clear();
            Articulo_1.Sl3.Children.Clear();
            Articulo_1.Sl4.Children.Clear();
            Articulo_1.Sl5.Children.Clear();

            Articulo2.Sl1.Children.Clear();
            Articulo2.Sl2.Children.Clear();
            Articulo2.Sl3.Children.Clear();
            Articulo2.Sl4.Children.Clear();
            Articulo2.Sl5.Children.Clear();

            Articulo_3.Sl1.Children.Clear();
            Articulo_3.Sl2.Children.Clear();
            Articulo_3.Sl3.Children.Clear();
            Articulo_3.Sl4.Children.Clear();
            Articulo_3.Sl5.Children.Clear();

            Articulo_4.Sl1.Children.Clear();
            Articulo_4.Sl2.Children.Clear();
            Articulo_4.Sl3.Children.Clear();
            Articulo_4.Sl4.Children.Clear();
            Articulo_4.Sl5.Children.Clear();
            ListView lisq = (ListView)sender;

            if (lisq.SelectedItem.Equals(listar[0]))
            {
                await Navigation.PushAsync(new Articulo_1());
            }
            else if (lisq.SelectedItem.Equals(listar[1]))
            {
                await Navigation.PushAsync(new Articulo2());
            }
            else if (lisq.SelectedItem.Equals(listar[2]))
            {
                await Navigation.PushAsync(new Articulo_3());
            }
            else if (lisq.SelectedItem.Equals(listar[3]))
            {
                await Navigation.PushAsync(new Articulo_4());
            }
        }
    }
}
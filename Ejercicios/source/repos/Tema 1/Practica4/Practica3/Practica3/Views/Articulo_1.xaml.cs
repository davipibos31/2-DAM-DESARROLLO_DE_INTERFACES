using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Practica3.Views
{
    public partial class Articulo_1 : ContentPage
    {
        public static int a = 48;
        public static StackLayout Sl1 = new StackLayout();
        public static StackLayout Sl2 = new StackLayout();
        public static StackLayout Sl3 = new StackLayout();
        public static StackLayout Sl4 = new StackLayout();
        public static StackLayout Sl5 = new StackLayout();
        public Articulo_1()
        {
            InitializeComponent();

            Principal.Children.Clear();

            Button Datos = new Button();
            Datos.Text = "Datos";
            Datos.AutomationId = "MyButton";
            Datos.Margin = 3;
            Datos.FontSize = 18;
            Datos.HorizontalOptions = LayoutOptions.FillAndExpand;
            Datos.BackgroundColor = Color.Gray;
            Datos.Clicked += Datos_Clicked;


            Button Opiniones = new Button();
            Opiniones.Text = "Opiniones";
            Opiniones.Margin =  3;
            Opiniones.FontSize = 18;
            Opiniones.HorizontalOptions = LayoutOptions.FillAndExpand;
            Opiniones.BackgroundColor = Color.Gray;
            Opiniones.Clicked += Opiniones_Clicked;

           
            Sl1.Orientation = StackOrientation.Horizontal;
            Sl1.Children.Add(Datos);
            Sl1.Children.Add(Opiniones);


            Label ldesc = new Label();
            ldesc.Text = "Descripción del articulo: " + Articulos.listar[0];
            ldesc.FontSize = 18;
            ldesc.Margin = 10;


            Label ldescart = new Label();
            ldescart.Text = "Esto es la descripción del articulo " + Articulos.listar[0];
            ldescart.FontSize = 14;
            ldescart.Margin = 10;


            Sl2.Orientation = StackOrientation.Vertical;
            Sl2.HeightRequest = 500;
            Sl2.Children.Add(ldesc);
            Sl2.Children.Add(ldescart);
            Sl2.IsVisible = false;

            Label precio = new Label();
            precio.Text = "Precio : " + a + "€";
            precio.FontSize = 20;
            precio.Margin = 20;


            Sl3.Orientation = StackOrientation.Horizontal;
            Sl3.HorizontalOptions = LayoutOptions.EndAndExpand;
            Sl3.VerticalOptions = LayoutOptions.EndAndExpand;
            Sl3.Children.Add(precio);
            Sl3.IsVisible = false;

            Button Añadir = new Button();
            Añadir.Text = "Añadir al Carrito";
            Añadir.FontSize = 20;
            Añadir.Margin = 20;
            Añadir.BackgroundColor = Color.Gray;
            Añadir.Clicked += Añadir_Clicked;


            Sl4.Orientation = StackOrientation.Horizontal;
            Sl4.HorizontalOptions = LayoutOptions.End;
            Sl4.VerticalOptions = LayoutOptions.EndAndExpand;
            Sl4.Children.Add(Añadir);
            Sl4.IsVisible = false;

            Label lop1 = new Label();
            lop1.Text = "Opinión 1";
            lop1.FontSize = 18;
            lop1.HorizontalOptions = LayoutOptions.StartAndExpand;
            lop1.Margin = 10;
            

            Label lop2 = new Label();
            lop2.Text = "Opinión 2";
            lop2.FontSize = 18;
            lop2.HorizontalOptions = LayoutOptions.StartAndExpand;
            lop2.Margin = 10;


            Label lop3 = new Label();
            lop3.Text = "Opinión 3";
            lop3.FontSize = 18;
            lop3.HorizontalOptions = LayoutOptions.StartAndExpand;
            lop3.Margin = 10;



            Label lop4 = new Label();
            lop4.Text = "Opinión 4";
            lop4.FontSize = 18;
            lop4.HorizontalOptions = LayoutOptions.StartAndExpand;
            lop4.Margin = 10;


            Sl5.Margin = 20;
            Sl5.Children.Add(lop1);
            Sl5.Children.Add(lop2);
            Sl5.Children.Add(lop3);
            Sl5.Children.Add(lop4);
            Sl5.IsVisible = false;
            

            Principal.Children.Add(Sl1);
            Principal.Children.Add(Sl2);
            Principal.Children.Add(Sl3);
            Principal.Children.Add(Sl4);
            Principal.Children.Add(Sl5);


        }
        public static int res = 0;
        private void Añadir_Clicked(object sender, EventArgs e)
        {
            Label l1 = new Label();
            l1.Text = Articulos.listar[0];
            l1.FontSize = 22;
            l1.HorizontalOptions= LayoutOptions.StartAndExpand;
            l1.Margin = 10;
            res = ItemsPage.resultadoFinal;
            ItemsPage.Sl.Children.Add(l1);
           // ItemsPage.resultadoFinal += res += a;
            Label l2 = new Label();
            l2.Text = "Total: " + (ItemsPage.resultadoFinal = res += a) + "€";
            l2.Margin = 30;
            l2.HorizontalOptions = LayoutOptions.EndAndExpand;
            l2.FontSize = 24;
            ItemsPage.Sl4.Children.Clear();
            ItemsPage.Sl4.Children.Add(l2);

        }

        private void Opiniones_Clicked(object sender, EventArgs e)
        {
            Principal.Children.Clear();
            Principal.Children.Add(Sl1);
            Principal.Children.Add(Sl2);
            Principal.Children.Add(Sl3);
            Principal.Children.Add(Sl4);
            Principal.Children.Add(Sl5);
            Sl2.IsVisible = false;
            Sl3.IsVisible = false;
            Sl4.IsVisible = false;
            Sl5.IsVisible = true;
        }

        private void Datos_Clicked(object sender, EventArgs e)
        {
            Principal.Children.Clear();
            Principal.Children.Add(Sl1);
            Principal.Children.Add(Sl2);
            Principal.Children.Add(Sl3);
            Principal.Children.Add(Sl4);
            Principal.Children.Add(Sl5);
            Sl2.IsVisible = true;
            Sl3.IsVisible = true;
            Sl4.IsVisible = true;
            Sl5.IsVisible = false;
        }
    }
}
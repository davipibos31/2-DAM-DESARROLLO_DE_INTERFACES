using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace Practica1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

        }

        private void btneditar_Clicked(object sender, EventArgs e)
        {
            Label l1 = new Label();
            l1.Text = "Text: ";
            l1.FontSize = 14;
            l1.HorizontalOptions = LayoutOptions.CenterAndExpand;
            l1.Padding = 10;
            l1.VerticalOptions = LayoutOptions.StartAndExpand;
            
            E1 = new Entry();
            E1.Text = "";
            E1.FontSize = 14;
            E1.HorizontalOptions = LayoutOptions.CenterAndExpand;
            E1.WidthRequest = 300;
            E1.TextChanged += E1_TextChanged;

            SL1 = new StackLayout();
            SL1.Orientation = StackOrientation.Horizontal;
            SL1.VerticalOptions = LayoutOptions.EndAndExpand;

            SL1.HorizontalOptions = LayoutOptions.StartAndExpand;

            SL1.Children.Add(l1);
            SL1.Children.Add(E1);

            //////////////////////////////////////

            SL2 = new StackLayout();
            SL2.Orientation = StackOrientation.Vertical;
            SL2.VerticalOptions = LayoutOptions.Start;
            SL2.HorizontalOptions = LayoutOptions.StartAndExpand;

            Label l2 = new Label();
            l2.Text = "Priority: ";
            l2.FontSize = 14;
            l2.HorizontalOptions = LayoutOptions.StartAndExpand;
            l2.Padding = 10;
            l2.VerticalOptions = LayoutOptions.StartAndExpand;

            SL2.Children.Add(l2);

            //////////////////
            
            SL3 = new StackLayout();
            SL3.Orientation = StackOrientation.Horizontal;
            SL3.VerticalOptions = LayoutOptions.Start;
            SL3.HorizontalOptions = LayoutOptions.StartAndExpand;

            cbx1 = new CheckBox();
            cbx1.HorizontalOptions = LayoutOptions.Start;

            Label l3 = new Label();
            l3.Text = "High ";
            l3.FontSize = 14;
            l3.HorizontalOptions = LayoutOptions.StartAndExpand;
            l3.Padding = 10;
            l3.VerticalOptions = LayoutOptions.StartAndExpand;

            //////////////////////

            SL4 = new StackLayout();
            SL4.Orientation = StackOrientation.Horizontal;
            SL4.VerticalOptions = LayoutOptions.Start;
            SL4.HorizontalOptions = LayoutOptions.StartAndExpand;

            cbx2 = new CheckBox();
            cbx2.HorizontalOptions = LayoutOptions.Start;

            Label l4 = new Label();
            l4.Text = "Medium ";
            l4.FontSize = 14;
            l4.HorizontalOptions = LayoutOptions.StartAndExpand;
            l4.Padding = 10;
            l4.VerticalOptions = LayoutOptions.StartAndExpand;

            //////////////////////

            SL5 = new StackLayout();
            SL5.Orientation = StackOrientation.Horizontal;
            SL5.VerticalOptions = LayoutOptions.Start;
            SL5.HorizontalOptions = LayoutOptions.StartAndExpand;

            cbx3 = new CheckBox();
            cbx3.HorizontalOptions = LayoutOptions.Start;

            Label l5 = new Label();
            l5.Text = "Low ";
            l5.FontSize = 14;
            l5.HorizontalOptions = LayoutOptions.StartAndExpand;
            l5.Padding = 10;
            l5.VerticalOptions = LayoutOptions.StartAndExpand;

            //////////////////////

            SL6 = new StackLayout();
            SL6.Orientation = StackOrientation.Horizontal;
            SL6.VerticalOptions = LayoutOptions.Start;
            SL6.HorizontalOptions = LayoutOptions.StartAndExpand;

            Button banadir = new Button();
            banadir.Text = "ADD";
            banadir.HorizontalOptions = LayoutOptions.StartAndExpand;
            banadir.VerticalOptions = LayoutOptions.EndAndExpand;
            banadir.WidthRequest = 395;
            banadir.Clicked += bañadir_Clicked;

            //////////////////////

            SL9 = new StackLayout();
            SL9.Orientation = StackOrientation.Horizontal;
            SL9.VerticalOptions = LayoutOptions.Start;
            SL9.HorizontalOptions = LayoutOptions.StartAndExpand;


            Button beliminar = new Button();
            beliminar.Text = "Borrar";
            beliminar.HorizontalOptions = LayoutOptions.StartAndExpand;
            beliminar.VerticalOptions = LayoutOptions.EndAndExpand;
            beliminar.WidthRequest = 395;
            beliminar.Clicked += beliminar_Clicked;


            /////////////////////

            SL7 = new StackLayout();
            SL7.Orientation = StackOrientation.Horizontal;
            SL7.VerticalOptions = LayoutOptions.Start;
            SL7.HorizontalOptions = LayoutOptions.StartAndExpand;

            Button bcerrar = new Button();
            bcerrar.Text = "CLOSED";
            bcerrar.HorizontalOptions = LayoutOptions.StartAndExpand;
            bcerrar.VerticalOptions = LayoutOptions.EndAndExpand;
            bcerrar.WidthRequest = 395;
            bcerrar.Clicked += bcerrar_Clicked;

            SL3.Children.Add(cbx1);
            SL3.Children.Add(l3);
            SL4.Children.Add(cbx2);
            SL4.Children.Add(l4);
            SL5.Children.Add(cbx3);
            SL5.Children.Add(l5);
            SL6.Children.Add(banadir);
            SL9.Children.Add(beliminar);
            SL7.Children.Add(bcerrar);

            Principal.Children.Add(SL1);
            Principal.Children.Add(SL2);
            Principal.Children.Add(SL3);
            Principal.Children.Add(SL4);
            Principal.Children.Add(SL5);
            Principal.Children.Add(SL6);
            Principal.Children.Add(SL9);
            Principal.Children.Add(SL7);
            Principal.Children.Remove(btneditar);
        }

        public static StackLayout SL1;
        public static StackLayout SL2;
        public static StackLayout SL3;
        public static StackLayout SL4;
        public static StackLayout SL5;
        public static StackLayout SL6;
        public static StackLayout SL7;
        public static StackLayout SL9;
        public static Entry E1;
        public static CheckBox cbx1;
        public static CheckBox cbx2;
        public static CheckBox cbx3;

        public void E1_TextChanged(object sender, TextChangedEventArgs e) {
            if (cbx1.IsChecked == true)
            {
                E1.TextColor = Color.Red;
            }
            else if (cbx2.IsChecked == true)
            {
                E1.TextColor = Color.Gray;
            }
            else if (cbx3.IsChecked == true)
            {
                E1.TextColor = Color.YellowGreen;
            }
        }
        public void bañadir_Clicked(object sender, EventArgs e) {
            if (E1.Text == "" && cbx1.IsChecked == false && cbx2.IsChecked == false && cbx3.IsChecked == false)
            {
                Principal.Children.Add(titulo);
                Principal.Children.Add(btneditar);

                Principal.Children.Remove(SL1);
                Principal.Children.Remove(SL2);
                Principal.Children.Remove(SL3);
                Principal.Children.Remove(SL4);
                Principal.Children.Remove(SL5);
                Principal.Children.Remove(SL6);
                Principal.Children.Remove(SL7);
                Principal.Children.Remove(SL9);
            }
            else {
                Principal.Children.Add(titulo);
                Principal.Children.Remove(SL1);
                Principal.Children.Remove(SL2);
                Principal.Children.Remove(SL3);
                Principal.Children.Remove(SL4);
                Principal.Children.Remove(SL5);
                Principal.Children.Remove(SL6);
                Principal.Children.Remove(SL7);
                Principal.Children.Remove(SL9);


                SL8 = new StackLayout();
                SL8.Orientation = StackOrientation.Horizontal;
                SL8.VerticalOptions = LayoutOptions.Start;
                SL8.HorizontalOptions = LayoutOptions.StartAndExpand;

                cbx4 = new CheckBox();
                cbx4.HorizontalOptions = LayoutOptions.Start;
                cbx4.CheckedChanged += Cbx4_CheckedChanged;

                array = new ArrayList();

                array.Add(E1.Text);
                
                Label l6 = new Label();
                l6.Text = array[0].ToString();
                l6.FontSize = 14;
                l6.HorizontalOptions = LayoutOptions.StartAndExpand;
                l6.Padding = 10;
                l6.VerticalOptions = LayoutOptions.StartAndExpand;
                if (cbx1.IsChecked == true)
                {
                    l6.TextColor = Color.Red;
                }
                else if (cbx2.IsChecked == true)
                {
                    l6.TextColor = Color.Gray;
                }
                else if (cbx3.IsChecked == true)
                {
                    l6.TextColor = Color.YellowGreen;
                }

                ++count;
                
                SL8.Children.Add(cbx4);
                SL8.Children.Add(l6);

                Principal.Children.Add(SL8);
                Principal.Children.Add(btneditar);

                list = new ArrayList();

                list.Add(SL8);
            }
            titulo.Text = "Number of task: " + count;
        }

        public static CheckBox lb;
        

        private void Cbx4_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            CheckBox lb = (CheckBox)sender;
            if (lb.IsChecked == true)
            {
                num_cbx++;
                titulo.Text = "Number of task: " + num_cbx + "/" + count;
            }
            else {
                num_cbx--;
                if (num_cbx == 0)
                    titulo.Text = "Number of task: " + count;
                else 
                    titulo.Text = "Number of task: " + num_cbx + "/" + count;
            }
        }

        public static CheckBox cbx4;
        public static StackLayout SL8;
        public static ArrayList list;
        public static ArrayList array;
        public static int count = 0;
        public static int num_cbx = 0;
        public static CheckedChangedEventArgs checkevent;
        public void bcerrar_Clicked(object sender, EventArgs e)
        {
            Principal.Children.Add(titulo);
            Principal.Children.Add(btneditar);

            Principal.Children.Remove(SL1);
            Principal.Children.Remove(SL2);
            Principal.Children.Remove(SL3);
            Principal.Children.Remove(SL4);
            Principal.Children.Remove(SL5);
            Principal.Children.Remove(SL6);
            Principal.Children.Remove(SL7);
            Principal.Children.Remove(SL9);
        }


        public void beliminar_Clicked(object sender, EventArgs e)
        {
            
            
        }
    }
}

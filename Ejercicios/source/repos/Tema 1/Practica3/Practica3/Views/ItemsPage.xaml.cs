using Practica3.Models;
using Practica3.ViewModels;
using Practica3.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using static System.Net.Mime.MediaTypeNames;

namespace Practica3.Views
{
    public partial class ItemsPage : ContentPage
    {
        public static StackLayout Sl = new StackLayout();
        public static StackLayout Sl4 = new StackLayout();
        ItemsViewModel _viewModel;
        public static int resultadoFinal;
        public ItemsPage()
        {
            InitializeComponent();
            SL3.Children.Add(Sl);

            BindingContext = _viewModel = new ItemsViewModel();

            Label l1 = new Label();
            l1.Text = "Total: " + resultadoFinal + "€";
            l1.Margin = 30;
            l1.HorizontalOptions = LayoutOptions.EndAndExpand;
            l1.FontSize = 24;
            
            Sl1.Children.Add(Sl4);
            Sl4.Children.Clear();
            Sl4.Children.Add(l1);

        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            _viewModel.OnAppearing();
        }
    }
}
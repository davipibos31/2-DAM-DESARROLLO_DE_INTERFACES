using Practica3.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace Practica3.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}
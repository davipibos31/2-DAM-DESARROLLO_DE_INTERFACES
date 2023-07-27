using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Tema_1_Ejercicio_1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void B1_Pressed(object sender, EventArgs e)
        {
            if (E1.Text != null)
                L1.Text = E1.Text;
        }
    }
}

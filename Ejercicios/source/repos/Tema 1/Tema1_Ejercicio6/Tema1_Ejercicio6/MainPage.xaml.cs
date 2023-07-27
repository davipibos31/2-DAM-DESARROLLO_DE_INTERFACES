using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Tema1_Ejercicio6
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void E1_Completed(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(E1.Text);
            if (L1.Text != null)
                L1.FontSize = num1;
        }
    }
}

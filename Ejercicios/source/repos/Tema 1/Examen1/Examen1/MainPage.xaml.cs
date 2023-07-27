using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Examen1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnop1_Clicked(object sender, EventArgs e)
        {
            btnop1.BackgroundColor = Color.Red;
            btnop2.BackgroundColor = Color.Green;
            label2.Text = "HAS FALLADO";

            btnop2.IsEnabled = false;
            btnop1.IsEnabled = false;
            btnop3.IsEnabled = false;
            btnop4.IsEnabled = false;
        }

        private void btnop2_Clicked(object sender, EventArgs e)
        {
            btnop2.BackgroundColor = Color.Green;
            label2.Text = "HAS ACERTADO";

            btnop2.IsEnabled = false;
            btnop1.IsEnabled = false;
            btnop3.IsEnabled = false;
            btnop4.IsEnabled = false;
        }

        private void btnop3_Clicked(object sender, EventArgs e)
        {
            btnop3.BackgroundColor = Color.Red;
            btnop2.BackgroundColor = Color.Green;
            label2.Text = "HAS FALLADO";

            btnop2.IsEnabled = false;
            btnop1.IsEnabled = false;
            btnop3.IsEnabled = false;
            btnop4.IsEnabled = false;
        }

        private void btnop4_Clicked(object sender, EventArgs e)
        {
            btnop4.BackgroundColor = Color.Red;
            btnop2.BackgroundColor = Color.Green;
            label2.Text = "HAS FALLADO";

            btnop2.IsEnabled = false;
            btnop1.IsEnabled = false;
            btnop3.IsEnabled = false;
            btnop4.IsEnabled = false;
        }

        private void btnsiguiente_Clicked(object sender, EventArgs e)
        {
            SL1.IsVisible = false;
            SL2.IsVisible = false;
            SL3.IsVisible = false;
            SL4.IsVisible = false;

            SL5.IsVisible = true;
            SL6.IsVisible = true;
            SL7.IsVisible = true;
            SL8.IsVisible = true;

            btnop1.IsEnabled = true;
            btnop2.IsEnabled = true;
            btnop3.IsEnabled = true;
            btnop4.IsEnabled = true;

            btnop6.IsEnabled = true;
            btnop7.IsEnabled = true;
            btnop8.IsEnabled = true;
            btnop9.IsEnabled = true;

            label2.Text = "";
            label4.Text = "";
            btnop2.BackgroundColor = Color.Black;
            btnop7.BackgroundColor = Color.Black;

            btnop1.BackgroundColor = Color.Black;
            btnop3.BackgroundColor = Color.Black;
            btnop4.BackgroundColor = Color.Black;
            btnop8.BackgroundColor = Color.Black;
            btnop6.BackgroundColor = Color.Black;
            btnop9.BackgroundColor = Color.Black;

        }

        private void btnsiguiente2_Clicked(object sender, EventArgs e)
        {
            SL1.IsVisible = true;
            SL2.IsVisible = true;
            SL3.IsVisible = true;
            SL4.IsVisible = true;

            SL5.IsVisible = false;
            SL6.IsVisible = false;
            SL7.IsVisible = false;
            SL8.IsVisible = false;

            btnop1.IsEnabled = true;
            btnop2.IsEnabled = true;
            btnop3.IsEnabled = true;
            btnop4.IsEnabled = true;

            btnop6.IsEnabled = true;
            btnop7.IsEnabled = true;
            btnop8.IsEnabled = true;
            btnop9.IsEnabled = true;

            label2.Text = "";
            label4.Text = "";

            btnop2.BackgroundColor = Color.Black;
            btnop7.BackgroundColor = Color.Black;

            btnop1.BackgroundColor = Color.Black;
            btnop3.BackgroundColor = Color.Black;
            btnop4.BackgroundColor = Color.Black;
            btnop8.BackgroundColor = Color.Black;
            btnop6.BackgroundColor = Color.Black;
            btnop9.BackgroundColor = Color.Black;

        }

        private void btnop8_Clicked(object sender, EventArgs e)
        {
            btnop8.BackgroundColor = Color.Red;
            btnop7.BackgroundColor = Color.Green;
            label4.Text = "HAS FALLADO";

            btnop6.IsEnabled = false;
            btnop7.IsEnabled = false;
            btnop8.IsEnabled = false;
            btnop9.IsEnabled = false;
        }

        private void btnop7_Clicked(object sender, EventArgs e)
        {
            btnop7.BackgroundColor = Color.Green;
            label4.Text = "HAS ACERTADO";

            btnop6.IsEnabled = false;
            btnop7.IsEnabled = false;
            btnop8.IsEnabled = false;
            btnop9.IsEnabled = false;
        }

        private void btnop6_Clicked(object sender, EventArgs e)
        {
            btnop6.BackgroundColor = Color.Red;
            btnop7.BackgroundColor = Color.Green;
            label4.Text = "HAS FALLADO";

            btnop6.IsEnabled = false;
            btnop7.IsEnabled = false;
            btnop8.IsEnabled = false;
            btnop9.IsEnabled = false;
        }

        private void btnop9_Clicked(object sender, EventArgs e)
        {
            btnop9.BackgroundColor = Color.Red;
            btnop7.BackgroundColor = Color.Green;
            label4.Text = "HAS FALLADO";

            btnop6.IsEnabled = false;
            btnop7.IsEnabled = false;
            btnop8.IsEnabled = false;
            btnop9.IsEnabled = false;
        }
    }
}

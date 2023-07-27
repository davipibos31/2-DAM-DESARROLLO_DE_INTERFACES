using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Essentials;

namespace Practica2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            
        }
        public static int indiceActual = 0;
        public static List<StackLayout> layout = new List<StackLayout>();
        public static StackLayout sl = new StackLayout();
        private void bAnterior_Clicked(object sender, EventArgs e)
        { 
            salida:
            // A la hora de añadir más libros hay que añadir los StackLayout aquí

            layout.Add(SL1);
            layout.Add(SL4);
            layout.Add(SL7);

            if (indiceActual == layout.Count)
                indiceActual = 0;
            else {
                sl = layout[indiceActual];
                sl.IsVisible = false;
                indiceActual--;
            }
            if (indiceActual < 0) {
                // A la hora de añadir más libros este layout.count tendra el total de libros - 1
                indiceActual = layout.Count -2;
                goto salida;
            }

            sl = layout[indiceActual];
            sl.IsVisible = true;
        }

        private void bSiguiente_Clicked(object sender, EventArgs e)
        {
            salida:
            // A la hora de añadir más libros hay que añadir los StackLayout aquí

            layout.Add(SL1);
            layout.Add(SL4);
            layout.Add(SL7);
            
            if (indiceActual == layout.Count)
                indiceActual = 0;
            else {
                sl = layout[indiceActual];
                sl.IsVisible = false;
                indiceActual++;
            }
            if (indiceActual < 0)
                goto salida;

            sl = layout[indiceActual];
            sl.IsVisible = true;
        }
    }
}

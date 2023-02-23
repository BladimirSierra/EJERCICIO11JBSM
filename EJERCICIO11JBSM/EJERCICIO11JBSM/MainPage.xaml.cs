using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace EJERCICIO11JBSM
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void btnSuma_Clicked(object sender, EventArgs e)
        {
            try { 
            Double total = 0;
            total = Double.Parse(txt_numero1.Text) + Double.Parse(txt_numero2.Text);
                await Navigation.PushModalAsync(new resultados(total.ToString()));
            }
            catch
            {
                await DisplayAlert("Aviso", "Favor ingresar los 2 numeros solicitados", "OK");
            }
        }

        private async void btnResta_Clicked(object sender, EventArgs e)
        {
            try
            {
                Double total = 0;
                total = Double.Parse(txt_numero1.Text) - Double.Parse(txt_numero2.Text);
                await Navigation.PushModalAsync(new resultados(total.ToString()));
            }
            catch
            {
                await DisplayAlert("Aviso", "Favor ingresar los 2 numeros solicitados", "OK");
            }
        }

        private async void btnMultiplicacion_Clicked(object sender, EventArgs e)
        {
            try
            {
                Double total = 0;
                total = Double.Parse(txt_numero1.Text) * Double.Parse(txt_numero2.Text);
                await Navigation.PushModalAsync(new resultados(total.ToString()));
            }
            catch
            {
                await DisplayAlert("Aviso", "Favor ingresar los 2 numeros solicitados", "OK");
            }
        }

        private async void btnDivision_Clicked(object sender, EventArgs e)
        {
            try
            {
                Double total = 0;
                total = Double.Parse(txt_numero1.Text) / Double.Parse(txt_numero2.Text);
                await Navigation.PushModalAsync(new resultados(total.ToString()));
            }
            catch
            {
                await DisplayAlert("Aviso", "Favor ingresar los 2 numeros solicitados", "OK");
            }
        }
    }
}

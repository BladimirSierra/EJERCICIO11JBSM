using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EJERCICIO11JBSM
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class resultados : ContentPage
    {
        public resultados()
        {
            InitializeComponent();
        }
        public resultados(String resultados)
        {
            InitializeComponent();
            lblResultados.Text = "El resultado es: " + resultados;

        }
    }
}
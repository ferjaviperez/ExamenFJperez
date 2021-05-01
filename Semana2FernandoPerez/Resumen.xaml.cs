using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Semana2FernandoPerez
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Resumen : ContentPage
    {
        public Resumen(string usuario, string nombre, string cuotas)
        {
            InitializeComponent();
            txtConectado.Text = usuario.ToString();
            txtnombre.Text = nombre.ToString();
            txtcuotas.Text = cuotas.ToString();
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Semana2FernandoPerez
{
    public partial class MainPage : ContentPage
    {
        public MainPage(string usuario, string clave)
        {
            InitializeComponent();
            txtConectado.Text = usuario.ToString();
        }
        private void btnSumar_Clicked(object sender, EventArgs e)
        {
           
            try
            {

                double dato1 = Convert.ToDouble(txtMonto.Text);
                

                double suma = 1800-dato1;

                double cuotas = 0;

                if (suma < 0 )
                {
                    DisplayAlert("Mensaje", "Valor Incorrecto", "Cerrar");
                }
                else if (suma == 0)
                {
                    DisplayAlert("Mensaje", "No paga cuotas", "Cerrar");
                }
                else if (suma > 1)
                {

                    cuotas = (suma / 3) + (1800 * 0.05);
                    DisplayAlert("Mensaje", "Paga 3 Cuotas", "Cerrar");
                }

                txtcuotas.Text = cuotas.ToString();

            }
            catch (Exception ex)
            {
                //Mensaje de erro capturado por el catch
                DisplayAlert("Alerta", ex.Message, "Cerrar");
            }

        }

        private async void btnGuardar_Clicked(object sender, EventArgs e)
        {
            string usuario = txtConectado.Text;
            string  nombre = txtNombre.Text;
            string cuotas = txtcuotas.Text;
            await Navigation.PushAsync(new Resumen(usuario, nombre, cuotas));
        }
    }
}

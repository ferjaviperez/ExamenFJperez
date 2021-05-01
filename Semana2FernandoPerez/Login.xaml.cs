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
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }
        private async void btnAbrir_Clicked(object sender, EventArgs e)
        {
            string usuario = txtUser.Text;
            string clave = txtPass.Text;
            if (usuario != "estudiante2021" | clave != "uisrael2021")
            {
                await DisplayAlert("Alerta", "Usuario o contraseña incorrectos", "Cerrar");
                return;
            }

            await DisplayAlert("Bienvenido", "Se ha validado el acceso", "Continuar");
            await Navigation.PushAsync(new MainPage(usuario, clave));
        }

    }

}
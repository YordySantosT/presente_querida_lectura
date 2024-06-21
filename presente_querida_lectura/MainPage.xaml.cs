using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace presente_querida_lectura
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            

            if (usuario.Text.ToLower() == "santiago")
            {
                Navigation.PushAsync(new CuentoPage());
            }
            else if(usuario.Text.ToLower() == "profesor")
            {
                Navigation.PushAsync(new ProfesorPage());
            }
            else
            {
                DisplayAlert("Error", "Usuario no valido", "Confirmar");
                
            }

            usuario.Text = string.Empty;
            clave.Text = string.Empty;
        }

        private void usuario_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (!String.IsNullOrEmpty(usuario.Text) && !String.IsNullOrEmpty(clave.Text))
            {
                siguiente.IsEnabled = true;
            }
            else
            {
                siguiente.IsEnabled = false;
            }
        }

        private void clave_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (!String.IsNullOrEmpty(usuario.Text) && !String.IsNullOrEmpty(clave.Text))
            {
                siguiente.IsEnabled = true;
            }
            else
            {
                siguiente.IsEnabled = false;
            }
        }
    }
}

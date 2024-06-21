using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace presente_querida_lectura
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Preguntas : ContentPage
    {
        public Preguntas()
        {
            InitializeComponent();
        }


        public static class Nota
        {
            public static int Contador { get; set; }
            
        }



        private void comprobar_Clicked(object sender, EventArgs e)
        {
            
            string respuestaSeleccionada1 = pregunta1.SelectedItem?.ToString();
            string respuestaSeleccionada2 = pregunta2.SelectedItem?.ToString();
            string respuestaSeleccionada3 = pregunta3.SelectedItem?.ToString();
            string respuestaSeleccionada4 = pregunta4.SelectedItem?.ToString();
            string respuestaSeleccionada5 = pregunta5.SelectedItem?.ToString();
            


            if (!string.IsNullOrEmpty(respuestaSeleccionada1) && !string.IsNullOrEmpty(respuestaSeleccionada2) && !string.IsNullOrEmpty(respuestaSeleccionada3) && !string.IsNullOrEmpty(respuestaSeleccionada4) && !string.IsNullOrEmpty(respuestaSeleccionada5))
            {
                if (respuestaSeleccionada1 == "A) Porque siempre llevaba una capa roja.")
                {
                    Nota.Contador++;
                }
                if (respuestaSeleccionada2 == "B) Galleticas recién horneadas.")
                {
                    Nota.Contador++;
                }
                if (respuestaSeleccionada3 == "B) Que no hablara con extraños y se quedara en el camino.")
                {
                    Nota.Contador++;
                }
                if (respuestaSeleccionada4 == "C) Se puso sus lentes y gorrito de noche.")
                {
                    Nota.Contador++;
                }
                if (respuestaSeleccionada5 == "B) Porque vio al lobo salir corriendo.")
                {
                    Nota.Contador++;
                }

                DisplayAlert("Felicidades", $"Tuviste {Nota.Contador} respuestas correctas", "Confirmar");
                Navigation.PopToRootAsync();
            }
            else
            {
                DisplayAlert("Error", "Por favor selecciona una opción.", "Confirmar");
            }


            
            
        }
    }
}
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
	public partial class ProfesorPage : ContentPage
	{
		public ProfesorPage ()
		{
			InitializeComponent ();
		}

        private void Button_Clicked(object sender, EventArgs e)
        {
			Navigation.PushAsync(new Periodos ());
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Notas());
        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Asistencia());
        }
    }
}
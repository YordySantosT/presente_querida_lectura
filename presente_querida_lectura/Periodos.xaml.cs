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
    public partial class Periodos : ContentPage
    {
        public Periodos()
        {
            InitializeComponent();
        }

        public static class BusinessDaysCalculator
        {
            public static int TotalBusinessDays { get; set; }
            public static int RemainingBusinessDays { get; set; }
        }




        private async void SetUp_Clicked(object sender, EventArgs e)
        {
            DateTime startDate = InicioFecha.Date;
            DateTime endDate = FinalFecha.Date;
            DateTime currentDate = DateTime.Now.Date;

            BusinessDaysCalculator.TotalBusinessDays = CountBusinessDays(startDate, endDate);
            BusinessDaysCalculator.RemainingBusinessDays = CountBusinessDays(currentDate, endDate);

            
            await DisplayAlert("Configurado", "Has configurado el periodo académico", "confirmar");
            await Navigation.PopAsync();

        }

        private int CountBusinessDays(DateTime start, DateTime end)
        {
            int businessDaysCount = 0;
            for(DateTime date = start; date <= end; date = date.AddDays(1))
            {
                if(date.DayOfWeek != DayOfWeek.Saturday && date.DayOfWeek != DayOfWeek.Sunday)
                {
                    businessDaysCount++;
                }
            }
            return businessDaysCount;
        }
    }
}
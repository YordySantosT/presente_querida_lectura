using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using static presente_querida_lectura.Periodos;

namespace presente_querida_lectura
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Asistencia : ContentPage
    {
        public Asistencia()
        {
            InitializeComponent();
            
            if (BusinessDaysCalculator.TotalBusinessDays != 0 && BusinessDaysCalculator.RemainingBusinessDays != 0)
            {
                resultLabel.Text = $"Días que comprende este periodo académico:\n {BusinessDaysCalculator.TotalBusinessDays}\n" +
                                   $"Días restantes para finalizar el periodo académico:\n {BusinessDaysCalculator.RemainingBusinessDays}";
                e1.Text = $"1) Santiago ha faltado {1} vez, lo que corresponde al {(1 * 100) / BusinessDaysCalculator.TotalBusinessDays}% del periodo académico";
                e2.Text = $"2) Valentina ha faltado {2} veces, lo que corresponde al {(2 * 100) / BusinessDaysCalculator.TotalBusinessDays}% del periodo académico";
                e3.Text = $"3) Alejandro ha faltado {3} veces, lo que corresponde al {(3 * 100) / BusinessDaysCalculator.TotalBusinessDays}% del periodo académico";
                e4.Text = $"4) Mateo ha faltado {4} veces, lo que corresponde al {(4 * 100) / BusinessDaysCalculator.TotalBusinessDays}% del periodo académico";
                e5.Text = $"5) Sofía ha faltado {5} veces, lo que corresponde al {(5 * 100) / BusinessDaysCalculator.TotalBusinessDays}% del periodo académico";
                e6.Text = $"6) Valeria ha faltado {6} veces, lo que corresponde al {(6 * 100) / BusinessDaysCalculator.TotalBusinessDays}% del periodo académico";
                e7.Text = $"7) Gabriela ha faltado {7} veces, lo que corresponde al {(7 * 100) / BusinessDaysCalculator.TotalBusinessDays}% del periodo académico";
                e8.Text = $"8) David ha faltado {8} veces, lo que corresponde al {(8 * 100) / BusinessDaysCalculator.TotalBusinessDays}% del periodo académico";
                e9.Text = $"9) Andres ha faltado {9} veces, lo que corresponde al {(9 * 100) / BusinessDaysCalculator.TotalBusinessDays}% del periodo académico";
                e10.Text = $"10) Juan ha faltado {10} veces, lo que corresponde al {(10 * 100) / BusinessDaysCalculator.TotalBusinessDays}% del periodo académico";
            }
            else
            {
                Device.BeginInvokeOnMainThread(async () =>
                {
                    try
                    {
                        await DisplayAlert("Error", "Configure primero las fechas Académicas", "Confirmar");

                        // Obtener la NavigationPage actual y verificar si se puede hacer pop
                        if (Navigation != null && Navigation.NavigationStack.Count > 1)
                        {
                            await Navigation.PopAsync();
                            Console.WriteLine("hola");
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error al intentar navegar hacia atrás: {ex.Message}");
                    }
                });

            }
        }

    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using static presente_querida_lectura.Periodos;

namespace presente_querida_lectura
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Notas : ContentPage
    {
        public Notas()
        {
            InitializeComponent();
            e1.Text = $"1) Santiago tiene un promedio de: {Preguntas.Nota.Contador}";
            e2.Text = $"2) Valentina tiene un promedio de: {Preguntas.Nota.Contador}";
            e3.Text = $"3) Alejandro tiene un promedio de: {Preguntas.Nota.Contador}";
            e4.Text = $"4) Mateo tiene un promedio de: {Preguntas.Nota.Contador}";
            e5.Text = $"5) Sofía tiene un promedio de: {Preguntas.Nota.Contador}";
            e6.Text = $"6) Valeria tiene un promedio de: {Preguntas.Nota.Contador}";
            e7.Text = $"7) Gabriela tiene un promedio de: {Preguntas.Nota.Contador}";
            e8.Text = $"8) David tiene un promedio de: {Preguntas.Nota.Contador}";
            e9.Text = $"9) Andres tiene un promedio de: {Preguntas.Nota.Contador}";
            e10.Text = $"10) Juan tiene un promedio de: {Preguntas.Nota.Contador}";

        }
    }
}
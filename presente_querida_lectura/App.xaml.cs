using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace presente_querida_lectura
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
            var navigationPage = Application.Current.MainPage as NavigationPage;
            navigationPage.BarBackgroundColor = (Color)Application.Current.Resources["NavigationBarColor"];
            navigationPage.BarBackgroundColor = Color.FromRgba(228, 95, 78, 0); // Color con transparencia
            navigationPage.BarTextColor = Color.Black; // Color del texto en el NavigationBar
            
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}

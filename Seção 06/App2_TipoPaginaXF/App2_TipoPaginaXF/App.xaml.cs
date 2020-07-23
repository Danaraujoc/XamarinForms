using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App2_TipoPaginaXF
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new App2_TipoPaginaXF.TipoPagina.Carousel.IntroducaoApp();
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

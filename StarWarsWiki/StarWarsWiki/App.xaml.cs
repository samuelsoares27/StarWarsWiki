using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace StarWarsWiki
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new TipoPagina.Carrossel.FluxoCarrossel();
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

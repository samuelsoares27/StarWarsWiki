using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace StarWarsWiki.TipoPagina.Carrossel
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CarrosselPage3 : ContentPage
    {
        public CarrosselPage3()
        {
            InitializeComponent();
        }

        private void InicioApp(object sender, EventArgs args)
        {
            App.Current.MainPage = new Master.FlyoutPageMenu();
        }
    }
}
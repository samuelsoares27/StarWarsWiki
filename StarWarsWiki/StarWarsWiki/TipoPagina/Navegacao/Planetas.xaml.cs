using Star_Wars.Models;
using StarWarsWiki.Models;
using StarWarsWiki.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace StarWarsWiki.TipoPagina.Navegacao
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Planetas : ContentPage
    {
        private ApiSWServices planetasServices = new ApiSWServices();
        public List<Planeta> listaPlanetas;

        public Planetas()
        {
            InitializeComponent();
            BuscarVeiculos();
        }

        private async void BuscarVeiculos()
        {

            activity.IsVisible = true;

            try
            {

                listaPlanetas = new List<Planeta>();
                var RetornoPlanetas = await planetasServices.GetListaPlanetaAsync(BuscaEnum.Generos.planets);

                foreach (var planetas in RetornoPlanetas)
                {
                    foreach (var planeta in planetas.Resultado)
                    {
                        planeta.Nome = planeta.Nome.Replace("/", " ");
                        listaPlanetas.Add(planeta);
                    }
                }

                ListaPlanetas.ItemsSource = listaPlanetas.OrderBy(n => n.Nome);
            }
            catch (Exception)
            {
                await DisplayAlert("Atenção", "Erro ao buscar os Planetas", "Ok");
            }

            activity.IsVisible = false;
        }

        private void ItemSelecionadoAction(object sender, SelectedItemChangedEventArgs args)
        {
            Planeta planetas = (Planeta)args.SelectedItem;

            Navigation.PushAsync(new PlanetasDetalhes(planetas));

        }
    }
}
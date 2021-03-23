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
    public partial class Especies : ContentPage
    {
        private ApiSWServices especiesServices = new ApiSWServices();
        public List<Especie> listaEspecies;
        public Especies()
        {
            InitializeComponent();
            BuscarEspecies();
        }

        private async void BuscarEspecies()
        {

            activity.IsVisible = true;

            try
            {

                listaEspecies = new List<Especie>();
                var RetornoEspecies = await especiesServices.GetListaEspecieAsync(BuscaEnum.Generos.species);

                foreach (var especies in RetornoEspecies)
                {
                    foreach (var especie in especies.Resultado)
                    {
                        especie.Nome = especie.Nome.Replace("/", " ");
                        listaEspecies.Add(especie);
                    }
                }

                ListaEspecies.ItemsSource = listaEspecies.OrderBy(n => n.Nome);
            }
            catch (Exception)
            {
                await DisplayAlert("Atenção", "Erro ao buscar as Espécies", "Ok");
            }

            activity.IsVisible = false;
        }

        private void ItemSelecionadoAction(object sender, SelectedItemChangedEventArgs args)
        {
            Especie especies = (Especie)args.SelectedItem;

            Navigation.PushAsync(new EspeciesDetalhes(especies));

        }
    }
}
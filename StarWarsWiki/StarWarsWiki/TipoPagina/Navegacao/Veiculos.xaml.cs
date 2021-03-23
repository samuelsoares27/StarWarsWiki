using Star_Wars.Models;
using StarWarsWiki.Models;
using StarWarsWiki.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace StarWarsWiki.TipoPagina.Navegacao
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Veiculos : ContentPage
    {
        private ApiSWServices veiculosServices = new ApiSWServices();
        public List<Veiculo> listaVeiculos;

        public Veiculos()
        {
            InitializeComponent();
            BuscarVeiculos();
        }

        private async void BuscarVeiculos()
        {

            activity.IsVisible = true;

            try
            {

                listaVeiculos = new List<Veiculo>();
                var RetornoVeiculos = await veiculosServices.GetListaVeiculosAsync(BuscaEnum.Generos.vehicles);

                foreach (var veiculos in RetornoVeiculos)
                {
                    foreach (var veiculo in veiculos.Resultado)
                    {
                        veiculo.Nome = veiculo.Nome.Replace("/", " ");
                        listaVeiculos.Add(veiculo);
                    }
                }

                ListaVeiculos.ItemsSource = listaVeiculos.OrderBy(n => n.Nome);
            }
            catch (Exception)
            {
                await DisplayAlert("Atenção", "Erro ao buscar os Veículos", "Ok");
            }

            activity.IsVisible = false;
        }

        private void ItemSelecionadoAction(object sender, SelectedItemChangedEventArgs args) 
        {
            Veiculo naves = (Veiculo)args.SelectedItem;

            Navigation.PushAsync(new VeiculosDetalhes(naves));
        
        }

    }
}
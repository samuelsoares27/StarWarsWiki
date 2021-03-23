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
    public partial class Naves : ContentPage
    {
        private ApiSWServices navesServices = new ApiSWServices();
        public List<Nave> listaNaves;
        public Naves()
        {
            InitializeComponent();
            BuscarNaves();
        }

        private async void BuscarNaves()
        {

            activity.IsVisible = true;

            try
            {
                listaNaves = new List<Nave>();
                var RetornoNaves = await navesServices.GetListaNavesAsync(BuscaEnum.Generos.starships);

                foreach (var naves in RetornoNaves)
                {
                    foreach (var nave in naves.Resultado)
                    {
                        nave.Nome = nave.Nome.Replace("/", " ");
                        listaNaves.Add(nave);
                    }
                }

                ListaNaves.ItemsSource = listaNaves.OrderBy(n => n.Nome);
            }
            catch (Exception)
            {
                await DisplayAlert("Atenção", "Erro ao buscar as Naves", "Ok");
            }

            activity.IsVisible = false;
        }

        private void ItemSelecionadoAction(object sender, SelectedItemChangedEventArgs args)
        {
            Nave naves = (Nave)args.SelectedItem;

            Navigation.PushAsync(new NavesDetalhes(naves));

        }
    }
}
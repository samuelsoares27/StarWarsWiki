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
    public partial class EspeciesDetalhes : ContentPage
    {

        private ApiSWServices veiculoService = new ApiSWServices();
        private Especie objetoEspecie = new Especie();
        public EspeciesDetalhes(Especie especies)
        {
   
            InitializeComponent();
            activity.IsVisible = true;
            objetoEspecie = especies;
            StoreImages();
            BindingContext = especies;
            activity.IsVisible = false;
        }

        private async void StoreImages()
        {
            var urlImagem = await veiculoService.GetImagemAsync(objetoEspecie.Nome, BuscaEnum.Generos.species);
            imgChoosed.Source = urlImagem;
        }
    }
}
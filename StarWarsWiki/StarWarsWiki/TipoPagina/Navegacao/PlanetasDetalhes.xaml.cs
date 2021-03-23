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
    public partial class PlanetasDetalhes : ContentPage
    {
        private ApiSWServices veiculoService = new ApiSWServices();
        private Planeta objetoPlaneta = new Planeta();
        public PlanetasDetalhes(Planeta planeta)
        {
            InitializeComponent();
            activity.IsVisible = true;
            objetoPlaneta = planeta;
            StoreImages();
            BindingContext = planeta;
            activity.IsVisible = false;
        }

        private async void StoreImages()
        {
            var urlImagem = await veiculoService.GetImagemAsync(objetoPlaneta.Nome, BuscaEnum.Generos.planets);
            imgChoosed.Source = urlImagem;
        }
    }
}
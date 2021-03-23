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
    public partial class NavesDetalhes : ContentPage
    {
        private ApiSWServices naveService = new ApiSWServices();
        private Nave objetoNave = new Nave();
        public NavesDetalhes(Nave nave)
        {
            InitializeComponent();
            activity.IsVisible = true;
            objetoNave = nave;
            StoreImages();
            BindingContext = nave;
            activity.IsVisible = false;
        }

        private async void StoreImages()
        {
            var urlImagem = await naveService.GetImagemAsync(objetoNave.Nome, BuscaEnum.Generos.starships);

            imgChoosed.Source = urlImagem;
        }
    }
}
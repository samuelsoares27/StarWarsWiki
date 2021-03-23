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
    public partial class PessoasDetalhes : ContentPage
    {
        private ApiSWServices veiculoService = new ApiSWServices();
        private Pessoa objetoPessoa = new Pessoa();
        public PessoasDetalhes(Pessoa pessoas)
        {
            InitializeComponent();
            activity.IsVisible = true;
            objetoPessoa = pessoas;
            StoreImages();
            BindingContext = pessoas;
            activity.IsVisible = false;
        }

        private async void StoreImages()
        {
            var urlImagem = await veiculoService.GetImagemAsync(objetoPessoa.Nome, BuscaEnum.Generos.people);
            imgChoosed.Source = urlImagem;
        }
    }
}
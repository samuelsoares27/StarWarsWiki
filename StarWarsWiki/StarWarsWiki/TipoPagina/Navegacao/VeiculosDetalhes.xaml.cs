using Star_Wars.Models;
using StarWarsWiki.Models;
using StarWarsWiki.Services;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace StarWarsWiki.TipoPagina.Navegacao
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
   
    public partial class VeiculosDetalhes : ContentPage
    {
        private ApiSWServices veiculoService = new ApiSWServices();
        private Veiculo objetoVeiculo = new Veiculo();
        public VeiculosDetalhes(Veiculo veiculo)
        {
            InitializeComponent();
            activity.IsVisible = true;
            objetoVeiculo = veiculo;
            StoreImages();       
            BindingContext = veiculo;
            activity.IsVisible = false; 
        }

        private async void StoreImages()
        {
            var urlImagem = await veiculoService.GetImagemAsync(objetoVeiculo.Nome, BuscaEnum.Generos.vehicles);

            imgChoosed.Source = urlImagem;
        }
    }
}
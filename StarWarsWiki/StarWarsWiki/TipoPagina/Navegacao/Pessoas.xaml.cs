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
    public partial class Pessoas : ContentPage
    {
        private ApiSWServices pessoasServices = new ApiSWServices();
        public List<Pessoa> listaPessoas;
        public Pessoas()
        {
            InitializeComponent();
            BuscarPessoas();
        }

        private async void BuscarPessoas()
        {

            activity.IsVisible = true;

            try
            {
                listaPessoas = new List<Pessoa>();
                var RetornoPessoas = await pessoasServices.GetListaPessoasAsync(BuscaEnum.Generos.people);

                foreach (var pessoas in RetornoPessoas)
                {
                    foreach (var pessoa in pessoas.Resultado)
                    {
                        pessoa.Nome = pessoa.Nome.Replace("/", " ");
                        listaPessoas.Add(pessoa);
                    }
                }

                ListaPessoas.ItemsSource = listaPessoas.OrderBy(n => n.Nome);
            }
            catch (Exception)
            {
                await DisplayAlert("Atenção", "Erro ao buscar as Pessoas", "Ok");
            }

            activity.IsVisible = false;
        }

        private void ItemSelecionadoAction(object sender, SelectedItemChangedEventArgs args)
        {
            Pessoa pessoas = (Pessoa)args.SelectedItem;

            Navigation.PushAsync(new PessoasDetalhes(pessoas));

        }
    }
}
using Star_Wars.Models;
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
        public EspeciesDetalhes(Especie especies)
        {
            InitializeComponent();
        }
    }
}
using StarWarsWiki.TipoPagina.Navegacao;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace StarWarsWiki.TipoPagina.Master
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FlyoutPageMenuFlyout : ContentPage
    {
        public ListView ListView;

        public FlyoutPageMenuFlyout()
        {
            InitializeComponent();

            BindingContext = new FlyoutPageMenuFlyoutViewModel();
            ListView = MenuItemsListView;
        }

        class FlyoutPageMenuFlyoutViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<FlyoutPageMenuFlyoutMenuItem> MenuItems { get; set; }

            public FlyoutPageMenuFlyoutViewModel()
            {
                MenuItems = new ObservableCollection<FlyoutPageMenuFlyoutMenuItem>(new[]
                {
                    new FlyoutPageMenuFlyoutMenuItem { Id = 0, Title = "Inicio", TargetType = typeof(Inicio)},
                    new FlyoutPageMenuFlyoutMenuItem { Id = 1, Title = "Pessoas", TargetType = typeof(Pessoas)},
                    new FlyoutPageMenuFlyoutMenuItem { Id = 2, Title = "Planetas", TargetType = typeof(Planetas)},
                    new FlyoutPageMenuFlyoutMenuItem { Id = 3, Title = "Especies", TargetType = typeof(Especies)},
                    new FlyoutPageMenuFlyoutMenuItem { Id = 4, Title = "Veículos", TargetType = typeof(Veiculos)},
                    new FlyoutPageMenuFlyoutMenuItem { Id = 5, Title = "Naves", TargetType = typeof(Naves)}
 
                }); 
            }

            #region INotifyPropertyChanged Implementation
            public event PropertyChangedEventHandler PropertyChanged;
            void OnPropertyChanged([CallerMemberName] string propertyName = "")
            {
                if (PropertyChanged == null)
                    return;

                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
            #endregion
        }
    }
}
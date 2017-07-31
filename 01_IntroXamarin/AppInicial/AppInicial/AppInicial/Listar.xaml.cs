using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppInicial
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Listar : ContentPage
    {
        public Listar(List<Item> itens)
        {
            InitializeComponent();

            minhaLista.ItemsSource = itens;
        }

        private void minhaLista_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var itemSelecionado = (Item)e.Item;

            Navigation.PushAsync(new Detalhe(itemSelecionado));
        }
    }
}
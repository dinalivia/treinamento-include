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
    public partial class Cadastrar : ContentPage
    {
        List<Item> _itens = new List<Item>();

        public Cadastrar()
        {
            InitializeComponent();

        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            var i = 0;
            _itens.Add(new Item
            {
                ID = i++,
                Nome = nomeItem.Text,
                Descricao = descricaoItem.Text
            });

            nomeItem.Text = string.Empty;
            descricaoItem.Text = string.Empty;
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Listar(_itens));
        }
    }
}
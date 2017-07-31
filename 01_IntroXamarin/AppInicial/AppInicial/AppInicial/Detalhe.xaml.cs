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
    public partial class Detalhe : TabbedPage
    {
        public Detalhe(Item item)
        {
            InitializeComponent();

            nomeItem.Text = item.Nome;
            descricaoItem.Text = item.Descricao;
            nomeItemOpcao.Text = item.Nome;
            descricaoItemOpcao.Text = item.Descricao;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            nomeItemOpcao.IsEnabled = true;
            descricaoItemOpcao.IsEnabled = true;
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            DisplayAlert("Alerta!", "Você deletou o item", "Ok");
        }
    }
}
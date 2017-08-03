using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App1
{
    public partial class MainPage : ContentPage
    {
        //Metodo principal
        public MainPage()
        {
            //Inicializa os Componentes do XAML da página
            InitializeComponent();
        }

        //Metodo referente ao butao da tela
        private void Button_Clicked(object sender, EventArgs e)
        {
            //Alerta
            DisplayAlert("Alerta!", "Cuidado", "#foraTemer");
        }
    }
}

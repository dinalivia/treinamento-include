using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ResultApp.ViewModels
{
    public class PrimeiraViewModel : BaseViewModel
    {
        public Command SegundaTelaCommand { get; set; }

        public PrimeiraViewModel()
        {
            SegundaTelaCommand = new Command(ExecuteSegundaTelaCommand);
        }

        private async void ExecuteSegundaTelaCommand()
        {
            await PushAsync<SegundaViewModel>();
        }
    }
}

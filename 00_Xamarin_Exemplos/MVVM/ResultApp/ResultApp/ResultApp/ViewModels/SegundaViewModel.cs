using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ResultApp.ViewModels
{
    public class SegundaViewModel: BaseViewModel
    {
        public Command TerceiraTelaCommand { get; set; }

        public SegundaViewModel()
        {
            TerceiraTelaCommand = new Command(ExecuteTerceiraTelaCommand);
        }

        private async void ExecuteTerceiraTelaCommand()
        {
            await PushAsync<TerceiraViewModel>();
        }
    }
}

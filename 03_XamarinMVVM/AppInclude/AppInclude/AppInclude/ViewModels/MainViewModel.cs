using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppInclude.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        public Command ButtonCommand { get; set; }

        public MainViewModel()
        {
            ButtonCommand = new Command(ExecuteButtonCommand);
        }

        private async void ExecuteButtonCommand()
        {
            await PushAsync<TaskViewModel>();
        }
    }
}

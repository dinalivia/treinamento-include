using AppInclude.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppInclude.ViewModels
{
    public class TaskViewModel: BaseViewModel
    {
        public ObservableCollection<Tarefa> Itens { get; set; }
        public Command AdicionarCommand { get; set; }
        public TaskViewModel()
        {
            Itens = new ObservableCollection<Tarefa>();
            AdicionarCommand = new Command(ExecuteAdicionarCommand);
            Itens.Add(new Tarefa
            {
                TarefaID = 1,
                Nome = "Presunto"
            });
            Itens.Add(new Tarefa
            {
                TarefaID = 2,
                Nome = "Pão"
            });
            Itens.Add(new Tarefa
            {
                TarefaID = 3,
                Nome = "Queijo"
            });
            Itens.Add(new Tarefa
            {
                TarefaID = 4,
                Nome = "Nescau"
            });
        }

        private async void ExecuteAdicionarCommand()
        {
            await PushAsync<AdicionarViewModel>();
        }
    }
}

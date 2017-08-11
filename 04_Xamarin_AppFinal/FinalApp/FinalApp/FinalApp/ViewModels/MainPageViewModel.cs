using FinalApp.Models;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System.Collections.ObjectModel;
using System;
using FinalApp.Helpers;

namespace FinalApp.ViewModels
{
    public class MainPageViewModel : BindableBase
    {
        #region Global
        private INavigationService _navigationService;
        #endregion

        #region Binding
        private ObservableCollection<Tarefa> _itens;

        private static int _tarefaId;
        public ObservableCollection<Tarefa> Itens
        {
            get { return _itens; }
            set { SetProperty(ref _itens, value); }
        }


        private Tarefa _itemSelecionado;
        public Tarefa ItemSelecionado
        {
            get { return _itemSelecionado; }
            set
            {
                SetProperty(ref _itemSelecionado, value);

                if(ItemSelecionado != null)
                {
                    _tarefaId = ItemSelecionado.TarefaID;
                }
            }
        }
        #endregion

        #region Command
        public DelegateCommand NavigateToAddItemPageCommand { get; set; }
        public DelegateCommand FinalizarTarefaCommand { get; set; }
        public DelegateCommand RefreshCommand { get; set; }
        #endregion

        public MainPageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
            NavigateToAddItemPageCommand = new DelegateCommand(NavigateToAddItemPage);
            FinalizarTarefaCommand = new DelegateCommand(ExecuteFinalizarTarefaCommand);
            RefreshCommand = new DelegateCommand(ExecuteRefreshCommand);

            //Itens = ApiCaller.GetTarefas();
        }

        private void ExecuteRefreshCommand()
        {
            Itens = ApiCaller.GetTarefas();
        }

        private async void ExecuteFinalizarTarefaCommand()
        {
            Tarefa tarefa = new Tarefa();
            tarefa.Finalizado = true;

            await ApiCaller.Put(tarefa);
            Itens = ApiCaller.GetTarefas();
        }

        private void NavigateToAddItemPage()
        {
            var param = new NavigationParameters();
            param.Add("tarefaId", _tarefaId);
            _navigationService.NavigateAsync("AddItemPage", param);
        }
    }
}

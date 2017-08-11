using FinalApp.Helpers;
using FinalApp.Models;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FinalApp.ViewModels
{
    public class AddItemPageViewModel : BindableBase
    {

        #region Global
        private INavigationService _navigationService;
        #endregion

        #region Binding
        private string _nome;
        public string Nome
        {
            get { return _nome; }
            set { SetProperty(ref _nome, value); }
        }
        #endregion

        #region Command
        public DelegateCommand AdicionarEventoCommand { get; set; }
        public DelegateCommand NavigateToMainPageCommand { get; set; }
        #endregion

        public AddItemPageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;

            AdicionarEventoCommand = new DelegateCommand(ExecuteAdicionarEventoCommand);
            NavigateToMainPageCommand = new DelegateCommand(NavigateToMainPage);
        }

        private void NavigateToMainPage()
        {
            _navigationService.NavigateAsync("MainPage");
        }

        private async void ExecuteAdicionarEventoCommand()
        {
            Tarefa tarefa = new Tarefa();
            tarefa.Nome = Nome;
            tarefa.Finalizado = false;

            await ApiCaller.CreateTarefa(tarefa);
        }
    }
}

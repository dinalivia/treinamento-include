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
    public class ItemPageViewModel : BindableBase, INavigatedAware
    {
        #region Global
        private readonly INavigationService _navigationService;
        #endregion

        #region Binding
        private Tarefa _tarefa;
        public Tarefa Tarefa
        {
            get { return _tarefa; }
            set { SetProperty(ref _tarefa, value); }
        }

        private string _nome;
        public string Nome
        {
            get { return _nome; }
            set { SetProperty(ref _nome, value); }
        }
        #endregion

        #region Command
        public DelegateCommand NavigateToMainPageCommand { get; set; }
        #endregion

        public ItemPageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;

            NavigateToMainPageCommand = new DelegateCommand(NavigateToMainPage);
        }

        private async void NavigateToMainPage()
        {
            Tarefa tarefa = new Tarefa();
            tarefa.Nome = Nome;

            await ApiCaller.Put(tarefa);
            await _navigationService.NavigateAsync("MainPage");

        }

        public void OnNavigatedFrom(NavigationParameters parameters)
        {
            throw new NotImplementedException();
        }

        public void OnNavigatedTo(NavigationParameters parameters)
        {
            if(parameters.ContainsKey("tarefaId"))
            {
                Tarefa = ApiCaller.GetTarefa((int)parameters["tarefaId"]);
                Nome = Tarefa.Nome;
            }


        }
    }
}

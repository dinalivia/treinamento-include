using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppInclude.Models;

namespace AppInclude.Services
{
    public class AppIncludeApiService : IAppIncludeApiService
    {
        public Task<ObservableCollection<Tarefa>> GetTarefas()
        {
           return null;
        }
    }
}

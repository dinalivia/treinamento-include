using AppInclude.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppInclude.Services
{
    public interface IAppIncludeApiService
    {
        Task<ObservableCollection<Tarefa>> GetTarefas();
    }
}

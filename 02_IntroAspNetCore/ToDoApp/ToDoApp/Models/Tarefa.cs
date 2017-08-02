using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoApp.Models
{
    public class Tarefa
    {
        public int TarefaID { get; set; }
        public string Nome { get; set; }
        public bool Finalizado { get; set; }
    }
}

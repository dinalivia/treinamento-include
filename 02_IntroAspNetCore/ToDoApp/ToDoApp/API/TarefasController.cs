using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ToDoApp.Data;
using ToDoApp.Models;

namespace ToDoApp.API
{
    [Produces("application/json")]
    [Route("api/Tarefas")]
    public class TarefasController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TarefasController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Get()
        {
            // Obter todas as tarefas cadastradas no banco
            var tarefas = _context.Tarefas.ToList();
            // Retornar as tarefas com status 200 OK.
            return Ok(tarefas);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Tarefa tarefa)
        {
            // Adiciona a tarefa ao banco de dados
            _context.Tarefas.Add(tarefa);
            // Salva as mudanças realizadas
            _context.SaveChanges();
            // Retorna o objeto criado
            return Created("", tarefa);
        }
    }
}
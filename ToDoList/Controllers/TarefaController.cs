using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using projeto.ToDoList.Converters;
using projeto.ToDoList.Dtos;
using projeto.ToDoList.Models;
using projeto.ToDoList.Repositories;
using projeto.ToDoList.Repositories.Interfaces;

namespace ToDoList.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TarefaController : ControllerBase
    {
        private readonly ITarefaRepository _tarefaRepository;

        public TarefaController(ITarefaRepository tarefaRepository)
        {
            _tarefaRepository = tarefaRepository;
        }

        [HttpGet]
        [Route("listar")]
        public IActionResult Listar([FromQuery] string pesquisa)
        {
            TarefaModel tarefa = _tarefaRepository.ObterPorId(10);

            return Ok(_tarefaRepository.Listar(pesquisa));
        }

        [HttpPost]
        [Route("criar")]
        public IActionResult Criar([FromBody] params TarefaDto[] tarefasDto)
        {
            // Usando Linq
            // var listaDeTarefaModel = tarefasDto.ToList()
            //     .Select(TarefaConverter.DtoParaModel);
            //
            // TarefaRepository.Adicionar(listaDeTarefaModel);

            // Usando repetição

            var listaDeTarefaModel = new List<TarefaModel>();

            for (int i = 0; i < tarefasDto.Length; i++)
            {
               var model = TarefaConverter.DtoParaModel(tarefasDto[i]);
               TarefaRepository.Adicionar(model);
               listaDeTarefaModel.Add(model);
            }

            return Created("", listaDeTarefaModel);
        }

        [HttpDelete]
        [Route("excluir")]
        public IActionResult Excluir([FromQuery] int id)
        {
            TarefaRepository.Remover(id);
            return NoContent();
        }
    }
}
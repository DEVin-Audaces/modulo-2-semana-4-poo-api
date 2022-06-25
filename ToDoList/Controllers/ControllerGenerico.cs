using Microsoft.AspNetCore.Mvc;
using projeto.ToDoList.Models;
using projeto.ToDoList.Repositories;
using projeto.ToDoList.Repositories.Interfaces;

namespace projeto.ToDoList.Controllers
{
    public class ControllerGenerico<T, T1> : ControllerBase
        where T : BaseModel
        where T1 : IRepository<T>
    {
        private readonly T1 _repository;

        public ControllerGenerico(T1 repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public IActionResult Get([FromQuery] string query)
        {
            return Ok(_repository.Listar(query));
        }

        [HttpGet]
        [Route("obter/{id}")]
        public IActionResult Get(int id)
        {
            return Ok(_repository.ObterPorId(id));
        }

        [HttpPost]
        [Route("create")]
        public IActionResult Create([FromBody] T model)
        {
            _repository.Adicionar(model);
            return Created("", model);
        }

        [HttpPut]
        [Route("update")]
        public IActionResult Update([FromBody] T model)
        {
            _repository.Editar(model);
            return Ok(model);
        }

        [HttpDelete]
        [Route("delete/{id}")]
        public IActionResult Delete(int id)
        {
            _repository.Remover(id);
            return NoContent();
        }
    }
}
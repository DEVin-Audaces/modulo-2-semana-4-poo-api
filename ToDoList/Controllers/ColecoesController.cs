using Microsoft.AspNetCore.Mvc;
using projeto.ToDoList.Models;
using projeto.ToDoList.Repositories.Interfaces;

namespace projeto.ToDoList.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ColecoesController : ControllerBase
    {
        private readonly IColecaoRepository _colecaoRepository;

        public ColecoesController(IColecaoRepository colecaoRepository)
        {
            _colecaoRepository = colecaoRepository;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_colecaoRepository.Listar());
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok(_colecaoRepository.ObterPorId(id));
        }

        [HttpPost]
        public IActionResult Create([FromBody] ColecaoModel model)
        {
            _colecaoRepository.Adicionar(model);
            return Created("", model);
        }
    }
}
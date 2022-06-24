using Microsoft.AspNetCore.Mvc;
using projeto.ToDoList.Models;
using projeto.ToDoList.Repositories.Interfaces;

namespace projeto.ToDoList.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ModelosController : ControllerBase
    {
        private readonly IModeloRepository _modeloRepository;

        public ModelosController(IModeloRepository modeloRepository)
        {
            _modeloRepository = modeloRepository;
        }

        [HttpGet]
        public IActionResult Get()
            => Ok(_modeloRepository.Listar());

        [HttpGet]
        [Route("{id}")]
        public IActionResult GetById([FromQuery] int id)
            => Ok(_modeloRepository.ObterPorId(id));

        [HttpPost]
        public IActionResult Create([FromBody] ModeloModel model)
        {
            _modeloRepository.Adicionar(model);
            return Created("", model);
        }
    }
}
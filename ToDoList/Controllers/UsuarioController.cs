using Microsoft.AspNetCore.Mvc;
using projeto.ToDoList.Models;
using projeto.ToDoList.Repositories.Interfaces;

namespace projeto.ToDoList.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuarioController : ControllerGenerico<UsuarioModel, IUsuarioRepository>
    {
        public UsuarioController(IUsuarioRepository usuarioRepository) : base(usuarioRepository)
        {

        }
    }
}
using System;

namespace projeto.ToDoList.Models
{
    public class UsuarioModel : BaseModel
    {
        public string Nome { get; set; }
        public DateTime DataDeNascimento { get; set; }
    }
}
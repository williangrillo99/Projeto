using Microsoft.AspNetCore.Mvc;

namespace Servico_Boletim.API.Controllers
{
    [ApiController]
    [Route("api/controller")]
    public class AlunoController : ControllerBase
    {
        public IEnumerable<Aluno> _aluno = new Aluno[]{
            new Aluno(){
                AlunoId = 1,
                Matricula = 20193920,
                Nome = "Willian",
                Curso = "Ciencias da computacao",
                Turma = "Turma5CC",
                Email = "teste@teste.com",
                Celular = 99,
                imagemUrl = "foto.png"
            },
                new Aluno(){
                AlunoId = 2,
                Matricula = 201,
                Nome = "fulano",
                Curso = "Ciencias ",
                Turma = "Turma1VV",
                Email = "te@teste.com",
                Celular = 9,
                imagemUrl = "foto.png"
            },
        };
        public AlunoController()
        {

        }
        [HttpGet]
        public IEnumerable<Aluno> get()
        {
           return _aluno;
        }
        [HttpGet("{id}")]
        public IEnumerable<Aluno> GetById(int id)
        {
            return _aluno.Where(aluno => aluno.AlunoId == id);
        }
    }
}
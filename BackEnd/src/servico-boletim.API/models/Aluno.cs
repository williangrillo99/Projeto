namespace  Servico_Boletim.API.Controllers
{
    public class Aluno
    {
        public int AlunoId { get;set; }

        public int Matricula{get;set;}
        
        public string Nome {get; set;}
        public string Curso{get;set;}

        public string Turma{get;set;}
        
        public string Email {get;set;}

        public int Celular{get;set;}

        public string imagemUrl{get;set;}

    }
}

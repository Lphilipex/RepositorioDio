using modulo2C.Models;

Pessoa p1 = new Pessoa();
p1.Nome = "sd";
p1.SobreNome =  "ccc";

Pessoa p2 = new Pessoa();
p2.Nome = "aaaa";
p2.SobreNome = "bbb";


curso cursoDeIngles = new curso();
cursoDeIngles.Nome = "ingles";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.ListarAlunos();








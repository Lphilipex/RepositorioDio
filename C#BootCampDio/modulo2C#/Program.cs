using modulo2C.Models;

Pessoa p1 = new Pessoa(nome: "paulinho", sobrenome: "paulada");//usar nome:/ sobrenome:  para dizer o nome do parametro e depois o valor 


Pessoa p2 = new Pessoa(nome: "pedrinho", sobrenome:"pedrada");



curso cursoDeIngles = new curso();
cursoDeIngles.Nome = "ingles";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.ListarAlunos();








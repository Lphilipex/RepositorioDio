using modulo2C.Models;
//------------------------------------------------------------------------------------------
using System.Globalization;// mudar a regiao do codigo 
CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-Br");//mudar a regiao do codigo 
//------------------------------------------------------------------------------
decimal valorMonetario = 1182.40M;//variavel para valor monetario 

Console.WriteLine($"{valorMonetario:c}");//:c para usar para formatar com o valor de onde esta configurada sua maquina ou a que vc colocar no sistema 
//-------------------------------------------------------------------------------------------------

double porcetagem = .3421;//porcetagem

Console.WriteLine(porcetagem.ToString("P"));

int numero = 123456;
Console.WriteLine(numero.ToString("##-##-##"));// separar com -- a variavel
//-------------------------------------------------------------------------------------

//utilizar data atual
DateTime data = DateTime.Now;
Console.WriteLine(data);
//so hora 
DateTime data2 = DateTime.Now;
Console.WriteLine(data2.ToShortDateString());
//so hora
// string dataString = "2022-13-17 18:00"; 
DateTime data3 = DateTime.Parse("18/04/2022 13:15:00");//TryParseExact(datastring, "yyy-MM-dd HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.none out data); metodo para ter exatamanete como vc quer 
Console.WriteLine(data3);

//------------------------------------------------------------------------------
Pessoa p1 = new Pessoa(nome: "paulinho", sobrenome: "paulada");//usar nome:/ sobrenome:  para dizer o nome do parametro e depois o valor 
Pessoa p2 = new Pessoa(nome: "pedrinho", sobrenome:"pedrada");

curso cursoDeIngles = new curso();
cursoDeIngles.Nome = "ingles";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.ListarAlunos();
//----------------------------------------------------------------------------------








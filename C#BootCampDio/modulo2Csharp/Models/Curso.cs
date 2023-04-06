using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace modulo2C.Models
{
    public class curso
    {

        public string Nome { get; set; }//nome do curso 
        public List<Pessoa> Alunos { get; set; }// lista de alunos
        public void AdicionarAluno(Pessoa aluno)//metodo void significa vazio e não retorna nada 
        {
            Alunos.Add(aluno);
        }

        public int ObterQunatidadeDeAlunosMatriculados()
        {
            int quantidae = Alunos.Count;
            return quantidae;
        }


        public bool RemovberAluno(Pessoa aluno)
        {
            return Alunos.Remove(aluno);
        }

        public void ListarAlunos()
        {
            Console.WriteLine($"alunos do curso de: {Nome}");
            
            for (int count = 0; count < Alunos.Count; count++)//criação contador 
            {
                // string texto ="N° " + count + " - " + Alunos[count].NomeCompleto;// variavel para concatenar para exibir meu texto final
                string texto = $"N° {count + 1} - {Alunos[count].NomeCompleto} ";//interpolação de string
                Console.WriteLine(texto);//texto final 
            }
            
            // foreach (Pessoa aluno in Alunos)
            // {
                    
            //     Console.WriteLine(aluno.NomeCompleto);
            // }
        }

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace modulo2C.Models
{
    public class Pessoa // criei a classe pessoa com as propriedade nome e idade 
    {

        public Pessoa()//esse nao recebe nada 
        {
            
        }// e possivel ter mais de 1 construtor
        public Pessoa(string nome, string sobrenome)//esse recebe nome e sobre nome
        {
            Nome = nome;
            SobreNome = sobrenome;
        }//construtor, todo construtor tem o nome da classe e vem abaixo da classe e não tem um tipo de retorno  


        private string _nome; //so e permitido acessar dentro da propria classe
        private int _idade; //so e permitido acessar dentro da propria classe
        
        public string Nome // qualquer um pode instaciar a propriedade  
        {
        //    get => _nome.ToUpper();
           
        //    set => _nome = value;
           
           
            get
            {
                return _nome.ToUpper();// transformar em maiuscolo .Toupper
            }


             set
            {
                if (value == "")// value argumento que esta recebendo o nome 
                {
                    throw new ArgumentException("o nome não pode ser vazio!");
                }

                 _nome = value;// atribuir o valor no
            
            
            
            }



        }//get e set significa 2 ações get obter, o valor e set e passar o valor

        public Pessoa(string sobreNome) 
        {
            this.SobreNome = sobreNome;
   
        }
                public string SobreNome { get; set; }

        public string NomeCompleto =>$"{Nome} {SobreNome}".ToUpper();// aqui não pode se modificar so ler
        public int Idade 
        {
            get => _idade;
            
            set
            {

                if(value < 0)
                {
                    throw new ArgumentException("a idade não pode ser menor que 0 ");
                }

                _idade = value;

            } 
        }//get e set significa 2 ações get obter, o valor e set e passar o valor  

        public void Apresentar()
        {
            Console.WriteLine($"Nome: {NomeCompleto}");
            Console.WriteLine($"idade: {Idade}");
        }

    }
}
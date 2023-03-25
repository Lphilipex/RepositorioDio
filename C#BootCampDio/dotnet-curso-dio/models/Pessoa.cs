

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace DotnetCursoDio.Models // nome da classe para usar no programa.cs
{
        //inicio 
    public class Pessoa //criar classe pessoa
    {
        public string Nome { get; set; } // caracteristica da classe 
        public int Idade { get; set; } //caracteristica da classe

        public void Apresentar() // metodo da funcoa  
        {

           // Console.Write($"Olá! Meu nome é {Nome} \n e tenho {Idade} anos"); quebra de linha ao impresso no terminal 
            Console.WriteLine($"Olá! Meu nome é {Nome} e tenho {Idade} anos");
        }


    }
     // fim do programa 
}
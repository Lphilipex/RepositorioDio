using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sistemaDeHospedagem.Models
{
    public class Pessoa {
    public string Nome { get; set; }
    public int Idade { get; set; }
    
    public Pessoa(string nome, int idade) {
        Nome = nome;
        Idade = idade;
    }
}
}
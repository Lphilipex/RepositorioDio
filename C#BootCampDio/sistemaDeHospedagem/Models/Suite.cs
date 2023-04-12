using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sistemaDeHospedagem.Models
{
    public class Suíte {
    public string Tipo { get; set; }
    public double ValorDiária { get; set; }
    public int Capacidade { get; set; }
    
    public Suíte(string tipo, double valorDiária, int capacidade) {
        Tipo = tipo;
        ValorDiária = valorDiária;
        Capacidade = capacidade;
    }
}
}
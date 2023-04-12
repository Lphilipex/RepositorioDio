using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sistemaDeHospedagem.Models
{
    public class Reserva {
    public Pessoa Hóspede { get; set; }
    public Suíte SuíteReservada { get; set; }
    public DateTime DataEntrada { get; set; }
    public DateTime DataSaída { get; set; }
    
    public double ValorTotal {
        get {
            double valor = (DataSaída - DataEntrada).TotalDays * SuíteReservada.ValorDiária;
            
            if ((DataSaída - DataEntrada).TotalDays > 10) {
                valor *= 0.9;
            }
            
            return valor;
        }
    }
    
    public Reserva(Pessoa hóspede, Suíte suíteReservada, DateTime dataEntrada, DateTime dataSaída) {
        Hóspede = hóspede;
        SuíteReservada = suíteReservada;
        DataEntrada = dataEntrada;
        DataSaída = dataSaída;
    }
}

}
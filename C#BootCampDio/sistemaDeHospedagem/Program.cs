using sistemaDeHospedagem.Models;
class Program {
    static void Main(string[] args) {
        Pessoa hóspede = new Pessoa("Fulano", 25);
        Suíte suíte = new Suíte("Luxo", 500.0, 2);
        DateTime dataEntrada = new DateTime(2023, 4, 20);
        DateTime dataSaída = new DateTime(2023, 4, 30);
        
        Reserva reserva = new Reserva(hóspede, suíte, dataEntrada, dataSaída);
        
        Console.WriteLine($"Valor total da reserva: R$ {reserva.ValorTotal:F2}");
    }
}
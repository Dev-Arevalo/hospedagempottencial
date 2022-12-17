using System.Text;
using ProjetoHospedagem.Models;

Console.OutputEncoding = Encoding.UTF8;

List<Pessoa> hospedes = new List<Pessoa>();

Pessoa p1 = new Pessoa(nome: "Hóspede 1", sobrenome: "");
Pessoa p2 = new Pessoa(nome: "Hóspede 2", sobrenome: "");
Pessoa p3 = new Pessoa(nome: "Hóspede 3", sobrenome: "");


hospedes.Add(p1);
hospedes.Add(p2);
hospedes.Add(p3);


Suite suite = new Suite(tipoSuite: "Premium", capacidade: 3, valorDiaria: 30);


Console.WriteLine("Quantidade de dias reservados ?");
int diasReservados = Convert.ToInt32(Console.ReadLine());

Reserva reserva = new Reserva(diasReservados);
reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);


Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
Console.WriteLine($"Valor diária: R$ {reserva.CalcularValorDiaria()}");
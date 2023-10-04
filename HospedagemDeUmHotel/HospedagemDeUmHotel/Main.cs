using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospedagemDeUmHotel
{
    class Maine
    {
        

        
        //exibir quantidade de hospede e valor da reserva
        static void Main(string[] args)
        {
            //criar lista de pessoas
            List<Pessoa> hospedes = new List<Pessoa>();
            Pessoa p1 = new Pessoa();
            Pessoa p2 = new Pessoa();
            p1.Nome = "Albuquerque";
            p1.Sobrenome = "Leandro";
            p2.Nome = "Fagundes";
            p2.Sobrenome = "Antônio";

            //cirar suite 
            Suite suite = new Suite
            {
                Capacidade = 10,
                TipoSuite = "2",
                ValorDiario = 45
            };


            //criar reserva
            int DiasReservados = 10;
            Reserva reserva = new Reserva();
            reserva.DefinirDiasReservados(DiasReservados);

            //
            hospedes.Add(p1);
            hospedes.Add(p2);

            reserva.CadastrarSuite(suite);
            reserva.CadastrarHospedes(hospedes);
            int quantidadeHospedes = reserva.ObterQuantidadeDeHospedes(hospedes);
            decimal valor = reserva.CalcularValorDiaria(suite);

            // qunatidade de hospede e valor da diaria
            Console.WriteLine($"A quantidade de Hóspedes: {quantidadeHospedes}");
            Console.WriteLine($"O valor da diaria: {valor}");
            Console.Read();


        }
    }
}

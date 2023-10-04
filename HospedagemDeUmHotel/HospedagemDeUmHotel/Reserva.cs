using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HospedagemDeUmHotel
{
    class Reserva
    {
        public int DiasReservados { get; set; }
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }

        public Reserva()
        {
           
        }
        public void DefinirDiasReservados(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            //verificar se o numero de hospedes nao e maior que a quantidade de suites - ok


            if (hospedes.Count<=Suite.Capacidade)
            {
                Hospedes = hospedes;
            }
            else
            {
                //cathexpetion
                throw new ArgumentOutOfRangeException(nameof(Suite.Capacidade), "A quantidade de pessoas" +
                    $"não deve ser maior que {Suite.Capacidade}");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeDeHospedes(List<Pessoa> hospedes)
        {
            int a=0;
            foreach(Pessoa hospede in hospedes)
            {
                a++;
            }
            return a;
        }

        //se dias reservados maior que 10, dar desconto sw 10%
        public decimal CalcularValorDiaria(Suite suite)
        {
            decimal ValorDiaria;
            ValorDiaria = suite.ValorDiario;
            if(DiasReservados > 10)
            {
                ValorDiaria = ValorDiaria - (10/100) * ValorDiaria;
                return ValorDiaria;
            }
            else
            {
                return ValorDiaria;
            }
            
        }



    }
}

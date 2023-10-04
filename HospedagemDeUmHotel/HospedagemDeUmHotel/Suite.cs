using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospedagemDeUmHotel
{
    class Suite
    {
        public string TipoSuite { get; set; }
        public int Capacidade { get; set; }
        public decimal ValorDiario { get; set; }

        public Suite()
        {

        }

        public Suite(string tipoSuite, int capacidade, decimal valorDiario)
        {
            TipoSuite = tipoSuite;
            Capacidade = capacidade;
            ValorDiario = valorDiario;
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospedagem.Models
{
    internal class Suite
    {
        //Construtor
        public Suite(string tiposuite, int capacidade, decimal valordiario)
        {
            this.tipoSuite = tiposuite;
            this.Capacidade = capacidade;
            this.ValorDiario = valordiario;
        }

        //Encapsulamento
        private string _tiposuite;
        private int _capacidade;
        private decimal _valordiaria;

        //Propriedades
        public string tipoSuite { get; set; }
        public int Capacidade { get; set; }
        public decimal ValorDiario { get; set; }

        public string suiteCompleto => $"Tipo da suíte: {tipoSuite}, Capacidade: {Capacidade}, Valor da diária: {ValorDiario}";

    }
}

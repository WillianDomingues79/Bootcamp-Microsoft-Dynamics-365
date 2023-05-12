using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospedagem.Models
{
    internal class Reserva
    {
        //Propriedades
        public List<Pessoa> Hospedes { get; set; }
        public int diasReservados { get; set; }
        public Suite Suite { get; set; }

        //Construtor
        public Reserva(int diasreservados)
        {
            this.diasReservados = diasreservados;
        }

        //Encapsulamento
        private int _diasreservados;


        //Métodos
        public void cadastrarHospedes(Pessoa hospede)
        {
            Hospedes.Add(hospede);
        }

        public void cadastrarSuite(Suite suite)
        {
            Suite = suite;
            if(suite.Capacidade < Hospedes.Count)
            {
                Console.WriteLine($"Capacidade da suite: {suite.Capacidade}");
                Console.WriteLine("Quantidade de Hóspedes maior que a capacidade da suite, verifique!");
                Environment.Exit(0);
            } else
            Console.WriteLine($"Sua Suite é a: {suite.suiteCompleto}");
        }

        public int obterQuantidade()
        {
            int Quantidade = Hospedes.Count;
            Console.WriteLine($"Quantidade de Hóspedes: {Quantidade}");
            return Quantidade;
        }

        public decimal calcularValorDiaria()
        {
            decimal total;
            if(diasReservados >= 10)
            {
                decimal totalDiaria = (Suite.ValorDiario * diasReservados);
                decimal totalDiaria1 = totalDiaria * 0.10m;
                decimal resultado = totalDiaria - totalDiaria1;
                Console.WriteLine($"Sua diária irá ficar: R${resultado}");
                return resultado;
            }else
            {
                total = (Suite.ValorDiario * diasReservados);
                Console.WriteLine($"Sua diária irá ficar: R${total.ToString("C")}");
                return total;
            }
            
        }

        public void mostrarHospedes()
        {
            Console.WriteLine("*** Lista dos Hóspedes ***");
            foreach (var hospede in Hospedes)
            {
                Console.WriteLine(hospede.NomeCompleto);
            }
        }

    }
}

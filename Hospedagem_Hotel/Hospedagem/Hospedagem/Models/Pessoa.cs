using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Hospedagem.Models
{
    internal class Pessoa
    {

        public Pessoa(string nome, string sobrenome)
        {
            this.Nome = nome;
            this.Sobrenome = sobrenome;
        }

        //Encapsulamento
        private string _nome;
        private string _sobrenome;

        //Propriedades
        public string Nome { get; set; }
        public string Sobrenome { get; set; }

        public string NomeCompleto => $"{Nome} {Sobrenome}";

    }
}

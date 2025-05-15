using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaHospedagem.Models
{
    internal class Pessoa
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public Pessoa(string nome, string sobrenome)
        {
            Nome = nome;
            Sobrenome = sobrenome;
        }       
        public override string ToString()
        {
            return ($"{Nome} {Sobrenome}".ToUpper());
        }
    }
}

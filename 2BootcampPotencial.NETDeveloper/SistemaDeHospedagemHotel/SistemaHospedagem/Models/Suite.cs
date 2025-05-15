using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaHospedagem.Models
{
    internal class Suite
    {
        public string TipoSuite { get; set; }
        public int Capacidade { get; set; }
        public decimal ValorDiaria { get; set; }
        public Suite()
        {
        }
        public Suite(string tipoSuite, int capacidade, decimal valorDiaria)
        {
            TipoSuite = tipoSuite;
            Capacidade = capacidade;
            ValorDiaria = valorDiaria;
        }
        public void SelecaoSuite(int selecaoMenu)
        {
            if (selecaoMenu == 1)
            {
                TipoSuite = "GOLD";
                Capacidade = 6;
                ValorDiaria = 900.00M;
            }
            else if (selecaoMenu == 2)
            {
                TipoSuite = "SILVER";
                Capacidade = 4;
                ValorDiaria = 580.00M;
            }
            else if (selecaoMenu == 3)
            {
                TipoSuite = "PLATINUM";
                Capacidade = 2;
                ValorDiaria = 280.00M;
            }
        }
    }
}

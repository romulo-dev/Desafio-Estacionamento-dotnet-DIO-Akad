using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioFundamentos.Models
{
    public class Carro
    {
        public string Placa { get; set; }
        public string Cor { get; set; }
        public bool EstaEstacionado { get; set; }

        public Carro(string placa, string cor)
        {
            Placa = placa;
            Cor = cor;
            EstaEstacionado = false;
        }

        public void alteraEstadoEstacionamento()
        {
            if (!EstaEstacionado)
            {
                EstaEstacionado = true;
            }
            else
            {
                EstaEstacionado = false;
            }
        }
    }
}
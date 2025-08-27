using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioFundamentos.Models
{
    public class Veiculo
    {
        public string Placa { get; set; }
        public string Cor { get; set; }
        public bool EstaEstacionado { get; set; }

        public Veiculo(string placa, string cor)
        {
            Placa = placa;
            Cor = cor;
            EstaEstacionado = false;
        }

        public void alteraEstadoEstacionamento()
        {
            if (!this.EstaEstacionado)
            {
                this.EstaEstacionado = true;
            }
            else
            {
                this.EstaEstacionado = false;
            }
        }
    }
}
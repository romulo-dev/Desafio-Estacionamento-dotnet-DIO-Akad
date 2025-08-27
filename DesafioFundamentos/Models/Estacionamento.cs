namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<Veiculo> ve = new List<Veiculo>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculoEstacionamento(List<Veiculo> veiculos)
        {
            
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            string placa = Console.ReadLine();

            foreach (Veiculo veiculo in veiculos)
            {
                if (veiculo.Placa.Equals(placa))
                {
                    if (!veiculo.EstaEstacionado)
                    {
                        this.ve.Add(veiculo);
                        veiculo.alteraEstadoEstacionamento();
                        return;
                    }
                }
            }

            Console.WriteLine("Veículo inexistente no Sistema");

        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");
            string placa = Console.ReadLine();
            
            foreach (Veiculo veiculo in ve)
            {
                if (veiculo.Placa.Equals(placa))
                {
                    Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                    string horasString = Console.ReadLine();
                    int horas = Convert.ToInt32(horasString);
                    decimal valorTotal = this.precoInicial + this.precoPorHora * horas;
                    ve.Remove(veiculo);
                    veiculo.alteraEstadoEstacionamento();
                    Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
                    return;
                }
            }

            Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
           
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (ve.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                // TODO: Realizar um laço de repetição, exibindo os veículos estacionados
                foreach (Veiculo item in ve)
                {
                    Console.WriteLine($"Veículo de placa: {item.Placa} com cor {item.Cor}");
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}

namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private string? placaVeiculo = string.Empty;
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            // TODO: Pedir para o usuário digitar uma placa (ReadLine) e adicionar na lista "veiculos"
            // *IMPLEMENTE AQUI*
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            placaVeiculo = Console.ReadLine();
            veiculos.Add(placaVeiculo.ToUpper());
            Console.WriteLine("(Pressione qualquer tecla para continuar...)");
            Console.ReadKey();
            Console.Clear();
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Entre com a placa do veículo:");

            string? pp = Console.ReadLine().ToUpper();

            int indice = veiculos.IndexOf(pp);
            if (indice >= 0)
            {
                Console.WriteLine("Veículo encontrado");

                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                int quantidadeHoras = Convert.ToInt32(Console.ReadLine());

                decimal valorDevido = precoInicial + (precoPorHora * quantidadeHoras);

                Console.WriteLine("Deseja excluir este veículo? (S/N)");

                if (Console.ReadLine().ToUpper() == "S")
                {

                    veiculos.RemoveAt(indice);
                    Console.WriteLine($"Veículo {pp} excluído com sucesso e o preço total foi de R$ {valorDevido}.");
                    Console.WriteLine("(Pressione qualquer tecla para continuar...)");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
            else
            {
                Console.WriteLine("Não foi encontrado nenhum veículo com essa placa!");
                Console.WriteLine("(Pressione qualquer tecla para continuar...)");
                Console.ReadKey();
                Console.Clear();
            }
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Count > 0)
            {

                Console.WriteLine("Lista de veículos estacionados:");

                foreach (string placa in veiculos)
                {
                    Console.WriteLine($" Veículo: {placa.ToUpper()}");
                }
            }
            else
            {
                Console.WriteLine("Estacionamento vazio.");
            }
            Console.WriteLine("(Pressione qualquer tecla para continuar...)");
            Console.ReadKey();
            Console.Clear();
        }
    }
}

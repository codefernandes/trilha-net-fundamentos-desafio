using DesafioFundamentos.Models;

// Coloca o encoding para UTF8 para exibir acentuação
Console.OutputEncoding = System.Text.Encoding.UTF8;

bool exibirMenu = true;

decimal valorInicial = 0;
decimal valorHora = 0;


Console.WriteLine("====== Seja bem vindo ao nosso estacionamento ======");
Console.WriteLine("Entre com o valor inicial: ");
valorInicial = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Entre com o valor por hora: ");
valorHora = Convert.ToDecimal(Console.ReadLine());
Console.Clear();

// Instancia a classe Estacionamento, já com os valores obtidos anteriormente
Estacionamento es = new Estacionamento(valorInicial, valorHora);

while (exibirMenu)
{
    Console.WriteLine("====== Selecione uma Opção ======");
    Console.WriteLine("1 - Cadastrar Veículo");
    Console.WriteLine("2 - Remover Veículo");
    Console.WriteLine("3 - Listar Veículos");
    Console.WriteLine("4 - Encerrar");
    string? opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1": // Cadastrar veículo
            es.AdicionarVeiculo();

            break;

        case "2": // Remover veículo

            es.RemoverVeiculo();

            break;

        case "3": // Listar veículos

            es.ListarVeiculos();

            break;

        case "4": // Sair do Sistema
            Environment.Exit(0);
            break;

        default:
            Console.WriteLine("Opção inválida!");
            Console.WriteLine("(Pressione qualquer tecla para continuar...)");
            Console.ReadKey();
            Console.Clear();
            break;
    }


}

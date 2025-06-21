using Estacionamento.obj.models;

//Mensagem de boas vindas
Console.WriteLine("Bem vindo a rede de estacionamentos GuxtavoPark");

//Inserção do valor inicial e valor por hora
Console.Write("Digite o valor inicial: R$ ");
decimal precoInicial = Convert.ToDecimal(Console.ReadLine());
Console.Write("Digite o preço por hora: R$ ");
decimal precoHora = Convert.ToDecimal(Console.ReadLine());

//Criação de instância
List<string> cadastrados = new List<string>();
EstacionamentoOpcoes opcoes = new EstacionamentoOpcoes();

//Aberturas de variáveis
string opcao;
bool exibMenu = true;

//Início no WHILE do menu princípal
while (exibMenu)
{
    Console.WriteLine("Escolha uma opção");
    Console.WriteLine("1 - Cadastrar Veículo");
    Console.WriteLine("2 - Remover Veículo");
    Console.WriteLine("3 - Listar Veículos");
    Console.WriteLine("4 - Encerrar");
    opcao = Console.ReadLine() ?? "";
    switch (opcao)
    {
        //Opção 1 para Cadastro de veículo
        case "1":
            {
                Console.WriteLine("Digite a placa do veículo para cadastrar: ");
                string placa = Console.ReadLine() ?? "";
                opcoes.Cadastro(cadastrados, placa);
                opcoes.PausarConsole();
                break;
            }

        //Opção 2 para Remoção de veículo
        case "2":
            {
                //Solicitação de placa para remoção
                Console.WriteLine("Digite a placa do veículo para remover");
                String placaRemover = Console.ReadLine() ?? "";
                opcoes.RemoverCarro(cadastrados, placaRemover);

                //Solicitação de quantas horas ficou para cálculo
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu");
                string inputHoras = Console.ReadLine() ?? "";
                decimal horas;
                if (decimal.TryParse(inputHoras, out horas))
                {
                    decimal valorFinal = opcoes.PrecoFinal(precoInicial, precoHora, horas);
                    Console.WriteLine($"O veículo {placaRemover} foi removido e o preço total foi de: R$ {valorFinal}");
                }
                else
                {
                    Console.WriteLine("Entrada inválida. Digite um número válido para as horas.");
                }
                opcoes.PausarConsole();
                break;
            }

        //Opção 3 para fazer a listagem dos veículos que estão no estacionamento
        case "3":
            {
                foreach (string veiculo in cadastrados)
                {
                    Console.WriteLine($"{veiculo}");
                }
                opcoes.PausarConsole();
                break;
            }

        //Opção 4 para finalização do programa
        case "4":
            {
                Console.WriteLine("Encerrando...");
                exibMenu = false;
                break;
            }
    }
}
//Agradecimento final por usar o sistema
Console.WriteLine("Obrigado por usar o nosso sistema!");


//Screen Sound

string mensagemDeBoasVindas = "Boas vindas ao Screen Sound\n";
List<string> listaDasBandas = new List<string> { "Kiss", "U2", "Iron Maiden" };



void ExibirLogo()
{
    Console.WriteLine(@"
░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
");
    Console.WriteLine(mensagemDeBoasVindas);
}


void ExibirOpcoesDoMenu()
{
    ExibirLogo();
    Console.WriteLine("Digite 1 para registra uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a média de uma banda");
    Console.WriteLine("Digite -1 para sair");

    Console.Write("\nDigite a sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

    switch (opcaoEscolhidaNumerica)
    {
        case 1: RegistrarBanda();
            break;
        case 2: MostrarBandasRegistradas();
            break;
        case 3:
            Console.WriteLine("Voce escolhey a opcao: " + opcaoEscolhidaNumerica);
            break;
        case 4:
            Console.WriteLine("Voce escolhey a opcao: " + opcaoEscolhidaNumerica);
            break;
        case -1:
            Console.WriteLine("Tchau, tchau :)");
            break;
        default: Console.WriteLine("Opcao invalida!");
            break;
    }
}

void RegistrarBanda()
{
    Console.Clear();
    Console.WriteLine("*******************");
    Console.WriteLine("Registro de Bandas");
    Console.WriteLine("*******************\n\n");
    Console.Write("Digite o nome da banda que deseja registrar: ");
    string nomeDaBanda = Console.ReadLine()!; 
    listaDasBandas.Add(nomeDaBanda);
    Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso!");
    Thread.Sleep(2000);
    Console.Clear();
    ExibirOpcoesDoMenu();
}

void MostrarBandasRegistradas()
{
    Console.Clear();
    Console.WriteLine("****************************");
    Console.WriteLine("Exibindo Bandas Registradas");
    Console.WriteLine("****************************\n\n");
    //for (int i = 0; i < listaDasBandas.Count; i++)
    //{
    //    Console.WriteLine($"Banda: {listaDasBandas[i]}");
    //}
    foreach (string banda in listaDasBandas)
    {
        Console.WriteLine($"Banda: {banda}");
    }
    Console.WriteLine("\n\nDigite uma tecla para voltar ao menu inicial");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesDoMenu();
}

ExibirOpcoesDoMenu();
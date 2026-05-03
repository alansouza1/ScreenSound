string welcomeMessage = "Boas vindas ao Screen Sound!";
List<string> bandsList = new List<string> { "The Beatles", "AC/DC", "Barenaked Ladies" };

void DisplayLogo()
{
    Console.WriteLine(@"
░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
");
    Console.WriteLine(welcomeMessage);
}

void DisplayMenuOptions()
{
    Console.Clear();
    DisplayLogo();
    Console.WriteLine("\n1 - Registrar uma banda");
    Console.WriteLine("2 - Mostrar todas as bandas");
    Console.WriteLine("3 - Avaliar uma banda");
    Console.WriteLine("4 - Exibir a média de uma banda");
    Console.WriteLine("0 - Sair");

    Console.Write("\nDigite o número da sua opção: ");
    string chosenOption = Console.ReadLine()!;
    int numericChosenOption = int.Parse(chosenOption);

    switch (numericChosenOption)
    {
        case 1:
            RegisterBand();
            break;
        case 2:
            DisplayRegisteredBands();
            break;
        case 3:
            Console.WriteLine("Você escolheu a opção " + numericChosenOption);
            break;
        case 4:
            Console.WriteLine("Você escolheu a opção " + numericChosenOption);
            break;
        case 0:
            Console.WriteLine("Tchau tchau :)");
            break;
        default:
            Console.WriteLine("Opção inválida");
            break;
    }
}

void RegisterBand()
{
    Console.Clear();
    Console.WriteLine("******************");
    Console.WriteLine("Registro de bandas");
    Console.WriteLine("******************\n");
    Console.Write("Digite o nome da banda que deseja registrar: ");
    string bandName = Console.ReadLine()!;
    bandsList.Add(bandName);
    Console.WriteLine($"A banda {bandName} foi registrada com sucesso!");
    Thread.Sleep(2000);
    DisplayMenuOptions();
}

void DisplayRegisteredBands()
{
    Console.Clear();
    Console.WriteLine("************************************");
    Console.WriteLine("Exibindo todas as bandas registradas");
    Console.WriteLine("************************************\n");
    
    foreach (string band in bandsList)
    {
        Console.WriteLine($"Banda: {band}");
    }

    Console.WriteLine("\nPressione qualquer tecla para voltar ao menu principal");
    Console.ReadKey();
    DisplayMenuOptions();
}

DisplayMenuOptions();

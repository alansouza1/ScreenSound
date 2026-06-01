string welcomeMessage = "Boas vindas ao Screen Sound!";
Dictionary<string, List<int>> bandsList = new Dictionary<string, List<int>>();
bandsList.Add("AC/DC", new List<int>());
bandsList.Add("The Beatles", new List<int>());

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
            RateBand();
            break;
        case 4:
            BandAverage();
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
    DisplayOptionsTitle("Registro de bandas");
    Console.Write("Digite o nome da banda que deseja registrar: ");
    string bandName = Console.ReadLine()!;
    bandsList.Add(bandName, new List<int>());
    Console.WriteLine($"A banda {bandName} foi registrada com sucesso!");
    Thread.Sleep(3000);
    DisplayMenuOptions();
}

void DisplayRegisteredBands()
{
    Console.Clear();
    DisplayOptionsTitle("Exibindo todas as bandas registradas");
    
    foreach (string band in bandsList.Keys)
    {
        Console.WriteLine($"Banda: {band}");
    }

    Console.WriteLine("\nPressione qualquer tecla para voltar ao menu principal");
    Console.ReadKey();
    DisplayMenuOptions();
}

void DisplayOptionsTitle(string title)
{
    int lettersQtd = title.Length;
    string asterisks = string.Empty.PadLeft(lettersQtd, '*');
    Console.WriteLine(asterisks);
    Console.WriteLine(title);
    Console.WriteLine(asterisks + "\n");
}

void RateBand()
{
    Console.Clear();
    DisplayOptionsTitle("Avaliar banda");
    Console.Write("Digite o nome da banda que deseja avaliar: ");
    string bandName = Console.ReadLine()!;
    if (bandsList.ContainsKey(bandName))
    {
        Console.Write($"Digite uma nota de 1 a 10: ");
        int note = int.Parse(Console.ReadLine()!);
        bandsList[bandName].Add(note);
        Console.WriteLine($"\nA nota {note} foi registrada com sucesso para a banda {bandName}!");
        Thread.Sleep(3000);
        DisplayMenuOptions();
    }
    else
    {
        Console.WriteLine($"A banda {bandName} não foi encontrada!");
        Console.WriteLine("\nPressione qualquer tecla para voltar ao menu principal");
        Console.ReadKey();
        DisplayMenuOptions();
    }
}

void BandAverage()
{
    Console.Clear();
    DisplayOptionsTitle("Exibir média da banda");
    Console.Write("Digite o nome da banda ao qual deseja a média: ");
    string bandName = Console.ReadLine()!;
    if (bandsList.ContainsKey(bandName))
    {
        double average = bandsList[bandName].Average();
        Console.WriteLine($"\nA nota média da banda {bandName} é {average}!");
        Console.WriteLine("\nPressione qualquer tecla para voltar ao menu principal");
        Console.ReadKey();
        DisplayMenuOptions();
    }
    else
    {
        Console.WriteLine($"A banda {bandName} não foi encontrada!");
        Console.WriteLine("\nPressione qualquer tecla para voltar ao menu principal");
        Console.ReadKey();
        DisplayMenuOptions();
    }
}

DisplayMenuOptions();

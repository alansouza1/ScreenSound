string welcomeMessage = "Boas vindas ao Screen Sound!";

void DisplayMessage()
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
            Console.WriteLine("Você escolheu a opção " + numericChosenOption);
            break;
        case 2:
            Console.WriteLine("Você escolheu a opção " + numericChosenOption);
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

DisplayMessage();
DisplayMenuOptions();

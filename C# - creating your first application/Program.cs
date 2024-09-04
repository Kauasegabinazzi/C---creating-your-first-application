
void showMessage()
{
    string message = "Wellcome";
    Console.WriteLine(@"

░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
");
    Console.WriteLine(message);
}

void showOptions()
{
    Console.WriteLine("\ntype 1 to register a new band");
    Console.WriteLine("type 2 to show all bands");
    Console.WriteLine("type 3 to review a band");
    Console.WriteLine("type 4 to show average of indicators");
    Console.WriteLine("type -1 to exit");

    Console.Write("\ntype your option: ");
    string option = Console.ReadLine()!;
    int numberOption = int.Parse(option);

    switch (numberOption)
    {
        case 1:
            Console.WriteLine("");
            break;
        case 2:
            Console.WriteLine("");
            break;

        case 3:
            Console.WriteLine("");
            break;

        case 4:
            Console.WriteLine("");
            break;
        case -1:
            Console.WriteLine("");
            break;
        default:
            break;
    }
}


showMessage();
showOptions();

//string course = "C#: creating your first application";
//Console.WriteLine(course);

//string name = "Arthur";
//string lastName = "Fernandes";

//Console.WriteLine(name + lastName);
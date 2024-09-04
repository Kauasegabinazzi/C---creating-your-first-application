
using System.Xml.Linq;

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


//showMessage();
//showOptions();

//Console.WriteLine("Qual é o seu nome?");
//string nome = Console.ReadLine();
//Console.WriteLine("Olá, {0}!", nome);

//string course = "C#: creating your first application";
//Console.WriteLine(course);

//string name = "Arthur";
//string lastName = "Fernandes";

//Console.WriteLine(name + lastName);

int average = 5;
if (average >= 5)
{
    Console.WriteLine("teste");
}

List<string> langueges = new List<string> { "C#", "Java", "JavaScript" };

Console.WriteLine(langueges[2]);

int posicao = int.Parse(Console.ReadLine());
Console.WriteLine(langueges[posicao]);
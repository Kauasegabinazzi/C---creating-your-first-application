
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
            CreateBand();
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

void CreateBand()
{
    Console.Clear();
    Console.Write("type the name of the band : ");
    string name = Console.ReadLine();
    Console.WriteLine($"{name} was create with sucess");
    Thread.Sleep(2000);
    Console.Clear();
    showOptions();
}

showMessage();
showOptions();

#region Others

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

//int average = 5;
//if (average >= 5)
//{
//    Console.WriteLine("teste");
//}

//List<string> langueges = new List<string> { "C#", "Java", "JavaScript" };

//Console.WriteLine(langueges[2]);

//int posicao = int.Parse(Console.ReadLine());
//Console.WriteLine(langueges[posicao]);

//Random random = new Random();
//int number = random.Next(1, 101);

//do
//{
//    Console.Write("Digite um número entre 1 e 100: ");
//    int guess = int.Parse(Console.ReadLine());

//    if (guess == number)
//    {
//        Console.WriteLine("Parabéns! Você acertou o número.");
//        break;
//    }
//    else if (guess < number)
//    {
//        Console.WriteLine("O número é maior.");
//    }
//    else
//    {
//        Console.WriteLine("O número é menor.");
//    }

//} while (true);

#endregion

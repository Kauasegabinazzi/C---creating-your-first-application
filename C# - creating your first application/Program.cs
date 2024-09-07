
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

Dictionary<string, List<int>> createdBands = new Dictionary<string, List<int>>();
createdBands.Add("linkin park", new List<int> { 10, 8, 9 });
createdBands.Add("Nirvana", new List<int> { 6, 7, 9 });

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
            ShowBand();
            break;

        case 3:
            EvaluateBand();
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
    ShowTitleOption("New Band");
    Console.Write("type the name of the band : ");
    string name = Console.ReadLine()!;
    createdBands.Add(name, new List<int>());
    Console.WriteLine($"{name} was create with sucess");
    Thread.Sleep(2000);
    Console.Clear();
    showOptions();
}

void ShowBand()
{
    Console.Clear();

    ShowTitleOption("Show Bands");

    //for(int i = 0; i < listBand.Count; i++)
    //{
    //    Console.WriteLine($"Band : {listBand[i]}");
    //}

    foreach (string item in createdBands.Keys)
    {
        Console.WriteLine($"Band : {item}");
    }

    Console.WriteLine("type to go back to menu");
    Console.ReadKey();
    Console.Clear();
    showOptions();
}

void ShowTitleOption(string title)
{
    int quantity = title.Length;
    string asterisks = string.Empty.PadLeft(quantity, '*');
    Console.WriteLine(asterisks);
    Console.WriteLine(title);
    Console.WriteLine(asterisks + "\n");
}

void EvaluateBand()
{
    Console.Clear();
    ShowTitleOption("To evalueate a band");
    Console.Write("Type the name of the band you want evaluate : ");
    string name = Console.ReadLine()!;
    if (createdBands.ContainsKey(name))
    {
        Console.Write($"What is the score of {name} ? ");
        int score = int.Parse(Console.ReadLine()!);
        createdBands[name].Add(score);
        Console.WriteLine("\nSucess");
        Thread.Sleep(4000);
        Console.Clear();
        showOptions();
    }
    else
    {
        Console.WriteLine("Not find");
        Console.WriteLine("type to go back to menu");
        Console.ReadKey();
        Console.Clear();
        showOptions();
    }
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

//List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

//foreach (int number in numbers)
//{
//    if (number % 2 == 0)
//    {
//        Console.WriteLine(number);
//    }
//}

#endregion

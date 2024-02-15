// Screen Sound
//List<string> bandsList = new() { "AC/DC", "Nirvana", "Gun's in Roses" };

Dictionary<string, List<int>> bandsDictionary = new()
{
    { "leo", new List<int> { 10, 5, 8 } }
};

void ShowMessage()
{
    Console.WriteLine(@"
        
░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
    ");
    Console.WriteLine("Welcome to the Screen Sound 2.0\n");
}

void ShowOptions()
{
    ShowMessage();
    Console.WriteLine("1 - Register a band");
    Console.WriteLine("2 - Show all bands");
    Console.WriteLine("3 - Rate a band");
    Console.WriteLine("4 - Show bands media");
    Console.WriteLine("5 - Exit Program");

    Console.Write("\nType your option: ");
    string userOption = Console.ReadLine()!;

    int userOptionInt = int.Parse(userOption);

    switch (userOptionInt)
    {
        case 1:
            RegisterBand();
            break;

        case 2:
            ShowAllBands();
            break;

        case 3:
            RateBand();
            break;

        case 4:
            ShowBandMedia();
            break;

        case 5:
            Console.WriteLine("See you later!");
            break;

        default:
            Console.WriteLine("The option " + userOptionInt + " there isn't in Options List");
            Console.WriteLine("Type again!");
            break;

    }
}

void RegisterBand()
{
    Console.Clear();
    Title("Band's Register");
    Console.Write("Type the band's name do you want register: ");
    string bandName = Console.ReadLine()!;
    bandsDictionary.Add(bandName, new List<int>());
    Thread.Sleep(2000);
    Console.WriteLine($"The band {bandName} was succesfully registered");
    Thread.Sleep(2000);
    Console.Clear();
    ShowOptions();
}

void ShowAllBands()
{
    Console.Clear();
    Title("Show All Bands");
    if (bandsDictionary.Count <= 0)
    {
        Console.WriteLine("Not have any Bands Registered!");
        Console.WriteLine("Returning to menu in 3 secconds");
        Thread.Sleep(3000);
        Console.Clear();
        ShowOptions();
    }
    else
    {
        //for (int i = 0; i < bandsList.Count; i++)
        //{
        //    Console.WriteLine($"Band's Name: {bandsList[i]}");
        //}
        foreach (string bandName in bandsDictionary.Keys)
        {
            Console.WriteLine($"Band's Name: {bandName}");
        }
        Console.WriteLine("\nType any key to return to menu");
        Console.ReadKey();
        Console.Clear();
        ShowOptions();
    }
}

void Title(string title)
{
    int qntTitle = title.Length;
    string symbols = string.Empty.PadLeft(qntTitle, '*');

    Console.WriteLine(symbols);
    Console.WriteLine(title);
    Console.WriteLine(symbols + "\n");
}

void RateBand()
{
    Console.Clear();
    Title("Rate a Band");

    Console.Write("Type a band's name to rate: ");
    string bandName = Console.ReadLine()!;

    if (bandsDictionary.ContainsKey(bandName))
    {
        Console.Write($"Type a number to rate {bandName}: ");
        int bandRateUser = int.Parse(Console.ReadLine()!);
        bandsDictionary[bandName].Add(bandRateUser);
        Console.WriteLine($"You typed {bandRateUser} to {bandName}\n");
        Console.WriteLine("Returning to menu in 3 secconds");
        Thread.Sleep(3000);
        Console.Clear();
        ShowOptions();
    }
    else
    {
        Console.WriteLine($"The band {bandName} wasn't register");
        Console.WriteLine("Returning to menu in 3 secconds");
        Thread.Sleep(3000);
        Console.Clear();
        ShowOptions();
    }
}

void ShowBandMedia()
{
    Console.Clear();
    Title("Show Band's Media");

    Console.Write("Type the band's name to search in database: ");
    string bandName = Console.ReadLine()!;

    if (bandsDictionary.ContainsKey(bandName))
    {
        List<int> bandRate = bandsDictionary[bandName];
        Console.Write($"{bandName} rate's media: {bandRate.Average().ToString("F2")}\n");
        Console.WriteLine("Type any key to return to menu");
        Console.ReadKey();
        Console.Clear();
        ShowOptions();
    }
    else
    {
        Console.WriteLine($"The band {bandName} wasn't register");
        Console.WriteLine("Returning to menu in 3 secconds");
        Thread.Sleep(3000);
        Console.Clear();
        ShowOptions();
    }
}

ShowOptions();
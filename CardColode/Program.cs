using CardColode.Controller;

var storage = new CardStorage();
var shuffler = new ColodeShuffler_Controller();

while (true)
{
    Console.Clear();
    Console.WriteLine("Меню управления колодами:");
    Console.WriteLine("1. Создать колоду");
    Console.WriteLine("2. Удалить колоду");
    Console.WriteLine("3. Перетасовать колоду");
    Console.WriteLine("4. Просмотреть колоду");
    Console.WriteLine("5. Список колод");
    Console.WriteLine("6. Выход");

    Console.Write("Выберите действие: ");
    var choice = Console.ReadLine();

    switch (choice)
    {
        case "1":
            CreateDeck(storage);
            break;
        case "2":
            RemoveDeck(storage);
            break;
        case "3":
            ShuffleDeck(storage, shuffler);
            break;
        case "4":
            ViewDeck(storage);
            break;
        case "5":
            ViewDeckList(storage);
            break;
        case "6":
            return;
        default:
            Console.WriteLine("Недопустимый выбор. Нажмите любую клавишу для продолжения...");
            Console.ReadKey();
            break;
    }
}

    static void CreateDeck(CardStorage storage)
{
    Console.Write("Введите имя колоды: ");
    var name = Console.ReadLine();

    try
    {
        storage.CreateDeck(name);
        Console.WriteLine("Колода создана успешно.");
    }
    catch (InvalidOperationException ex)
    {
        Console.WriteLine(ex.Message);
    }

    Console.WriteLine("Нажмите любую клавишу для продолжения...");
    Console.ReadKey();
}

static void RemoveDeck(CardStorage storage)
{
    Console.Write("Введите имя колоды для удаления: ");
    var name = Console.ReadLine();

    try
    {
        storage.RemoveDeck(name);
        Console.WriteLine("Колода удалена успешно.");
    }
    catch (InvalidOperationException ex)
    {
        Console.WriteLine(ex.Message);
    }

    Console.WriteLine("Нажмите любую клавишу для продолжения...");
    Console.ReadKey();
}

static void ShuffleDeck(CardStorage storage, ColodeShuffler_Controller shuffler)
{
    Console.Write("Введите имя колоды для перетасовки: ");
    var name = Console.ReadLine();

    try
    {
        storage.ShuffleDeck(name, shuffler);
        Console.WriteLine("Колода перетасована успешно.");
    }
    catch (InvalidOperationException ex)
    {
        Console.WriteLine(ex.Message);
    }

    Console.WriteLine("Нажмите любую клавишу для продолжения...");
    Console.ReadKey();
}

static void ViewDeck(CardStorage storage)
{
    Console.Write("Введите имя колоды для просмотра: ");
    var name = Console.ReadLine();

    try
    {
        var deck = storage.GetDeck(name);
        Console.WriteLine(deck);
    }
    catch (InvalidOperationException ex)
    {
        Console.WriteLine(ex.Message);
    }

    Console.WriteLine("Нажмите любую клавишу для продолжения...");
    Console.ReadKey();
}

static void ViewDeckList(CardStorage storage)
{
    var deckNames = storage.GetDeckNames();

    if (deckNames.Count == 0)
    {
        Console.WriteLine("Список колод пуст.");
    }
    else
    {
        Console.WriteLine("Список колод:");
        foreach (var name in deckNames)
        {
            Console.WriteLine(name);
        }
    }

    Console.WriteLine("Нажмите любую клавишу для продолжения...");
    Console.ReadKey();
}
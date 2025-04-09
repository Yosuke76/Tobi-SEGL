Console.WriteLine("Willkommen beim Todoinator!");
while(true)
{
    Console.WriteLine("""
    1. Neues Todo
    2. Todo abhaken
    """);
    var userMenuChoice = Console.ReadLine();
    switch (userMenuChoice)
    {
        case "1":
            // Todo erstellen
            
            break;
        case "2":
            // Todo abhaken
            break;
        default:
            //Nicht definierter Input eg. "hamster"
            break;
    }
}
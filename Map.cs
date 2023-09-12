namespace Game;

public static class Map
{
    private static readonly Dictionary<string, string[]> LocationInfo = new Dictionary<string, string[]>
    {
        {"Home", new []
        {
            "This is Your Home, you can rest up here and prepare for your journey.",
            "From here you can travel:",
            "1. North to the Townsquare."
        }},
        {"Town square", new []
        {
            "You are in the town square, there is a fountain here.",
            "From here you can travel:",
            "1. North to the Alchemy hut.",
            "2. East to the Guard Post.",
            "3. South to your Home.",
            "4. West to the Farmer's house"
        }},
        {"Farmhouse", new []
        {
            "You are at the farmer's house, it seems the farmer needs help with a problem...",
            "From here you can travel:",
            "1. East to the Townsquare.",
            "2. West to the Farmer's Field."
        }},
        {"Farmer's field", new []
        {
            "You are in the Farmer's field. It seems there is a snake infestation",
            "From here you can travel:",
            "1. East to the Farmer's house."
        }},
        {"Alchemist's hut", new []
        {
            "You are in the Alchemist's hut, it seems the alchemist has a problem, maybe you can help?",
            "From here you can travel:",
            "1. North to the Alchemist's garden.",
            "2. South to the Town Square."
        }},
        {"Alchemist's garden", new []
        {
            "You are in the Alchemist's garden, It seems there is a rat plague here",
            "From here you can travel:",
            "1. South to the Alchemist's hut."
        }},
        {"Guard post", new []
        {
            "You are at the Guard post which is guarded by a guard, it seems he will only let you pass under a certain condition",
            "From here you can travel:",
            "1. East to the bridge.",
            "2. West to the Town square."
        }},
        {"Bridge", new []
        {
            "You are at the bridge going over the river.",
            "From here you can travel:",
            "1. East to the forest.",
            "2. West to the Guard post."
        }},
        {"Forest", new []
        {
            "You are in the forest, It seems there is a spider infection here",
            "From here you can travel:",
            "1. West to the bridge."
        }}
    };

    public static void ShowMap()
    {
        Console.WriteLine("      AF");
        Console.WriteLine("      AH");
        Console.WriteLine("FF FH TS GP B W");
        Console.WriteLine("      H");
        Console.WriteLine($"You are currently at {Program.Player.CurrentLocation.Name}");
    }

    public static void ShowLocationInfo()
    {
        string currentLocationName = Program.Player.CurrentLocation.Name;

        if (LocationInfo.TryGetValue(currentLocationName, out var info))
        {
            Console.WriteLine($"You are currently at {currentLocationName}");
            foreach (string line in info)
            {
                Console.WriteLine(line);
            }
        }
    }
}

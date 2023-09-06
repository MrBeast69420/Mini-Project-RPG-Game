ShowMap()
public static class Map
{
    public static void ShowMap()
    {
        //Locaties: Home, TownSquare, Farmhouse, FarmField, Alchemy hut, Achemy garden, Guardpost, Bridge, Forest
        //       AG      
        //       AH
        // FF FH TS GP B F
        //       H
        Console.WriteLine("      AF")
        Console.WriteLine("      AH")
        Console.WriteLine("FF FH TS GP B W")
        Console.WriteLine("      H")
        Console.WriteLine($"You are currently at {Program.Player.CurrentLocation.Name}")
    }
    public static void ShowLocationInfo()
    {
        Console.WriteLine($"You are currently at {Program.Player.CurrentLocation.Name}")
        if(Program.Player.CurrentLocation.Name == "Home")
        {
            Console.WriteLine("This is Your Home, you can rest up here and prepare for your journey.")
            Console.WriteLine("From here you can travel: ")
            Console.WriteLine("1. North to the Townsquare.")
        }

        if(Program.Player.CurrentLocation.Name == "Town square")
        {
            Console.WriteLine("You are in the town square, there is a fountain here.")
            Console.WriteLine("From here you can travel: ")
            Console.WriteLine("1. North to the Alchemy hut.")
            Console.WriteLine("2. East to the Guard Post.")
            Console.WriteLine("3. South to your Home.")
            Console.WriteLine("4. West to the Farmers house")
        }

        if(Program.Player.CurrentLocation.Name == "Farmhouse")
        {
            Console.WriteLine("You are at the farmers house, it seems the farmer needs help with a problem...")
            Console.WriteLine("From here you can travel: ")
            Console.WriteLine("1. East to the Townsquare.")
            Console.WriteLine("2. West to the Farmers Field.")
        }

        if(Program.Player.CurrentLocation.Name == "Farmer's field")
        {
            Console.WriteLine("you are in the Farmer's field. PLACEHOLDER")
            Console.WriteLine("From here you can travel: ")
            Console.WriteLine("1. East to the Farmers house.")

        }

        if(Program.Player.CurrentLocation.Name == "Alchemist's hut")
        {
            Console.WriteLine("You are in the Alchemist's hut, it seems the alchemist has a problem, maybe you can help?")
            Console.WriteLine("From here you can travel: ")
            Console.WriteLine("1. North to the Alchemist's garden.")
            Console.WriteLine("2. South to the Town Square.")
        }

        if(Program.Player.CurrentLocation.Name == "Alchemist's garden")
        {
            Console.WriteLine("You are in the Alchemist's garden, PLACEHOLDER")
            Console.WriteLine("From here you can travel: ")
            Console.WriteLine("1. South to the Alchemist's hut.")
        }

        if(Program.Player.CurrentLocation.Name == "Guard post")
        {
            Console.WriteLine("You are at the Guard post wich is guarded by a guard, PLACEHOLDER")
            Console.WriteLine("From here you can travel: ")
            Console.WriteLine("1. East to the bridge.")
            Console.WriteLine("2. West to the Town square.")
        }

        if(Program.Player.CurrentLocation.Name == "Bridge")
        {
            Console.WriteLine("You are at the bridge going over the ")
            Console.WriteLine("From here you can travel: ")
            Console.WriteLine("1. East to the forest.")
            Console.WriteLine("2. West to the Guard post.")
        }

        if(Program.Player.CurrentLocation.Name == "Forest")
        {
            Console.WriteLine("You are in the forest, PLACEHOLDER")
            Console.WriteLine("From here you can travel: ")
            Console.WriteLine("1. West to the bridge")
        } 
    }
  
}

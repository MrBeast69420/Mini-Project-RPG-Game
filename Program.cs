namespace Game;

static class Program
{
    public static Player Player;

    public static void Main(string[] args)
    {
        Console.WriteLine("What is your name?");
        string name = Console.ReadLine() ?? "Player";

        Player = new Player(name, 10, 10, World.LocationByID(World.LOCATION_ID_HOME));
        Player.CurrentWeapon = World.WeaponByID(World.WEAPON_ID_RUSTY_SWORD);

        GameLoop();
    }

    public static void GameLoop()
    {
        if (Player.CurrentHitPoints <= 0)
        {
            return;
        }
        
        Console.WriteLine("\nWhat do you want to do?");
        Console.WriteLine("1: View quest log");
        Console.WriteLine("2: View inventory");
        Console.WriteLine("3: Move");
        Console.WriteLine("4: Quit");

        int input;
        try
        {
            input = int.Parse(Console.ReadLine() ?? "0");
        }
        catch
        {
            GameLoop();
            return;
        }

        switch (input)
        {
            case 1:
                Player.QuestLogViewer();
                break;
            
            case 2:
                Player.Inventory.DisplayItems();
                break;
            
            case 3:
                Movement.DoMovement();
                CheckForQuestsOrMonsters();
                break;
                
            case 4:
                return;
            
            default:
                GameLoop();
                return;
        }

        GameLoop();
    }

    static void CheckForQuestsOrMonsters()
    {
        Location location = Player.CurrentLocation;

        if (location.QuestAvailableHere != null)
        {
            location.QuestAvailableHere.ShowDialog();

            PlayerQuest? playerQuest = Player.QuestLog.Find(q => q.Quest == location.QuestAvailableHere);

            if (playerQuest == null)
            {
                playerQuest = new PlayerQuest(location.QuestAvailableHere);
                Player.QuestLog.Add(playerQuest);
            }

            bool completedQuest = false;

            foreach (CountedItem item in location.QuestAvailableHere.QuestCompletionItems.Items)
            {
                if (Player.Inventory.HasItem(item))
                {
                    completedQuest = true;
                }
            }

            if (completedQuest && !playerQuest.IsCompleted)
            {
                Console.WriteLine($"\nYou have completed the quest: {playerQuest.Quest.Name}!");
                Console.WriteLine("Your reward has been added to your inventory");
                
                playerQuest.IsCompleted = true;
                
                if (location.QuestAvailableHere.RewardItem != null)
                {
                    Player.Inventory.Items.AddItem(location.QuestAvailableHere.RewardItem);
                }

                if (location.QuestAvailableHere.RewardWeapon != null)
                {
                    Player.CurrentWeapon = location.QuestAvailableHere.RewardWeapon;
                }
            }
        }
        else if (location.MonsterLivingHere != null)
        {
            Fighting.InCombat(location.MonsterLivingHere);
        }
    }
}

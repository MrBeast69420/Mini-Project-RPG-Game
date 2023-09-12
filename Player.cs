namespace Game;

class Player
{
    public string Name;
    public int CurrentHitPoints;
    public int Gold = 0;
    public int ExperiencePoints = 0;
    public int Level = 0;
    public Weapon CurrentWeapon = null;
    public Location CurrentLocation;
    // public Inventory Inventory = new Inventory();
    // public List<PlayerQuest> QuestLog = new List<PlayerQuest>();
    

    public Player(string name, int currentHitPoints, int maximumHitPoints, Location currentLocation)
    {
        this.Name = name;
        this.CurrentHitPoints = currentHitPoints;
        this.CurrentLocation = currentLocation;
    }

    public void QuestLogViewer()
    {
        foreach (PlayerQuest quest in QuestLog)
        {
            List<string> items = quest.Quest.QuestCompletionItems.Items
                .Select(i => $"{i.Quantity}x {(i.Quantity == 1 ? i.Item.Name : i.Item.PluralName)}")
                .ToList();
            
            Console.WriteLine($"Quest: {quest.Quest.Name}");
            Console.WriteLine($"Description: {quest.Quest.Description}");
            Console.WriteLine($"Required items: {string.Join(", ", items)}");
            Console.WriteLine($"Quest completed: {(quest.IsCompleted ? "Yes" : "No")}");
            Console.WriteLine();
        }
    }
     public void GetItem(Item item)
    {
        if (Inventory.Contains(item))
        {
            item.Amount++;
        }
        else
        {
            Inventory.Add(item);
        }
    }

    public void RemoveItem(Item item)
    {
        if (Inventory.Contains(item) && item.Amount > 1)
        {
            item.Amount--;
        }
        else if (Inventory.Contains(item))
        {
            Inventory.Remove(item);
        }
    }


    public void LevelUp()
    {
        if (Experience % 100 == 0)
        {
            PlayerLevel++;
            AttackMultiplier += 0.15;
            MaxHealth += 2;
            Console.WriteLine("-------------------------------------------------------------------");
            Console.WriteLine($"You Leveled up!\nCurrent level: {PlayerLevel}\n");
        }
    }
    
}

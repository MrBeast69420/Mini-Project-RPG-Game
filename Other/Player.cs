using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

public class Player{
    public String name;
    private int baseDamage;
    public int baseHealthPoints;
    public int Gold;
    public int ExperiencePoints;
    public int Level;
    public Location location = null;
    public Weapon starterWeapon = new Weapon("bat", 5, 10);
    public Weapon? equipedWeapon = null;
    public List<Item> inventory = new List<Item>();
    public Inventory Inventory = new Inventory();
    public List<PlayerQuest> QuestLog = new List<PlayerQuest>();

    public Player(String name){
        this.name = name;
        baseDamage = 5;
        baseHealthPoints = 100;
        inventory.Add(starterWeapon);
        Gold = 0;
        ExperiencePoints = 0;
        Level = 1;
    }

    // public void QuestLogViewer()
    // {
    //     foreach (PlayerQuest quest in QuestLog)
    //     {
    //         List<string> items = quest.Quest.QuestCompletionItems.Items
    //             .Select(i => $"{i.Quantity}x {(i.Quantity == 1 ? i.Item.Name : i.Item.PluralName)}")
    //             .ToList();
            
    //         Console.WriteLine($"Quest: {quest.Quest.Name}");
    //         Console.WriteLine($"Description: {quest.Quest.Description}");
    //         Console.WriteLine($"Required items: {string.Join(", ", items)}");
    //         Console.WriteLine($"Quest completed: {(quest.IsCompleted ? "Yes" : "No")}");
    //         Console.WriteLine();
    //     }
    // }

    public void ViewInventory(){
        Console.WriteLine("Inventory:");
        for (int i = 0; i < inventory.Count(); i++){
            Console.WriteLine(i+1+". "+inventory[i]);
        } 
        Console.WriteLine();
    }
    public void AddToInventory(Item item) => inventory.Add(item);
    public void RemoveFromInventory(Item item) => inventory.Remove(item);


    public void ViewStats(){
        Console.WriteLine("Name: "+name);
        Console.WriteLine("HealthPoints: "+baseHealthPoints);
        Console.WriteLine("Damage: "+getDamage());
        Console.Write("Equiped weapon: ");
        if(equipedWeapon != null){
            Console.Write(equipedWeapon.Name);
        }
        Console.WriteLine();
        Console.WriteLine("Location: "+location);
        Console.WriteLine();
    }
    public void EquipWeapon(Weapon weapon){
        equipedWeapon = weapon;
        RemoveFromInventory(weapon);
    }
    public void UnequipWeapon(Weapon weapon){
        equipedWeapon = null;
        AddToInventory(weapon);
    }
    public int getDamage(){
        if(equipedWeapon != null){
            return baseDamage + equipedWeapon.Damage;
        } else {
            return baseDamage;
        }
    }
}

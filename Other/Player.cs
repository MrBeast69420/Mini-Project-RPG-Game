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
    public Weapon starterWeapon = new Weapon("Bat", 5, 10);
    public Weapon? equipedWeapon = null;
    public Inventory inventory = new Inventory();
    // public List<PlayerQuest> QuestLog = new List<PlayerQuest>();

    public Player(String name){
        this.name = name;
        baseDamage = 5;
        baseHealthPoints = 100;
        inventory.items.Add(starterWeapon);
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
        if(inventory.IsInInventory(weapon)){
            if(equipedWeapon != null){
                UnequipWeapon();
            }
            equipedWeapon = weapon;
            inventory.RemoveFromInventory(weapon);  
            Console.WriteLine("Weapon "+weapon.Name+" is equiped.\n"); 
        }
    }
    public void UnequipWeapon(){
        inventory.AddToInventory(equipedWeapon);
        Console.WriteLine("Weapon "+equipedWeapon.Name+" is unequiped.\n");
        equipedWeapon = null;
    }
    public int getDamage(){
        if(equipedWeapon != null){
            return baseDamage + equipedWeapon.Damage;
        } else {
            return baseDamage;
        }
    }
    public void UseHealingPotion(HealingPotions healingPotion){
        if(inventory.IsInInventory(healingPotion)){
            baseHealthPoints += healingPotion.healing;
            inventory.RemoveFromInventory(healingPotion);
            Console.WriteLine("Health increased by: "+healingPotion.healing+"\n");
        } else {
            Console.WriteLine("You dont have this kind of potion.\n");
        }
    }
}

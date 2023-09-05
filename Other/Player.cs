using System.Security.Cryptography.X509Certificates;

public class Player{
    public String name;
    public int baseDamage;
    public int baseHealthPoints;
    public String location = null;
    public Weapon starterWeapon = new Weapon("bat", 5);
    public Weapon? equipedWeapon = null;
    public List<Item> inventory = new List<Item>();

    public Player(String name){
        this.name = name;
        baseDamage = 5;
        baseHealthPoints = 100;
        inventory.Add(starterWeapon);
    }

    public void ViewInventory(){
        Console.WriteLine("Inventory:");
        for (int i = 0; i < inventory.Count(); i++){
            Console.WriteLine(i+1+". "+inventory[i]);
        } 
        Console.WriteLine();
    }

    public void AddToInventory(Item item){
        inventory.Add(item);
    }


}

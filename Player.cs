public class Player{
    String name;
    int baseDamage;
    Weapon starterWeapon = new Weapon("bat", 5);
    Weapon? equipedWeapon = null;
    List<Item> inventory = new List<Item>();

    public Player(String name){
        this.name = name;
        baseDamage = 5;
        inventory.Add(starterWeapon);
    }

    public void ViewInventory(){
        Console.WriteLine("Inventory:");
        for (int i = 0; i < inventory.Count(); i++){
            Console.WriteLine(i+1+". "+inventory[i]);
        } 
    }

    public void AddToInventory(Item item){
        inventory.Add(item);
    }


}

public static class Program{
    public static void Main(){
        // usable methods:
        // <player>.inventory.ViewInventory()
        // <player>.inventory.AddToInventory(Item item)
        // <player>.inventory.RemoveFromInventory(Item item)
        // <player>.UseHealingPotion(HealingPotions healingPotion)
        // <player>.ViewStats()
        // <player>.EquipWeapon(Weapon weapon)
        // <player>.UnequipWeapon(Weapon weapon)



        Player p1 = new Player("Hero");
        // p1.ViewInventory();
        p1.inventory.AddToInventory(Weapon.test1);
        // p1.AddToInventory(test2);
        // p1.ViewInventory();
        p1.inventory.AddToInventory(HealingPotions.hePoMedium);
        // p1.inventory.AddToInventory(HealingPotions.hePoMedium);
        p1.inventory.ViewInventory();
        // p1.inventory.RemoveFromInventory(HealingPotions.hePoMedium);
        p1.UseHealingPotion(HealingPotions.hePoMedium);
        p1.inventory.ViewInventory();
        p1.ViewStats();
        p1.EquipWeapon(p1.starterWeapon);
        p1.inventory.ViewInventory();
        p1.ViewStats();
        p1.UnequipWeapon(p1.starterWeapon);
        p1.inventory.ViewInventory();
        p1.ViewStats();
        p1.EquipWeapon(Weapon.test1);
        p1.inventory.ViewInventory();
        p1.ViewStats();
        p1.EquipWeapon(Weapon.test2);
        p1.inventory.ViewInventory();
        p1.ViewStats();
        // p1.inventory.ViewInventory();
        // p1.ViewStats();
        // p1.UnequipWeapon(p1.starterWeapon);
        // p1.inventory.ViewInventory();
        // p1.ViewStats();
        Boolean playing = true;
        // while(playing){
        //     Console.WriteLine("Options: ");
        //     // for loop met alle opties
        //     String userInput = Console.ReadLine();
        //     if(userInput.ToUpper() == "STOP"){
        //         playing = false;
        //     }
        // }
    }
}
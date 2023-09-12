using System.ComponentModel.Design;

public static class Program{
    public static void Main(){
        // rollback try 3
        // usable methods:
        // <player>.inventory.ViewInventory()
        // <player>.inventory.AddToInventory(Item item)
        // <player>.inventory.RemoveFromInventory(Item item)
        // <player>.UseHealingPotion(HealingPotions healingPotion)
        // <player>.ViewStats()
        // <player>.EquipWeapon(Weapon weapon)
        // <player>.UnequipWeapon(Weapon weapon)



        Player p1 = new Player("Hero");
        List<String> options = new List<string>(){
            "View inventory",
            "Use healing",
            "View stats",
            "Equip weapon",
            "Unequip weapon",
            "Stop",
            "Options"
        };
        // // p1.ViewInventory();
        p1.inventory.AddToInventory(Weapon.test1);
        p1.inventory.AddToInventory(Weapon.test2);
        // // p1.ViewInventory();
        p1.inventory.AddToInventory(HealingPotions.hePoMedium);
        p1.inventory.AddToInventory(HealingPotions.hePoMedium);
        // p1.inventory.ViewInventory();
        // // p1.inventory.RemoveFromInventory(HealingPotions.hePoMedium);
        // p1.UseHealingPotion(HealingPotions.hePoMedium);
        // p1.inventory.ViewInventory();
        // p1.ViewStats();
        // p1.EquipWeapon(p1.starterWeapon);
        // p1.inventory.ViewInventory();
        // p1.ViewStats();
        // p1.UnequipWeapon();
        // p1.inventory.ViewInventory();
        // p1.ViewStats();
        // p1.EquipWeapon(Weapon.test1);
        // p1.inventory.ViewInventory();
        // p1.ViewStats();
        // p1.EquipWeapon(Weapon.test2);
        // p1.inventory.ViewInventory();
        // p1.ViewStats();
        Boolean playing = true;
        Console.WriteLine("Options: ");
            for(int i = 0; i < options.Count(); i++){
                Console.WriteLine("-"+options[i]);
            }
            Console.WriteLine();
        while(playing){
            String userInput = Console.ReadLine().ToUpper();
            if(userInput == options[0].ToUpper()){
                p1.inventory.ViewInventory();
            }else if(userInput == options[1].ToUpper()){
                Boolean rightOption = true;
                do{
                    Console.WriteLine("Which healing potion would you like to use?");
                    Console.WriteLine("Small, medium or large?");
                    Console.WriteLine("Type \"back\" to go back.");
                    String playerInput1 = Console.ReadLine().ToUpper();
                    if(playerInput1 == "SMALL"){
                        p1.UseHealingPotion(HealingPotions.hePoSmall);
                    } else if(playerInput1 == "MEDIUM"){
                        p1.UseHealingPotion(HealingPotions.hePoMedium);
                    } else if(playerInput1 == "LARGE"){
                        p1.UseHealingPotion(HealingPotions.hePoLarge);
                    } else if(playerInput1 == "BACK"){
                        Console.WriteLine("Going back.\n");
                    } else {
                        Console.WriteLine("That is not one of the options, try again.");
                        rightOption = false;
                    }
                } while(!rightOption);
            }else if(userInput == options[2].ToUpper()){
                p1.ViewStats();
            }else if(userInput == options[3].ToUpper()){
                Boolean rightWeapon = false;
                do{
                    Console.WriteLine("Which weapon would you like to equip?");
                    String playerInput2 = Console.ReadLine();
                    for(int i = 0; i < p1.inventory.items.Count(); i++){
                        if(playerInput2.ToUpper() == p1.inventory.items[i].Name.ToUpper()){
                            p1.EquipWeapon((Weapon)p1.inventory.items[i]);
                            rightWeapon = true;
                        }
                    }
                    if(playerInput2.ToUpper() == "BACK"){
                        Console.WriteLine("Going back.\n");
                        rightWeapon = true;
                    }
                } while(!rightWeapon);
            }else if(userInput == options[4].ToUpper()){
                p1.UnequipWeapon();
            }
            if(userInput.ToUpper() == "STOP"){
                playing = false;
            } else if(userInput.ToUpper() == "OPTIONS"){
                Console.WriteLine("Options: ");
                for(int i = 0; i < options.Count(); i++){
                    Console.WriteLine("-"+options[i]);
                }
                Console.WriteLine();
            }
        }
    }
}
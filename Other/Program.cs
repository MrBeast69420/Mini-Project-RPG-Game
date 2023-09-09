public static class Program{
    public static void Main(){
        Weapon test1 = new Weapon("Bow", 10, 25);
        Weapon test2 = new Weapon("Sword", 7, 20);

        Player p1 = new Player("Hero");
        // p1.ViewInventory();
        p1.AddToInventory(test1);
        // p1.AddToInventory(test2);
        // p1.ViewInventory();
        p1.AddToInventory(new HePoMedium());
        // p1.AddToInventory(new HePoSmall());
        // p1.AddToInventory(new HePoLarge());
        p1.ViewInventory();
        p1.ViewStats();
        p1.EquipWeapon(p1.starterWeapon);
        p1.ViewInventory();
        p1.ViewStats();
        p1.UnequipWeapon(p1.starterWeapon);
        p1.ViewInventory();
        p1.ViewStats();
        Boolean playing = true;
        while(playing){
            Console.WriteLine("Options: ");
            // for loop met alle opties
            String userInput = Console.ReadLine();
            if(userInput.ToUpper() == "STOP"){
                playing = false;
            }
        }
    }
}
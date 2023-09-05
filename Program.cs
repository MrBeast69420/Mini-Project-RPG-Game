public static class Program{
    public static void Main(){
        Weapon test1 = new Weapon("Boog", 10);
        Weapon test2 = new Weapon("Zwaard", 7);

        Player p1 = new Player("Hero");
        p1.ViewInventory();
        p1.AddToInventory(test1);
        p1.AddToInventory(test2);
        p1.ViewInventory();
    }
}
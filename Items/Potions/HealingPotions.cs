public abstract class HealingPotions : Item{
    public int healing;

    public static HePoLarge hePoLarge = new HePoLarge("Healing Potion Large");
    public static HePoMedium hePoMedium = new HePoMedium("Healing Potion Medium");
    public static HePoSmall hePoSmall = new HePoSmall("Healing Potion Small");

    public HealingPotions(String Name):base(Name){
    }
}
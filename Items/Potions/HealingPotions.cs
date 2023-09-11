public abstract class HealingPotions : Item{
    public String name;
    public int healing;

    public static HePoLarge hePoLarge = new HePoLarge();
    public static HePoMedium hePoMedium = new HePoMedium();
    public static HePoSmall hePoSmall = new HePoSmall();

    public HealingPotions(){
        this.name = "Healing Potion";
    }
}
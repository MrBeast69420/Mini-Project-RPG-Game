public class HePoLarge : HealingPotions{
    public HePoLarge(){
        this.name = base.name+" Large";
        healing = 40;
    }
    public override string ToString(){
      return name+ " | Healing: "+healing;
    }
}
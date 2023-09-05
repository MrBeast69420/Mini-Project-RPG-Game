public class HePoSmall : HealingPotions{
    public HePoSmall(){
        this.name = base.name+" Small";
        healing = 20;
    }
    public override string ToString(){
      return name+ " | Healing: "+healing;
    }
}
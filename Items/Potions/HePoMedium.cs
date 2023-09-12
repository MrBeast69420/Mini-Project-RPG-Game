public class HePoMedium : HealingPotions{
    public HePoMedium(){
        this.name = base.name+" Medium";
        healing = 30;
    }
    public override string ToString(){
      return name+ " | Healing: "+healing;
    }
}
public class HePoLarge : HealingPotions{
    public HePoLarge(String Name): base(Name){
        healing = 40;
    }
    public override string ToString(){
      return Name+ " | Healing: "+healing;
    }
}
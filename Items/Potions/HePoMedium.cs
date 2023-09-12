public class HePoMedium : HealingPotions{
    public HePoMedium(String Name): base(Name){
        healing = 30;
    }
    public override string ToString(){
      return Name+ " | Healing: "+healing;
    }
}
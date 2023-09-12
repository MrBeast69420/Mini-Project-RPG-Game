public class HePoSmall : HealingPotions{
    public HePoSmall(String Name):base(Name){
        healing = 20;
    }
    public override string ToString(){
      return Name+ " | Healing: "+healing;
    }
}
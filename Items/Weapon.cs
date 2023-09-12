public class Weapon : Item{
  Random rnd = new Random();
  public static int AmountOfWeapons = 1;
  public int ID;
  public int Damage;
  public int CritChance;

  public static Weapon test1 = new Weapon("Bow", 10, 25);
  public static Weapon test2 = new Weapon("Sword", 7, 20);

  public Weapon(string Name, int damage, int critchance): base(Name) {
    ID = AmountOfWeapons;
    this.Damage = damage;
    this.CritChance = critchance;
    AmountOfWeapons++;
  }
  public bool CritHit() => rnd.Next(101) > (100 - CritChance);
  public int Attack(){
    int attackDamage = Damage;
    if(CritHit()){
      attackDamage*= 2;
      return attackDamage;
    }
    else {
      return attackDamage;
    } 
  }
  public override string ToString(){
    return base.ToString()+": ID: "+ID+" | "+Name+" | Damage: "+Damage+" | Crit chance: "+CritChance;
  }
}

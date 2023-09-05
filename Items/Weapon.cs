public class Weapon : Item{
    public String name;
    public int damage;
    public int ID;
    public Weapon(String name, int damage){
        this.name = name;
        this.damage = damage;
        ID++;
    }
    public override string ToString(){
      return base.ToString()+": ID: "+ID+" | "+name+" | Damage: "+damage;
    }
}

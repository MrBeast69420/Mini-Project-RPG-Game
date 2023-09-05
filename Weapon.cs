public class Weapon : Item{
    String name;
    int damage;
    public Weapon(String name, int damage){
        this.name = name;
        this.damage = damage;
    }

    public String getName(){
        return name;
    }
    public void setName(String name){
        this.name = name;
    }
    public override string ToString()
   {
      return base.ToString()+": "+name+" | Damage: "+damage;
   }
}

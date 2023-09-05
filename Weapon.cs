public static class Weapon
{
    Random rnd = new Random();
    public string ID;
    public string Name;
    public int Damage;
    public int CritChance;

    public Weapon(int id, string name, int damage, int critchance)
    {
        ID = id;
        Name = name;
        Damage = damage;
        CritChance = critchance;

    }

    public bool CritHit() => rnd.Next(101) > (100 - CritChance);
    

    public int Attack();
    {
        int attackDamage = Damage;
        if(CritHit())
        {
            attackDamage*= 2;
            return attackDamage;
        }
        else 
        {
            return attackDamage;
        }
        
    }
}


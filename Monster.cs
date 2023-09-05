public static class Monster
{
    public string ID;
    public string Name;
    public int Damage;
    public int Health;
    public int CritChance;

    public Monster(string ID, string name, int damage, int health, int CritChance)
    {
        ID = id;
        Name = name;
        Damage = damage;
        Health = health;
        CritChance = critchance;
    } 

    public bool CritHit() => rnd.Next(101) > (100 - CritChance);

    public int Attack()
    {
        int attackDamage = Damage;
        if(CritHit())
        {
            attackDamage *=2
            return attackDamage
        }
        else
        {
            return attackDamage;
        }
    }

    public string DropItem()
    {
        
    }
    // stats uit world.cs
    // Monster rat = new Monster(MONSTER_ID_RAT, "rat", 1, 3, 3);
}

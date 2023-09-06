namespace Game;

class Monster
{
    public int ID;
    public string Name;
    public int MaximumHitPoints;
    public string NamePlural;
    public int MaximumDamage;
    public int RewardExperience;
    public int RewardGold;
    public CountedItemList Loot = new CountedItemList();
    public int CurrentHitPoints;
  
  

    public Monster(int id, string name, string namePlural, int maximumDamage, int rewardExperience, int rewardGold, int currentHitPoints, int maximumHitPoints)
    {
        this.ID = id;
        this.Name = name;
        this.NamePlural = namePlural;
        this.MaximumDamage = maximumDamage;
        this.RewardExperience = rewardExperience;
        this.RewardGold = rewardGold;
        this.CurrentHitPoints = currentHitPoints;
        this.MaximumHitPoints = currentHitPoints;
    }
}

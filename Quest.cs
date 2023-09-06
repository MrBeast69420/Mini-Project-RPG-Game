namespace Game;
namespace Game;

class Quest
{
    public int ID;

    public string Name;
    public string Description;

    public int RewardExperiencePoints;
    public int RewardGold;

    public Item RewardItem;
    public Weapon RewardWeapon;

    public CountedItemList QuestCompletionItems = new CountedItemList();

    public Quest(int id, string name, string description, int rewardExperiencePoints, int rewardGold, Item rewardItem,
        Weapon rewardWeapon)
    {
        this.ID = id;
        this.Name = name;
        this.Description = description;
        this.RewardExperiencePoints = rewardExperiencePoints;
        this.RewardGold = rewardGold;
        this.RewardItem = rewardItem;
        this.RewardWeapon = rewardWeapon;
    }
    
    public void ShowDialog()
    {
        Console.WriteLine($"There is a quest available: {Name}\n{Description}");
    }
}

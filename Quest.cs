using System;

namespace Game
{
    public class Quest
    {
        public int ID;

        public string Name;
        public string Description;

        public int RewardExperiencePoints;
        public int RewardGold;
        public Weapon RewardWeapon;

    }

        public Quest(int id, string name, string description, int rewardExperiencePoints, int rewardGold,
            Weapon rewardWeapon)
        {
            this.ID = id;
            this.Name = name;
            this.Description = description;
            this.RewardWeapon = rewardWeapon;
        }
        
        public void ShowDialog()
        {
            Console.WriteLine($"There is a quest available: {Name}\n{Description}");
        }
        public void CompleteQuest()
        {
            if (Player.CurrentLocation.QuestAvailableHere == Player.CurrentQuest && Player.CurrentQuest != null)
            {
                Quest quest = Player.CurrentQuest;
                bool checking = true;
                while (checking)
                {
                    {
                        bool completed = false;
                        foreach (Item item in Player.Inventory)
                        {
                            if (item == quest.ItemToCollect && item.Amount >= quest.AmountToCollect)
                            {
                                Console.WriteLine("-------------------------------------------------------------------");
                                Console.WriteLine($"Congrats! You have collected enough {quest.ItemToCollect.ItemName()}.");                      
                                Console.WriteLine("Take this as a token of gratitude.");
                                if (quest.Item == null)
                                {
                                    Console.WriteLine("-------------------------------------------------------------------");
                                    Console.WriteLine($"You have received: {quest.Weapon.Name}");
                                    Player.EquippedWeapon = quest.Weapon;
                                    completed = true;
                                    Player.CurrentQuest = null;
                                    World.Quests.Remove(quest);
                                    Player.CurrentLocation.QuestAvailableHere = null;
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("-------------------------------------------------------------------");
                                    Console.WriteLine($"*you have received: {quest.Item.SingleName}.");
                                    Player.GetItem(quest.Item);
                                    completed = true;
                                    Player.CurrentQuest = null;
                                    World.Quests.Remove(quest);
                                    Player.CurrentLocation.QuestAvailableHere = null;
                                    break;
                                }
                            }
                        }

                        if (completed)
                        {
                            while (Player.Inventory.Contains(quest.ItemToCollect))
                            {
                                Player.RemoveItem(quest.ItemToCollect);
                            }
                        }

                        else
                        {
                            Console.WriteLine("-------------------------------------------------------------------");
                            Console.WriteLine($"This is not enough. Return when you have {quest.AmountToCollect} {quest.ItemToCollect.ItemName()}");
                        }
                        checking = false;
                    }
                }
            }
    }
}

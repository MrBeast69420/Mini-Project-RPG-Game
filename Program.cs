public class Program
{

    public void MainMenu()
    {
        while (true)
        {
            Console.WriteLine("-------------------------------------------------------------------");
            Console.WriteLine("What would you like to do (enter a number)?\n1: See game stats\n2: Move\n3: Fight\n4: Map\n5: Quit");
            string choice;

            choice = Console.ReadLine();
            Console.Clear();

            switch (choice)
            {
                case "1":
                    Console.WriteLine(Player.Info());
                    break;
                case "2":
                    Player.Move();
                    break;
                case "3":
                    Battle currentBattle = new(Player);
                    currentBattle.InBattle();
                    break;
                case "4":
                    Console.WriteLine(Player.CurrentLocation.Map());
                    break;
                case "5":
                    Playing = false;
                    break;
                default:
                    Console.WriteLine("Invalid Choice\n");
                    continue;
            }
            break;
        }
    }
    public static void Main()
    {

    }
}
using System.Net;

public class Inventory{
    public List<Item> items = new List<Item>();

    public void ViewInventory(){
        Console.WriteLine("Inventory:");
        for (int i = 0; i < items.Count(); i++){
            Console.WriteLine(i+1+". "+items[i]);
        } 
        Console.WriteLine();
    }
    public void AddToInventory(Item item) => items.Add(item);
    public void RemoveFromInventory(Item item) => items.Remove(item);
    public Boolean IsInInventory(Item item){
        for(int i = 0; i < items.Count(); i++){
            if(item == items[i]){
                return true;
            }
        }
        return false;
    }
}
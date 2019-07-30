using System.Collections.Generic;

namespace ToDoList.Models
{
    public class Item
    {
    private string Description;
    private int Id;
    
    private static List<Item> items = new List<Item>{};

    private static List<Item> _instances = new List<Item> {};

        public Item(string description)
        {
            Description = description;
            
        }

        public static List<Item> GetAll()
        {
            return items;
        }

        // public static void ClearAll()
        // {
        // items.Clear();
        // }

        public string GetDescription()
        {
        return Description;
        }

        public void SetDescription(string newDescription)
        {
        Description = newDescription;
        }
    }
}
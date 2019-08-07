namespace ToDoList.Models
{
<<<<<<< HEAD
    public class Item
    {
        public int ItemId { get; set; }
        public string Description { get; set; }

        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
=======
  public class Item
  {
    public string Description { get; set; }
    public int Id { get; }
    private static List<Item> _instances = new List<Item> { };

    public Item(string description)
    {
      Description = description;
      _instances.Add(this);
      Id = _instances.Count;
    }

    public static List<Item> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static Item Find(int searchId)
    {
      return _instances[searchId - 1];
>>>>>>> bc97877db3d1f25e8851bff708f1363bcf281e62
    }

  }
}
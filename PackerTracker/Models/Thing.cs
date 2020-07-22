using System.Collections.Generic;

namespace PackerTracker.Models
{
  public class Thing
  {
    public string Name { get; set; }
    public int Price { get; set; }
    public bool Purchased { get; set; }
    public int Weight { get; set; }

    public int Id { get; }

    private static List<Thing> _instances = new List<Thing> { };

    public Thing(string name, int price, bool purchased, int weight)
    {
      Name = name;
      Price = price;
      Purchased = purchased;
      Weight = weight;
      _instances.Add(this);
      Id = _instances.Count;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static List<Thing> GetAll()
    {
      return _instances;
    }

    public static int TotalWeight()
    {
      int allWeight = 0;
      for (int i = 0; i < _instances.Count; i++)
      {
        allWeight += _instances[i].Weight;
      }
      return allWeight;
    }
    public static Thing Find(int searchId)
    {
      return _instances[searchId - 1];
    }
  }
}
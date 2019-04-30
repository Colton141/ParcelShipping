using System.Collections.Generic;

namespace ParcelShipping.Models
{
  public class Parcel
  {
    private string _description;
    private static List<Parcel> _instances = new List<Parcel> {};


    public string GetDescription()
    {
      return _description;
    }

    public void SetDescription(string newDescription)
    {
      _description = newDescription;
    }

    public static List<Parcel> GetAll()
    {
      return _instances;
    }

    public Parcel (string description)
    {
      _description = description;
      _instances.Add(this);
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }
  }
}

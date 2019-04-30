using System.Collections.Generic;

namespace ParcelShipping.Models
{
  public class Parcel
  {
    public string Height { get; set;}
    //Height is still the private string _height
    public string Width { get; set;}
    public string Length { get; set;}
    public string Weight { get; set;}

    private static List<Parcel> _instances = new List<Parcel> {};

    public static List<Parcel> GetAll()
    {
      return _instances;
    }

    public Parcel (string height, string width, string length, string weight)
    {
      Height = height;
      Width = width;
      Length = length;
      Weight = weight;
      _instances.Add(this);
      int newVolume = GetVolume();
      Console.WriteLine(newVolume);
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }
    public int GetVolume()
    {
     return height * width * length;
    }
  }
}

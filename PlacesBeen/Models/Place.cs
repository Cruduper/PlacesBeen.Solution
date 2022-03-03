using System.Collections.Generic;

namespace PlacesBeen.Models
{
  public class Place
  {
    public string CityName { get; set; }
    public int Id { get; }

    public string PicURL { get; set; }
    private static List<Place> _instances = new List<Place> {};

    public Place( string cityName, string picURL )
    {
      CityName = cityName;
      _instances.Add(this);
      Id = _instances.Count;
      PicURL = picURL;
    }
    public static List<Place> GetAll()
    {
        return _instances;
    }

    public static void ClearAll()
    {
        _instances.Clear();
    }

    public static Place Find(int searchId)
    {
        return _instances[searchId - 1];
    }
  }
}
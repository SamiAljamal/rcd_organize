using System.Collections.Generic;

namespace CdList.Objects
{
  public class Cd
  {
    private string _title;
    private string _artist;
    private int _id;
    private static List<Cd> _instances = new List<Cd> {};
    public Cd (string title, string artist)

    {
      _title = title;
      _artist = artist;
      _instances.Add(this);
      _id = _instances.Count;
    }
    public string GetTitle()
    {
      return _title;
    }
    public void SetTitle(string newTitle)
    {
      _title = newTitle;
    }
    public string GetArtist()
    {
      return _artist;
    }
    public void SetArtist(string newArtist)
    {
      _artist = newArtist;
    }
    public int GetId()
    {
      return _id;
    }
    public static List<Cd> GetAll()
    {
      return _instances;
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }
    public static Cd Find(int searchId)
    {
      return _instances[searchId-1];
    }

  }
}

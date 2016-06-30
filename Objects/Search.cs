using System.Collections.Generic;

namespace CdList.Objects
{
  public class Search
  {
      private string _search;
      public Search (string search)
      {
        _search = search;
      }
      public string GetTerm()
      {
        return _search;
      }
      public void SetTerm(string newSearch)
      {
        _search = newSearch;
      }

  }

}

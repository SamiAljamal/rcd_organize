using Nancy;
using CdList.Objects;
using System.Collections.Generic;

namespace CdList.Objects
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        List<Cd> allCds = Cd.GetAll();
        return View ["Cds.cshtml", allCds];
      };
      Get["/cds"] = _ => {
        List<Cd> allCds = Cd.GetAll();
        return View["Cds.cshtml", allCds];
      };
      Get["/cds/new"] = _ => {
        return View["Cd_form.cshtml"];
      };
      Get["/cds/{id}"] = parameters => {
        Cd cd = Cd.Find(parameters.id);
        return View["/Cd.cshtml", cd];
      };
      Get["/cds/searchbyartist"] = _ =>{
        return View["Cd_search.cshtml"];
      };
      Post["/searchbyartist"] = _ =>{
        List<Cd> allCds = Cd.GetAll();


        Dictionary<string, object> SearchCds = new Dictionary<string, object>();
        SearchCds.Add("allCdsList", allCds);

        Search searchTerm = new Search(Request.Form["cd-artist-search"]);
        SearchCds.Add("searchTerm", searchTerm);

        return View["Cds_by_artist.cshtml", SearchCds];
      };
      Post["/cds"] = _ => {
        Cd newCd = new Cd(Request.Form["cd-title"], Request.Form["cd-artist"]);
        List<Cd> allCds = Cd.GetAll();
        return View["Cds.cshtml", allCds];
      };
      Post["/clear"] = _ => {
        List<Cd> allCds = Cd.GetAll();
        Cd.ClearAll();
        return View["Cds.cshtml", allCds];
      };
    }
  }
}

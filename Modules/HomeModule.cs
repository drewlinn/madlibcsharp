using Nancy;
using Madlibs.Objects;

namespace Madlibs
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/form"] = _ => {
        return View["form.cshtml"];
      };
      Get["/story"] = _ => {
        MadlibVariables myMadlibVariables = new MadlibVariables();
        myMadlibVariables.SetPerson1(Request.Query["person1"]);
        myMadlibVariables.SetPerson2(Request.Query["person2"]);
        myMadlibVariables.SetAnimal(Request.Query["animal"]);
        myMadlibVariables.SetExclamation(Request.Query["exclamation"]);
        myMadlibVariables.SetVerb(Request.Query["verb"]);
        myMadlibVariables.SetNoun(Request.Query["noun"]);
        return View["story.cshtml", myMadlibVariables];
      };
    }
  }
}

using Nancy;
using nancytest.Objects;

namespace MadLibs
{

  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/form"] = parameters => View["form.html"];
      Get["/story"] = parameters => {
        var myStoryVariables = new StoryVariables {
          Person1 = Request.Query["person1"],
          Person2 = Request.Query["person2"],
          Animal = Request.Query["animal"],
          Exclamation = Request.Query["exclamation"],
          Verb = Request.Query["verb"],
          Noun = Request.Query["noun"]
        };
        return View["story.html", myStoryVariables];
      };
    }
  }
}

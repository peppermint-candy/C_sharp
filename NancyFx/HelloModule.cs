using Nancy;
using System.Collections.Generic;
namespace HelloNancy
{
    public class HelloModule : NancyModule
    {
        public HelloModule()
        {
            Get("/", args => 
            {
                // ViewBag.{variableName} = data;
                ViewBag.show = true;

                List<string> listOfStuffToDisplay = new List<string> {"things", "other things", "another things"};                
                return View["Hello", listOfStuffToDisplay];
                // return View["Hello/Hello.sshtml"];
            });

            Post("/template", args => 
            {
                return Response.AsRedirect("/");
            });

            Post("/formsubmitted", args =>
            {
                string Username = Request.Form.Username;
                return Response.AsRedirect("/");
            });

            Get("/{value:name}", args => "Hello " + args.name + "!");

            

        }
    }
}
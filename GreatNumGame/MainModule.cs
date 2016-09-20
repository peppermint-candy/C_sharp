using Nancy;
// using System.Collections.Generic;
using System;

namespace GreatNumberGame
{
    public class MainModule : NancyModule
    {
        public MainModule()
        {
            Get("/", args => 
            {
           
                if (Session["number"] == null)
                {
                    int rnd = new Random().Next(1,101);
                    Session["number"] = rnd;
                }
                ViewBag.show = true;
                Console.WriteLine(Session["number"]);
                return View["Main"];
                
             });

            Post("/guess", args => 
            {
                int guess = Request.Form.Guessing;
                Console.WriteLine(guess);

                if (guess > (int)Session["number"])
                {
                    ViewBag.display = "Too High!";
                }
                else if (guess < (int)Session["number"])
                {
                    ViewBag.display = "Too Low!";
                }
                else
                {
                    ViewBag.show = false;
                    ViewBag.display = Session["number"] + "was the number!";
                    Session.DeleteAll();
                    return View["Main"];
                }

                return Response.AsRedirect("/");
            });

            // Post("/formsubmitted", args =>
            // {
            //     string Username = Request.Form.Username;
            //     return Response.AsRedirect("/");
            // });

            // Get("/{value:name}", args => "Hello " + args.name + "!");

            

        }
    }
}
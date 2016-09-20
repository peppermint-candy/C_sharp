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
                ViewBag.display = "";
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
                    ViewBag.show = true;
                    ViewBag.display = "Too High!";
                    return View["Main"];
                }
                else if (guess < (int)Session["number"])
                {
                    ViewBag.show = true;
                    ViewBag.display = "Too Low!";
                    return View["Main"];
                }
                else
                {
                    ViewBag.show = false;
                    ViewBag.display = Session["number"] + "was the number!";
                    Session.DeleteAll();
                    return View["Main"];
                }

                // return Response.AsRedirect("/") ;
            });


            

        }
    }
}
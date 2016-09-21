using System;
// using System.Collections.Generic;
using Nancy;
namespace NinjaGold
{
    public class Ninjagoldmodule : NancyModule
    {
        public Ninjagoldmodule()
        {
            Get("/", args =>
            {

                if (Session["coin"] == null)
                {
                    Session["coin"] = 0;
                }


                ViewBag.coin = Session["coin"]; 
                ViewBag.log = Session["log"];
                Console.WriteLine(Session["log"]);

                return View["Ninjagold/Ninjagold.html"];
            });

            Post("/processing" , args => 
            {
                string location = Request.Form.Location;
                DateTime date = DateTime.Now;

                // Console.WriteLine(location + date);
                Random rnd = new Random();

                if (location == "Farm")
                {
                    int earned = (int)rnd.Next(10,21);
                    Console.WriteLine(earned);
                    Session["coin"] = (int)Session["coin"] + earned;
                    Session["log"] += (" Earned " + earned + " golds from the farm! " + date );
                }
                else if (location == "Cave")
                {
                    int earned = (int)rnd.Next(5,11);
                    Console.WriteLine(earned);                    
                    Session["coin"] = (int)Session["coin"] + earned;
                    Session["log"] += (" Earned " + earned + " golds from the cave! " + date );                    
                }
                else if (location == "House")
                {
                    int earned = (int)rnd.Next(2,6);
                    Console.WriteLine(earned);                    
                    Session["coin"] = (int)Session["coin"] + earned;
                    Session["log"] += (" Earned " + earned + " golds from the house!" + date );                    
                }
                else if (location == "Casino")
                {
                    int earned = (int)rnd.Next(-50,51);
                    Console.WriteLine(earned);                    
                    Session["coin"] = (int)Session["coin"] + earned;
                    if (earned >= 0)
                    {
                        Session["log"] += (" Entered a casino and earned " + earned + "... Yay! .." + date );                                        
                    }
                    else
                    {
                        Session["log"] += (" Entered a casino and lost " + earned + "...Ouch! .." + date );                                            
                    }

                }
                else
                {
                    Session["log"] += (" Oop! something went wrong");
                }
                return Response.AsRedirect("/");
            });

        }
    }
}
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System;

namespace ninjagold
{

    public class NinjaGoldController : Controller 
    {
        // public int coin {get; set;}

        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            if (HttpContext.Session.GetInt32("coin") == null)
            {
                TempData["coin"] = "Hello";
                HttpContext.Session.SetInt32("Coin", 0);
            }

            ViewBag.coin = HttpContext.Session.GetInt32("Coin");

            return View();
        }

        [HttpPost]
        [Route("processing")]
        public IActionResult Process(string location)
        {
 
            DateTime date = DateTime.Now;
            Random rnd = new Random();

            if (location == "Farm")
            {
                int earned = (int)rnd.Next(10,21);
                Console.WriteLine(earned);
                // TempData["coin"] = (int)TempData["coin"] + earned;                              
                Console.WriteLine(TempData["coin"]);
                
                // Session["coin"] = (int)Session["coin"] + earned;
                // Session["log"] += (" Earned " + earned + " golds from the farm! " + date );
            }
            else if (location == "Cave")
            {
                int earned = (int)rnd.Next(5,11);
                Console.WriteLine(earned);                    
                // Session["coin"] = (int)Session["coin"] + earned;
                // Session["log"] += (" Earned " + earned + " golds from the cave! " + date );                    
            }
            else if (location == "House")
            {
                int earned = (int)rnd.Next(2,6);
                Console.WriteLine(earned);                    
                // Session["coin"] = (int)Session["coin"] + earned;
                // Session["log"] += (" Earned " + earned + " golds from the house!" + date );                    
            }
            else if (location == "Casino")
            {
                int earned = (int)rnd.Next(-50,51);
                Console.WriteLine(earned);                    
                // Session["coin"] = (int)Session["coin"] + earned;
                if (earned >= 0)
                {
                    // Session["log"] += (" Entered a casino and earned " + earned + "... Yay! .." + date );                                        
                }

            }
            
            else
            {
                // Session["log"] += (" Entered a casino and lost " + earned + "...Ouch! .." + date );                                            
                Console.WriteLine("oh no! Something went wrong");
            }
            
            return RedirectToAction("Index");
        
        }


    }   
}
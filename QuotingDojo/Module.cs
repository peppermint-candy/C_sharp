using Nancy;
using System;
using System.Collections.Generic;
using DbConnection;
namespace quotingDojo
{
    public class quotingDojoModule : NancyModule
    {
        public quotingDojoModule()
        {
            Get("/", args => {
                return View["Quoting/main.html"];
            });

            Post("/quotes", args => {
                Console.WriteLine("passing through post /quotes");

                string user_name = Request.Form.name;
                string user_quote = Request.Form.quote;

                Console.WriteLine("{1} by {0}", user_name, user_quote);

                string Query = $"INSERT INTO quotes (id ,name, quote, created_at) VALUES ('1','Request.Form.name', 'Request.Form.quote', NOW())";
                DbConnector.ExecuteQuery(Query);
                
                return Response.AsRedirect("/quotes");

            });

            Get("/quotes", args => {
                string Query = "SELECT * FROM quotes";
                List<Dictionary<string, object>> quotes = DbConnector.ExecuteQuery(Query);
                ViewBag["quotes"] = quotes;

                return View["Quoting/quotes.html"];
            });


        }
    }
}
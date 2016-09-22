using System;
using Nancy;
using System.Collections.Generic;
using System.Collections;

namespace ApiCaller
{
    public class ApiCallerModule : NancyModule
    {
        public ApiCallerModule()
        {
            Get("/", async args =>
            {
                string Name = "";
                object Primary_type = "";
                long Height = 0;
                long Weight = 0;

                await WebRequest.SendRequest("http://pokeapi.co/api/v2/pokemon/1", new
                    Action<Dictionary<string, object>>( JsonResponse =>
                {
                Name = (string)JsonResponse["name"];
                Primary_type = (object)JsonResponse["types"];
                Height = (long)JsonResponse["height"];
                Weight = (long)JsonResponse["weight"];
                }
                ));

                IEnumerable mylist = Primary_type as IEnumerable;
                foreach (object item in mylist)
                {
                    foreach (object i in (IEnumerable)item)
                    {
                        Console.WriteLine(i);
                    }
                }

                

                


                Console.WriteLine(Name); // bulbasaur
                // Console.WriteLine(Primary_type);
                Console.WriteLine(Height);
                Console.WriteLine(Weight);
                return Name;
            });
        }
    }
}
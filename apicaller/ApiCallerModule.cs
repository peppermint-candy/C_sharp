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

                List<object> type = new List<object>(); 

                IEnumerable mylist = Primary_type as IEnumerable;
                foreach (object item in mylist)
                {
                    foreach (object i in (IEnumerable)item)
                    {
                        foreach(object j in (IEnumerable)i)
                        {
                            foreach (object k in (IEnumerable)j)
                            {
                                foreach (object l in (IEnumerable)k)
                                {
                                    type.Add(l);          
                                }
                            }
                        }
                    }
                }

                

                


                Console.WriteLine(Name); // bulbasaur
                Console.WriteLine();
                Console.WriteLine(Height);
                Console.WriteLine(Weight);

                Dictionary<string, object> summary = new Dictionary<string, object>();
                summary.Add("Name", Name);
                summary.Add("Type", type[1].ToString());
                summary.Add("Type2", type[3].ToString());
                summary.Add("Height", Height);
                summary.Add("Weight", Weight);


                // Console.WriteLine(string.Join(", ", summary));
                

                return Response.AsJson(summary);
            });
        }
    }
}
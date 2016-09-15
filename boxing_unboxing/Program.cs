using System;
using System.Collections.Generic;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<object> mixedList = new List<object>();


            mixedList.Add(7);
            mixedList.Add(28);
            mixedList.Add(-1);
            mixedList.Add(true);
            mixedList.Add("Coding");
            mixedList.Add(23.1);
            mixedList.Add("Dojo");
            mixedList.Add(1);


            foreach (var obj in mixedList)
            {
                Console.WriteLine(obj);

            }

            var sum = 0;
            int t = 0;
            for (var i = 0; i < mixedList.Count; i++)
            {
                if (mixedList[i].GetType() == t.GetType() )
                {
                    sum += (int)mixedList[i];
                }
            }
            
            Console.WriteLine(sum);



        }
    }
}

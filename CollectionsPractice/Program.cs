using System;
using System.Collections.Generic;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // THE THREE BASIC ARRAYS

            int[] zeroTonine = new int[10];
            string[] names = new string[4] {"Tim", "Martin", "Nikki", "Sara"};
            bool[] type = new bool[10] {true, false, true, false, true, false, true, false, true, false};


            // MULTIPLICATION TABLE

            int[] multiplication = new int[10] {1,2,3,4,5,6,7,8,9,10};
            int[,] store = new int[10,10];
            
            for (int i = 0; i < multiplication.Length ; i++)
            {
                foreach (int num in multiplication)
                {
                    store[i,num-1] = num*(i+1);
                    Console.WriteLine(store[i,num-1]);
                }
            }

            // USER INFO DICTIONARY

            Dictionary<string,string> user = new Dictionary<string,string>();

            // User one
            user.Add("Name1", "Oliver");
            user.Add("Fav_sport1", "running");
            user.Add("Pets1", "none");
            user.Add("Like_cc1", "true");            

            // User two
            user.Add("Name2", "Omega");
            user.Add("Fav_sport2", "tennis");
            user.Add("Pets2", "2");
            user.Add("Like_cc2", "true"); 

            // User three
            user.Add("Name3", "Matha");
            user.Add("Fav_sport3", "swimming");
            user.Add("Pets3", "1");
            user.Add("Like_cc3", "false"); 

            // User four
            user.Add("Name4", "Micah");
            user.Add("Fav_sport4", "golf");
            user.Add("Pets4", "none");
            user.Add("Like_cc4", "false"); 


            // create a list to add user info to it
            List<string> userList = new List<string>();
           
           foreach (KeyValuePair<string,string> entry in user)
           {
                userList.Add(entry.Value);
           }

           // Loop through the list and pringt each field of user info
           foreach ( string info in userList)
           {
               Console.WriteLine(info + ", ");
           }
 








        }
    }
}

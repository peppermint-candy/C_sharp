using System;
// using System.Collections.Generic;

namespace ConsoleApplication
{
    public class Program

    {

        //Find max
        public static void findMax(int[] array)
        {
            int max = array[0];

            foreach (int num in array)
            {
                if ((int)max < (int)num )
                {
                    max = num;
                }
            }

            Console.WriteLine("Maximum number in this array is {0}", max);
        }

        //Find min
        public static void findMin(int[] array)
        {
            int min = array[0];

            foreach (int num in array)
            {
                if ((int)min > (int)num )
                {
                    min = num;
                }
            }

            Console.WriteLine("Minimum number in this array is {0}", min);
        }

        //find sum
        public static int sum(int[] array)
        {
            int sum = 0;
            foreach(int num in array)
            {
                sum += num;
            }
            return sum;
        }



        // random array
        public static object randomArr()
        {
            int[] array = new int[10];
            Random rnd1 = new Random();

             
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd1.Next(10,25);                
            }

            findMax(array);
            findMin(array);            
            return sum(array);
            
        }



        // COIN FLIP

        public static string tossCoin()
        {
            string[] coin = new string[2] {"Head","Tail"};
            Random rnd = new Random();

            int rand = rnd.Next(2);
            Console.WriteLine("Tossing a Coin!");
            return coin[rand];
        }

        // TOSS MULTIPLE COINS
        public static double TossMultipleCoins(int num)
        {
            string[] result = new string[num];
            for ( int i=0; i < num; i++) 
            {
                result[i] = tossCoin();
            }

            int count = 0;
            foreach( string side in result)
            {
                if (side == "Head")
                {
                    count ++;
                }
            }

            double ratio = count/num;
            return  ratio;
        }


        // NAMES


        public static string[] names()
        {
            string[] allNames = new string[5] {"Todd", "Tiffany", "Charlie", "Geneva", "Sydney"};
            string[] newNames = new string[5];
            Random rand = new Random();

            int length = newNames.Length;
            int i = length;

            while( i > 0 )
            {
                int idx = rand.Next(5);
                if (!Array.Exists(newNames, element => element == allNames[idx]))
                {
                    newNames[i-1] = allNames[idx];
                    Console.WriteLine(i);
                    i --;
                }
            }            


            int count = 0;

            foreach(string item in newNames)
            {
                if (item.Length > 5)
                {
                    count++;
                }
            }

            string[] result = new string[count];
            int j = 0;
            foreach (string item in newNames)
            {
                if (item.Length > 5)
                {
                    result[j] = item;
                    j++;
                }
            }

            // Console.WriteLine(!Array.Exists(newNames, element => element == allNames[0]));
            
            Console.WriteLine(string.Join(", ", newNames));
            Console.WriteLine(string.Join(", ", result));
            return result;
        }


        public static void Main(string[] args)
        {

            // object fun = randomArr();
            // Console.WriteLine(fun);

            // object coin = tossCoin();
            // Console.WriteLine(coin);
            // TossMultipleCoins(3);
            names();
        }
    }
}

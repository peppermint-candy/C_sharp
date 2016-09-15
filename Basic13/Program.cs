using System;

namespace ConsoleApplication
{
    public class Program
    {
        // Put it a bunch of functions here 

        // print 1 to 255
        public static void print1to255()
        {
            for ( int i = 1; i < 256; i++)
            {
                Console.WriteLine(i);
            }
        }

        // print odd numbers between 1 to 255
        public static void printOdd1to255()
        {
            for ( int i = 1; i < 256; i++)
            {
                if ( i%2 != 0)
                {
                Console.WriteLine(i);
                }
            }
        }

        //print sum
        public static void printSum()
        {
            var sum = 0;
            for (int i = 1; i < 256; i++)
            {
                sum += i;
                Console.WriteLine("New number: {0} Sum: {1}", i, sum);
            }
        }

        // Iterating through an Array
        public static void iteratingArray()
        {
            int[] X = new int[6] {1,3,5,7,9,13};
            foreach( int x in X)
            {
                Console.WriteLine(x);
            }
        }


        //Find max
        public static void findMax(object[] array)
        {
            var max = array[0];

            foreach (object num in array)
            {
                if ((int)max < (int)num )
                {
                    max = num;
                }
            }

            Console.WriteLine("Maximum number in this array is {0}", max);
        }


        // Get average
        public static void getAvg(object[] array)
        {
            var sum = 0 ;

            foreach (object num in array)
            {
                sum += (int)num;
            }

            var avg = sum/(int)array.Length;

            Console.WriteLine("Average number in this array is {0}", avg);
        }

        // Array with odds numbers
        public static void arrayOdd1to255()
        {
            int[] array = new int[128];
            int j = 0;

            for ( int i = 1; i < 256; i += 2)
            {
                array[j] = i;
                // Console.WriteLine(array[j]);
                j++;
          
            }
            Console.WriteLine(string.Join(",", array));
        }

        // Greater than Y

        public static void greaterY(int[] array, int Y)
        {
            int count = 0;
            foreach (int num in array)
            {
                if ( num > Y)
                {
                    count ++;
                }
            }

            Console.WriteLine("There are {0} numbers that are greater than {1}.", count, Y);
        }

        public static void squareNum(object[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = (int)array[i] * (int)array[i];
            }

            Console.WriteLine(string.Join(", ", array));
        }

        // Eliminate Negative numbers
        public static void noNeg(object[] array)
        {
            for (var i = 0; i < array.Length; i++)
            {
                if ( (int)array[i] < 0)
                {
                    array[i] = 0;
                }
            }

            Console.WriteLine(string.Join(", ", array));

        }

        //Min, Max and Average
        public static void basicStat(object[] array)
        {
            var sum = 0;
            var max = array[0];
            var min = 0;

            for (var i = 0; i < array.Length; i++)
            {
                if ((int)max < (int)array[i])
                {
                    max = array[i];
                }

                if ((int)min > (int)array[i])
                {
                    min = (int)array[i];
                }
                
                sum += (int)array[i];               
            }

                var avg = sum/(int)array.Length;
                Console.WriteLine("Max : {0} , Min: {1}, Average: {2}", max, min, avg);
        }


        //Shifting the values in an array

        public static void shiftingArray(object[] array)
        {
   
            for (var i = 0; i < array.Length-1; i++)
            {
                var temp = array[i];
                array[i] = array[i+1];
                array[i+1] = temp;
            }
            Console.WriteLine(string.Join(" ,", array));
        }

        //Number to string
        public static void numTostring(object[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if ((int)array[i] < 0)
                {
                    array[i] = "Dojo";
                }

            }

            Console.WriteLine(string.Join(" ,", array));
        }





        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // print1to255();
            // printOdd1to255();
            // printSum();
            // iteratingArray();

            object[] array = new object[3] {-3,-5,-7};
            int[] arrayInt = new int[4] {1,3,4,5};
            // findMax(array);
            // getAvg(array);
            // arrayOdd1to255();
            // greaterY(arrayInt, 3);
            // squareNum(array);
            // noNeg(array);
            // basicStat(array);
            // shiftingArray(array);
            // numTostring(array);


            

        }
    }
}

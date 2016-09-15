﻿using System;
using System.Collections.Generic;



namespace ConsoleApplication
{
    public class Program
    {
        // FUNCTIONS
        public static void SayHello(string name)
        {
            Console.WriteLine("Hello, {0} how are you doing today?", name);
        }

        public static void SayMyName(string name = "buddy")
        {
            Console.WriteLine("Hey " + name);
        }

        public static string SayHelloInReturn(string name = "Debby")
        {
            return  "Hey " + name;
        }



        // OOP Classes

        public class Vehicle {
            // public is placed infront of numPassengers to allow accessibility, otherwise var is private
            // public int numPassengers = 2;

            // below is a constructor function which doesn't need a return or static kw
            public int numPassengers;
            // Adding more fun with CLASS methods
            public double distance = 0.0;

            public Vehicle(int val)
            {
                numPassengers = val;
            }

            // public void Move(double miles) <------- important!! if you don't plan to RETURN 
            // {
            // void is included to specif the retur type of the function (nothing returns in this case)
            //     distance += miles;
            // }

            // here is the version that will return an integer to the Move method
            public int Move(double miles)
            {
                distance += miles;
                return (int)distance;
            }

            // --------------------- METHOD OVERLOADING ------------------
            //This is the process of building methods with the same name and based on the parameters of the different functions 
            //and the data passed to it, the system can figure out which version to run -- awesome right!

            public Vehicle(int val, double odo)
            {
                numPassengers = val;
                distance = odo;
                //The second for preowned with mileage already.
            }


            // if boolean is included in the method call below 
            // it may be measuring in km rather than miles.
            public int Move(double miles, bool km)
            {
                if (km ==  true)
                {
                    miles = miles * 0.62;
                }

                // distance += miles;
                // return (int)distance;
                // smarter way to return is by calling the first version

                return Move(miles);
            }



            // ------------------ GETTER AND SETTER ---------------------------

            






        }


        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // VARIABLES AND OUTPUT

           // int favoriteNum = 42;
           // Console.WriteLine(favoriteNum);
           // Console.WriteLine("The {0} cow, jumped over the {1} , {2} times!", "brown", "Moon", 7);
           // string name = "David";
           // Console.WriteLine(10 + " Chickens attached " + name);
           // string interpol = $"The answer to 2 + 7 is { 2 + 7 }";
           // Console.WriteLine(interpol);

           // CONDITIONALS
        //    int rings = 3;
        //    if (rings>=5)
        //    {
        //        Console.WriteLine("You are welcome to join the party");
        //    }
        //    else if (rings > 2) 
        //    {
        //        Console.WriteLine("Decent...but {0} rings aren't enough " ,rings);
        //    }
        //    else
        //    {
        //        Console.WriteLine("Go win some more rings");
        //    }
        
        // int rings = 5;
        //By placing the keyword const in front of a variable declaration
        //you establish it as constant and immutable
        // const string name = "Kobe";

        // if (rings >= 5 && name == "Kobe")
        // {
        //     Console.WriteLine("Welcome to the party {0}, congratulations on your {1} rings", name, rings);
        // }

        // }

        // LOOPS

        // for (int i=1; i<=5; i++)
        // {
        //     Console.WriteLine(i);
        // }

        // for (int i=1; i<5; i++)
        // {
        //     Console.WriteLine(i);
        // }

        // int j = 1;
        // while (j<6)
        // {
        //     Console.WriteLine(j);
        //     j = j + 1;
        // }


        // ARRAYS
        // int[] numArray = new int[5];
        // int[] numArray2 = {1,2,3,4,5};
        // Console.WriteLine(numArray2[0]);
        // int[] array3;
        // array3 = new int[] {1,3,5,7,9};
        // Console.WriteLine(array3[3]);

        // string[] myCars = new string[3] {"Honda", "Toyota","Porche"};
        // foreach ( string car in myCars) 
        // {
        //     Console.WriteLine(car);
        // }

        // int[,] array2D = new int[4,2];
        // int[,,] array3D = new int[2,2,4] {
        //     {
        //         {5,1,6,17},{1,2,3,4}
        //     },{
        //         {11,12,0,4}, {44,5,6,77}
        //     }
        // };

        // Console.WriteLine(array3D[1,0,3]);

        // // JAGGED ARRAY
        // int[][] jaggedArray = new int[3][];
        // jaggedArray[0] = new int[5];
        // jaggedArray[1] = new int[4];
        // jaggedArray[2] = new int[2];
        // int[][] jaggedArray2 = new int[][] {
        //     new int[] {1,3,5,7,9},
        //     new int[] {0,2},
        //     new int[] {11,22,33,44}
        // };

        // GENERIC LISTS
        // don't for get to add using System.Collections.Generic at the top

        // List<string> bikes = new List<string>();
        // bikes.Add("BMW");
        // bikes.Add("Kawasaki");
        // bikes.Add("Suzuku");
        
        // Console.WriteLine(bikes[2]);

        // foreach( string bike in bikes)
        // {
        //     Console.WriteLine(bike);
        // }


        // for (var idx = 0; idx < bikes.Count; idx ++)
        // {
        //     Console.WriteLine("-" + bikes[idx]);
        // }

        // bikes.Remove("BMW");
        // bikes.RemoveAt(0);

        //DICTIONARY CLASS

        // Dictionary<string,string> profile = new Dictionary<string,string>();
        //Almost all the methods that exists with Lists are the same with Dictionaries
        // profile.Add("Name", "Speros");
        // profile.Add("Language", "PHP");
        // profile.Add("Location", "Greece");
        // Console.WriteLine("Instructor Profile");
        // Console.WriteLine("Name - " + profile["Name"]);
        // Console.WriteLine("From - " + profile["Location"]);
        // Console.WriteLine("Favorite Language - " + profile["Language"]);

        // foreach (KeyValuePair<string,string> entry in profile)
        // {
        // Console.WriteLine(entry.Key + " - " + entry.Value);
        // }

        // foreach (var entry in profile)
        // {
        // Console.WriteLine(entry.Key + " - " + entry.Value);
        // }



        //FUNCTIONS

        // SayHello("Oliver");
        // SayMyName();
        // SayMyName("Harembe");
        
        // string testReturnFn;
        // testReturnFn = SayHelloInReturn();
        // Console.WriteLine(testReturnFn);


        // OOP Classes

            // I am calling class vehicle here
        Vehicle myVehicle = new Vehicle(7);
        Console.WriteLine($"My vehicle can hold {myVehicle.numPassengers} people");

        Vehicle bike = new Vehicle(1);

        Console.WriteLine(myVehicle.distance);
        Console.WriteLine(bike.distance);

        bike.Move(70.8);
        Console.WriteLine(bike.distance);

        

        }
    }
}

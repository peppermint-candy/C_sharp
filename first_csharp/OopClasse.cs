using System;


namespace ConsoleApplication
{
    public class Vehicle 
        {
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

            public void GetInfo()
            {
                Console.WriteLine("This is just a basic Vehicle!");
                Console.WriteLine($"Currently has travelled {distance} miles");
            }

        }
}
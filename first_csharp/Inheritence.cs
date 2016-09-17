// Inheritence - allow other class to inherit property and general method from other class

// Base - is done to pass the neede variables to the parent class' contructor methods

using System;

namespace ConsoleApplication
{
    public class Car : Vehicle
    {
        public int numberOfWheels = 4;
        public string condition;
        public Car() : base(5)
        {
            condition = "New";
        }

        public Car(double odo) : base(5,odo)
        {
            condition = "Used";
        }

        public new void GetInfo()
        {
            // Console.WriteLine($"Car Condition:{condition}");
            // Console.WriteLine($"Max occupancy: {numPassengers}");
            // Console.WriteLine($"Current Milage: {distance} miles");

            // ----- Instead of rewriting the entire command again you can refer to the parent using base

            base.GetInfo();
            Console.WriteLine($"Car Condition:{condition}");


        }

    }
}


// Inheritence and Accessibility
// Earlier in the functions chapter we talked about the difference between public and private and how public is visible to any code in the same program,
// but private is only visiable by code within the same class. Well these accessibility levels are more to that,
// particularly when talking about in regards to class inheritence.
// See, public methods are inherited as expected; however, private methods are not.
// If we want to have a method have the visibility of a private method, but still be inherited,
// we have to use the access modifier of protected in place of public.
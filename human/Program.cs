using System;

namespace ConsoleApplication
{
    public class Program
    {

        // ------------ OOP CLASS START HERE ---------------

        public class Human
        {
            // this class has 5 attribute name strength intelligence dexterity and health

            public string name;
            public int strength = 3;
            public int intelligence = 3;
            public int dexterity = 3;
            public int health = 100;

            public Human(string user_name)
            {
                name = user_name;
            }

            public Human(string user_name, int user_str, int user_int, int user_dex, int user_health)
            {
                name = user_name;
                strength = user_str;
                intelligence = user_int;
                dexterity = user_dex;
                health = user_health;
            }

            public void Attack(Human opponent)
            {
                opponent.health -= 5*opponent.strength;
            }


            
        }



        // ------------- OOP CLASS END HERE -------------------
        public static void Main(string[] args)
        {
            Human Nancy = new Human("Nancy");
            Human Ruby = new Human("Ruby");

        }
    }
}

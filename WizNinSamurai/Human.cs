using System;

namespace ConsoleApplication
{
    public class Human
    {
        public string name;
        public int health { get; set;}

        // these properties are all private
        int strength { get; set;}
        int intelligence {get; set;}
        int dexterity {get; set;}

        public Human(string person)
        {
            name = person;
            strength = 3;
            intelligence = 3;
            dexterity = 3;
            health = 100;

        }

        public Human(string person, int str, int intel, int dex, int hp)
        {
            name = person;
            strength = str;
            intelligence = intel;
            dexterity = dex;
            health = hp;
        }

        public void attack(object obj)
        {
            if (obj.GetType() == typeof(Human))
            {
                var enemy = obj as Human;
                enemy.health -= strength * 5;
            }
            else{
                Console.WriteLine("Failed Attack");
            }
        }

    }
}
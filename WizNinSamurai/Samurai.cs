using System;

namespace ConsoleApplication
{
    public class Samurai : Human
    {
        int strength { get; set; }
        int intelligence { get; set; }
        int dexterity { get; set; }

        public Samurai(string person) : base("sammy")
        {
            name = person;
            strength = 3;
            intelligence = 3;
            dexterity = 3;
            health = 200;
        }

        public void death_blow(object obj)
        {
            if (obj.GetType() == typeof(Human))
            {
                var enemy = obj as Human;
                if (enemy.health < 50)
                {
                    enemy.health = 0;
                }
            }
            else
            {
                Console.WriteLine("Failed Attack");
            }
        }

        public void meditate()
        {
            health = 200;
        }

        
    }
}
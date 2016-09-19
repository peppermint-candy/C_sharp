using System;
namespace ConsoleApplication
{
    public class Wizard : Human
    {

        int strength { get; set; }
        int intelligence { get; set; }
        int dexterity { get; set; }
        public Wizard(string person) : base("wizzy")
        {
            name = person;
            strength = 3;
            intelligence = 25;
            dexterity = 3;
            health = 50;
        }

        public void heal()
        {
            health += 10 * intelligence;
        }

        public void fireball(object obj)
        {
            Random rnd = new Random();

            if (obj.GetType() == typeof(Human))
            {
                var enemy = obj as Human;
                enemy.health -= rnd.Next(20,50);
            }
            else
            {
                Console.WriteLine("Failed Attack");
            }
        }

        


    }
}
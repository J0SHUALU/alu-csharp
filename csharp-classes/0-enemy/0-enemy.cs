using System;

namespace Enemies
{
    /// <summary>
    /// Represents a Zombie enemy.
    /// </summary>
    public class Zombie
    {
    }

    class Program
    {
        static void Main(string[] args)
        {
            Zombie newObject = new Zombie();
            Console.WriteLine(newObject.GetType());
            Console.WriteLine(newObject.ToString());
        }
    }
}

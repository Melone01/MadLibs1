using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MadLibs
{
    class Program
    {
        static void Main(string[] args)
        {
            string maleName, age1, childName, age2, verb, verb2, verb3, place, feeling, nounWork, adjective;

            Console.Write("Enter a male name: ");
            maleName = Console.ReadLine();

            Console.Write("Enter a number: ");
            age1 = Console.ReadLine();

            Console.Write("Enter a female name: ");
            childName = Console.ReadLine();

            Console.Write("Enter another number: ");
            age2 = Console.ReadLine();

            Console.Write("Enter a verb: ");
            verb = Console.ReadLine();

            Console.Write("Enter a second verb: ");
            verb2 = Console.ReadLine();

            Console.Write("Enter a third verb: ");
            verb3 = Console.ReadLine();

            Console.Write("Enter a place: ");
            place = Console.ReadLine();

            Console.Write("Enter an adjective: ");
            feeling = Console.ReadLine();

            Console.Write("Enter a different adjective: ");
            adjective = Console.ReadLine();

            Console.Write("Enter a noun / form of work: ");
            nounWork = Console.ReadLine();

            Console.WriteLine("- - - - - -");
            Console.WriteLine("There was once a man named " + maleName);
            Console.WriteLine("He was " + age1 + " years old");
            Console.WriteLine("He had a daughter named " + childName);
            Console.WriteLine("His daughter was " + age2 + " years old");
            Console.WriteLine("He really liked " + verb);
            Console.WriteLine("Meanwhile, his daughter enjoyed " + verb2);
            Console.WriteLine("One day, they decided to go to " + place);
            Console.WriteLine("Both of them were very " + feeling + " about it");
            Console.WriteLine(maleName + " asked: So, how was " + nounWork + " today?");
            Console.WriteLine(childName + " replied with: It was " + adjective + "!");
            Console.WriteLine("And so, they proceeded to " + verb3);
            Console.WriteLine("- The End -");

            Console.ReadLine();

        }
    }
}

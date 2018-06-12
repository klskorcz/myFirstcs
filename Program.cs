using System;

namespace myFirstc
{
    class Program
    {
        static void Main(string[] args)
        {
            int dpoints = 4000;
            Console.WriteLine(dpoints);
            float numx = 7.8F;
            Console.WriteLine(numx);
            double numy = 2.1;
            Console.WriteLine(numy);
            bool soup = true;
            Console.WriteLine(soup);
            string cat = "Your face.";
            Console.WriteLine(cat);
            Console.ReadKey();

            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine(name);
            Console.Write("Oh noes! It's a fire breathing dragon! Seems early in the game to come across a dragon. I mean you just put in your name and bam there's a dragon, like whoa buddy. Anywho, would you like to use your Frost spell? I would highly recommend it. Just type in Frost: ");
            string spell = Console.ReadLine();
            Console.WriteLine(spell);
            Console.Write("{0}, you've cause {1} damage points! Good thing you took my advice and used {2}, so really I should pat myself on the back for doing your job.", name, dpoints, spell);
            Console.ReadKey();

            Console.WriteLine("circle" == "square");
            Console.WriteLine(8 > 598);
            Console.WriteLine("triangle" != "trapazoid");
            Console.WriteLine(9 < 86);
            Console.ReadKey();
        }
    }
}

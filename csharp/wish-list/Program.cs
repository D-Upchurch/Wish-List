using System;
using System.Collections.Generic;


namespace wish_list
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> wishes = new List<string>();
            wishes.Add("An original eight track of William Shatner's 'Lucy in the Sky with Diamonds'");
            wishes.Add("The ability to think of interesting wishes on short notice");
            wishes.Add("A washtub of Skittles");
            wishes.Add("World peace, but not the kind of world peace where all the humans are removed from existence");
            wishes.Add("A TV that is NOT internet-capable");
            wishes.Add("The ability to fly, but, like, really fast...not just, like, how fast I can walk, but, like, fast, you know?");

            Console.WriteLine("My wishes...");
            Console.WriteLine();

            foreach (string wish in wishes)
            {
                Console.WriteLine($"{wish}");
            }
        }
    }
}

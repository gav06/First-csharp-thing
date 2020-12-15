using System;

namespace first_c__thing
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            string time = DateTime.Now.ToString("h:mm:ss tt");
            Console.WriteLine("What is your name?");
            name = Console.ReadLine();
            
            Console.WriteLine("Nice to meet you " + name + "!");
            Console.WriteLine("The time is currently " + time + "!" );
            Console.Write("\n\nPress any key to continue...");
            Console.ReadKey();
        }
    }
}

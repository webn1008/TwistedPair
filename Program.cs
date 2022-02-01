using System;

namespace TwistedPair
{
    class Program : ReadColors
    {
        static void Main(string[] args)
        {

            do
            {
                Console.WriteLine("Please enter a number between 1 and 25.");
                Console.ReadLine();
                var jsonValue = Read(@"C:\Users\Tony\source\repos\TwistedPair\coloredPairs.json");

                Console.WriteLine(jsonValue);

            } while (true);
            
            

        }        
    }
}

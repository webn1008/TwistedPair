using System;
using Newtonsoft.Json.Linq;

namespace TwistedPair
{
    class Program : ReadColors
    {
        static void Main(string[] args)
        {

            
                Console.WriteLine("Please enter a number between 1 and 25.");

                
            //    if (userInPut != "exit")
            
                var jsonValue = Read(@"C:\Users\Tony\source\repos\TwistedPair\coloredPairs.json");
            var jsonReturn = jsonValue;
            string userInput1 = Console.ReadLine();
            string userInput2 = Console.ReadLine();
            if (userInput1 == "1" && userInput2 == "1")
            {
                Console.WriteLine(jsonReturn.FirstColor[0]);
                Console.WriteLine(jsonReturn.SecondColor[0]);
            }

            //Console.WriteLine(jsonReturn.FirstColor[3]);





        }        
    }
}

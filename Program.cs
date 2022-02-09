using System;

namespace TwistedPair
{
    class Program : ReadColors
    {
        static void Main(string[] args)
        {
            string userInput;
            do
            {
                Console.WriteLine("Please enter a number between 1 and 25, or type 'exit' to quit.\n");

                userInput = Console.ReadLine();
                var jsonValue = Read(@"C:\Users\Tony\source\repos\TwistedPair\coloredPairs.json");
                var jsonReturn = jsonValue;

                switch (userInput)
                {
                    case "1":
                        {
                            Console.WriteLine(jsonReturn.FirstColor[0] + ", " + jsonReturn.SecondColor[0] + "\n");
                            break;
                        }
                    case "2":
                        {
                            Console.WriteLine(jsonReturn.FirstColor[0] + ", " + jsonReturn.SecondColor[0] + "\n");
                            break;
                        }
                    case "3":
                        {
                            Console.WriteLine(jsonReturn.FirstColor[0] + ", " + jsonReturn.SecondColor[2] + "\n");
                            break;
                        }
                    case "4":
                        {
                            Console.WriteLine(jsonReturn.FirstColor[0] + ", " + jsonReturn.SecondColor[3] + "\n");
                            break;
                        }
                    case "5":
                        {
                            Console.WriteLine(jsonReturn.FirstColor[0] + ", " + jsonReturn.SecondColor[4] + "\n");
                            break;
                        }
                    case "6":
                        {
                            Console.WriteLine(jsonReturn.FirstColor[1] + ", " + jsonReturn.SecondColor[0] + "\n");
                            break;
                        }
                    case "7":
                        {
                            Console.WriteLine(jsonReturn.FirstColor[1] + ", " + jsonReturn.SecondColor[1] + "\n");
                            break;
                        }
                    case "8":
                        {
                            Console.WriteLine(jsonReturn.FirstColor[1] + ", " + jsonReturn.SecondColor[2] + "\n");
                            break;
                        }
                    case "9":
                        {
                            Console.WriteLine(jsonReturn.FirstColor[1] + ", " + jsonReturn.SecondColor[3] + "\n");
                            break;
                        }
                    case "10":
                        {
                            Console.WriteLine(jsonReturn.FirstColor[1] + ", " + jsonReturn.SecondColor[4] + "\n");
                            break;
                        }
                    case "11":
                        {
                            Console.WriteLine(jsonReturn.FirstColor[2] + ", " + jsonReturn.SecondColor[0] + "\n");
                            break;
                        }
                    case "12":
                        {
                            Console.WriteLine(jsonReturn.FirstColor[2] + ", " + jsonReturn.SecondColor[1] + "\n");
                            break;
                        }
                    case "13":
                        {
                            Console.WriteLine(jsonReturn.FirstColor[2] + ", " + jsonReturn.SecondColor[2] + "\n");
                            break;
                        }
                    case "14":
                        {
                            Console.WriteLine(jsonReturn.FirstColor[2] + ", " + jsonReturn.SecondColor[3] + "\n");
                            break;
                        }
                    case "15":
                        {
                            Console.WriteLine(jsonReturn.FirstColor[2] + ", " + jsonReturn.SecondColor[4] + "\n");
                            break;
                        }
                    case "16":
                        {
                            Console.WriteLine(jsonReturn.FirstColor[3] + ", " + jsonReturn.SecondColor[0] + "\n");
                            break;
                        }
                    case "17":
                        {
                            Console.WriteLine(jsonReturn.FirstColor[3] + ", " + jsonReturn.SecondColor[1] + "\n");
                            break;
                        }
                    case "18":
                        {
                            Console.WriteLine(jsonReturn.FirstColor[3] + ", " + jsonReturn.SecondColor[2] + "\n");
                            break;
                        }
                    case "19":
                        {
                            Console.WriteLine(jsonReturn.FirstColor[3] + ", " + jsonReturn.SecondColor[3] + "\n");
                            break;
                        }
                    case "20":
                        {
                            Console.WriteLine(jsonReturn.FirstColor[3] + ", " + jsonReturn.SecondColor[4] + "\n");
                            break;
                        }
                    case "21":
                        {
                            Console.WriteLine(jsonReturn.FirstColor[4] + ", " + jsonReturn.SecondColor[0] + "\n");
                            break;
                        }
                    case "22":
                        {
                            Console.WriteLine(jsonReturn.FirstColor[4] + ", " + jsonReturn.SecondColor[1] + "\n");
                            break;
                        }
                    case "23":
                        {
                            Console.WriteLine(jsonReturn.FirstColor[4] + ", " + jsonReturn.SecondColor[2] + "\n");
                            break;
                        }
                    case "24":
                        {
                            Console.WriteLine(jsonReturn.FirstColor[4] + ", " + jsonReturn.SecondColor[3] + "\n");
                            break;
                        }
                    case "25":
                        {
                            Console.WriteLine(jsonReturn.FirstColor[4] + ", " + jsonReturn.SecondColor[4] + "\n");
                            break;
                        }
                    case "exit":
                        {
                            Console.WriteLine("Goodbye!");
                            break;
                        }
                    default:
                        {
                            if(userInput != "exit" || int.Parse(userInput) > 1 || int.Parse(userInput) < 25)
                            {
                                Console.WriteLine("Only numbers between 1 and 25 can be used.\n");
                            }
                            break;
                        }
                }
            } while (userInput != "exit");


        }
    }
}

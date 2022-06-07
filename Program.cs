using System;


namespace TwistedPair
{
    class Program : ReadColors
    {

        static void Main(string[] args)
        {
            //hello
            var logger = new Logger();

            string userInput;

            do
            {
                Console.WriteLine("Please enter a number between 1 and 25 for colored pairs, or type 'exit' to quit.\n");

                userInput = Console.ReadLine();



                var jsonValue = Read(fileName);

                switch (userInput.ToLower().Trim())
                {
                    case "1":
                        {
                            PrintPairs(logger, userInput, jsonValue.FirstColor[0], jsonValue.SecondColor[0]);
                            break;
                        }
                    case "2":
                        {
                            PrintPairs(logger, userInput, jsonValue.FirstColor[0], jsonValue.SecondColor[1]);
                            break;
                        }
                    case "3":
                        {
                            PrintPairs(logger, userInput, jsonValue.FirstColor[0], jsonValue.SecondColor[2]);
                            break;
                        }
                    case "4":
                        {
                            PrintPairs(logger, userInput, jsonValue.FirstColor[0], jsonValue.SecondColor[3]);
                            break;
                        }
                    case "5":
                        {
                            PrintPairs(logger, userInput, jsonValue.FirstColor[0], jsonValue.SecondColor[4]);
                            break;
                        }
                    case "6":
                        {
                            PrintPairs(logger, userInput, jsonValue.FirstColor[1], jsonValue.SecondColor[0]);
                            break;
                        }
                    case "7":
                        {
                            PrintPairs(logger, userInput, jsonValue.FirstColor[1], jsonValue.SecondColor[1]);
                            break;
                        }
                    case "8":
                        {
                            PrintPairs(logger, userInput, jsonValue.FirstColor[1], jsonValue.SecondColor[2]);
                            break;
                        }
                    case "9":
                        {
                            PrintPairs(logger, userInput, jsonValue.FirstColor[1], jsonValue.SecondColor[3]);
                            break;
                        }
                    case "10":
                        {
                            PrintPairs(logger, userInput, jsonValue.FirstColor[1], jsonValue.SecondColor[4]);
                            break;
                        }
                    case "11":
                        {
                            PrintPairs(logger, userInput, jsonValue.FirstColor[2], jsonValue.SecondColor[0]);
                            break;
                        }
                    case "12":
                        {
                            PrintPairs(logger, userInput, jsonValue.FirstColor[2], jsonValue.SecondColor[1]);
                            break;
                        }
                    case "13":
                        {
                            PrintPairs(logger, userInput, jsonValue.FirstColor[2], jsonValue.SecondColor[2]);
                            break;
                        }
                    case "14":
                        {
                            PrintPairs(logger, userInput, jsonValue.FirstColor[2], jsonValue.SecondColor[3]);
                            break;
                        }
                    case "15":
                        {
                            PrintPairs(logger, userInput, jsonValue.FirstColor[2], jsonValue.SecondColor[4]);
                            break;
                        }
                    case "16":
                        {
                            PrintPairs(logger, userInput, jsonValue.FirstColor[3], jsonValue.SecondColor[0]);
                            break;
                        }
                    case "17":
                        {
                            PrintPairs(logger, userInput, jsonValue.FirstColor[3], jsonValue.SecondColor[1]);
                            break;
                        }
                    case "18":
                        {
                            PrintPairs(logger, userInput, jsonValue.FirstColor[3], jsonValue.SecondColor[2]);
                            break;
                        }
                    case "19":
                        {
                            PrintPairs(logger, userInput, jsonValue.FirstColor[3], jsonValue.SecondColor[3]);
                            break;
                        }
                    case "20":
                        {
                            PrintPairs(logger, userInput, jsonValue.FirstColor[3], jsonValue.SecondColor[4]);
                            break;
                        }
                    case "21":
                        {
                            PrintPairs(logger, userInput, jsonValue.FirstColor[4], jsonValue.SecondColor[0]);
                            break;
                        }
                    case "22":
                        {
                            PrintPairs(logger, userInput, jsonValue.FirstColor[4], jsonValue.SecondColor[1]);
                            break;
                        }
                    case "23":
                        {
                            PrintPairs(logger, userInput, jsonValue.FirstColor[4], jsonValue.SecondColor[2]);
                            break;
                        }
                    case "24":
                        {
                            PrintPairs(logger, userInput, jsonValue.FirstColor[4], jsonValue.SecondColor[3]);
                            break;
                        }
                    case "25":
                        {
                            PrintPairs(logger, userInput, jsonValue.FirstColor[4], jsonValue.SecondColor[4]);
                            break;
                        }
                    case "exit":
                        {
                            Console.WriteLine("Goodbye!");
                            logger.Log(userInput);
                            Environment.Exit(0);
                            break;
                        }
                    default:
                        {
                            if (userInput != "exit" || int.Parse(userInput) < 1 || int.Parse(userInput) > 25)
                            {
                                Console.WriteLine("Only numbers between 1 and 25 can be used.\n");
                                logger.Log(userInput);
                            }

                            break;
                        }
                }

            } while (userInput != "exit");
        }

        private static void PrintPairs(Logger logger, string userInput, string firstColor, string secondColor)
        {
            Console.WriteLine(firstColor + ", " + secondColor + "\n");
            logger.Log(userInput + ": " + firstColor + ", " + secondColor);
        }

    }
}


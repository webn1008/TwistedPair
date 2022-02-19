using System;
using System.IO;

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

                    var jsonValue = Read(fileName);
                    var logger = new Logger();
                    switch (userInput.ToLower().Trim())
                    {
                        case "1":
                            {
                                Console.WriteLine(jsonValue.FirstColor[0] + ", " + jsonValue.SecondColor[0] + "\n");
                                logger.Log(userInput + ": " + jsonValue.FirstColor[0] + ", " + jsonValue.SecondColor[0]);
                                break;
                        }
                        case "2":
                            {
                                Console.WriteLine(jsonValue.FirstColor[0] + ", " + jsonValue.SecondColor[1] + "\n");
                                logger.Log(userInput + ": " + jsonValue.FirstColor[0] + ", " + jsonValue.SecondColor[1]);
                                break;
                        }
                        case "3":
                            {
                                Console.WriteLine(jsonValue.FirstColor[0] + ", " + jsonValue.SecondColor[2] + "\n");
                                logger.Log(userInput + ": " + jsonValue.FirstColor[0] + ", " + jsonValue.SecondColor[2]);
                                break;
                        }
                        case "4":
                            {
                                Console.WriteLine(jsonValue.FirstColor[0] + ", " + jsonValue.SecondColor[3] + "\n");
                                logger.Log(userInput + ": " + jsonValue.FirstColor[0] + ", " + jsonValue.SecondColor[3]);
                                break;
                        }
                        case "5":
                            {
                                Console.WriteLine(jsonValue.FirstColor[0] + ", " + jsonValue.SecondColor[4] + "\n");
                                logger.Log(userInput + ": " + jsonValue.FirstColor[0] + ", " + jsonValue.SecondColor[4]);
                                break;
                        }
                        case "6":
                            {
                                Console.WriteLine(jsonValue.FirstColor[1] + ", " + jsonValue.SecondColor[0] + "\n");
                                logger.Log(userInput + ": " + jsonValue.FirstColor[1] + ", " + jsonValue.SecondColor[0]);
                                break;
                        }
                        case "7":
                            {
                                Console.WriteLine(jsonValue.FirstColor[1] + ", " + jsonValue.SecondColor[1] + "\n");
                                logger.Log(userInput + ": " + jsonValue.FirstColor[1] + ", " + jsonValue.SecondColor[1]);
                                break;
                        }
                        case "8":
                            {
                                Console.WriteLine(jsonValue.FirstColor[1] + ", " + jsonValue.SecondColor[2] + "\n");
                                logger.Log(userInput + ": " + jsonValue.FirstColor[1] + ", " + jsonValue.SecondColor[2]);
                                break;
                        }
                        case "9":
                            {
                                Console.WriteLine(jsonValue.FirstColor[1] + ", " + jsonValue.SecondColor[3] + "\n");
                                logger.Log(userInput + ": " + jsonValue.FirstColor[1] + ", " + jsonValue.SecondColor[3]);
                                break;
                        }
                        case "10":
                            {
                                Console.WriteLine(jsonValue.FirstColor[1] + ", " + jsonValue.SecondColor[4] + "\n");
                                logger.Log(userInput + ": " + jsonValue.FirstColor[1] + ", " + jsonValue.SecondColor[4]);
                                break;
                        }
                        case "11":
                            {
                                Console.WriteLine(jsonValue.FirstColor[2] + ", " + jsonValue.SecondColor[0] + "\n");
                                logger.Log(userInput + ": " + jsonValue.FirstColor[2] + ", " + jsonValue.SecondColor[0]);
                                break;
                        }
                        case "12":
                            {
                                Console.WriteLine(jsonValue.FirstColor[2] + ", " + jsonValue.SecondColor[1] + "\n");
                                logger.Log(userInput + ": " + jsonValue.FirstColor[2] + ", " + jsonValue.SecondColor[1]);
                                break;
                        }
                        case "13":
                            {
                                Console.WriteLine(jsonValue.FirstColor[2] + ", " + jsonValue.SecondColor[2] + "\n");
                                logger.Log(userInput + ": " + jsonValue.FirstColor[2] + ", " + jsonValue.SecondColor[2]);
                                break;
                        }
                        case "14":
                            {
                                Console.WriteLine(jsonValue.FirstColor[2] + ", " + jsonValue.SecondColor[3] + "\n");
                                logger.Log(userInput + ": " + jsonValue.FirstColor[2] + ", " + jsonValue.SecondColor[3]);
                                break;
                        }
                        case "15":
                            {
                                Console.WriteLine(jsonValue.FirstColor[2] + ", " + jsonValue.SecondColor[4] + "\n");
                                logger.Log(userInput + ": " + jsonValue.FirstColor[2] + ", " + jsonValue.SecondColor[4]);
                                break;
                        }
                        case "16":
                            {
                                Console.WriteLine(jsonValue.FirstColor[3] + ", " + jsonValue.SecondColor[0] + "\n");
                                logger.Log(userInput + ": " + jsonValue.FirstColor[3] + ", " + jsonValue.SecondColor[0]);
                                break;
                        }
                        case "17":
                            {
                                Console.WriteLine(jsonValue.FirstColor[3] + ", " + jsonValue.SecondColor[1] + "\n");
                                logger.Log(userInput + ": " + jsonValue.FirstColor[3] + ", " + jsonValue.SecondColor[1]);
                                break;
                        }
                        case "18":
                            {
                                Console.WriteLine(jsonValue.FirstColor[3] + ", " + jsonValue.SecondColor[2] + "\n");
                                logger.Log(userInput + ": " + jsonValue.FirstColor[3] + ", " + jsonValue.SecondColor[2]);
                                break;
                        }
                        case "19":
                            {
                                Console.WriteLine(jsonValue.FirstColor[3] + ", " + jsonValue.SecondColor[3] + "\n");
                                logger.Log(userInput + ": " + jsonValue.FirstColor[3] + ", " + jsonValue.SecondColor[3]);
                                break;
                        }
                        case "20":
                            {
                                Console.WriteLine(jsonValue.FirstColor[3] + ", " + jsonValue.SecondColor[4] + "\n");
                                logger.Log(userInput + ": " + jsonValue.FirstColor[3] + ", " + jsonValue.SecondColor[4]);
                                break;
                        }
                        case "21":
                            {
                                Console.WriteLine(jsonValue.FirstColor[4] + ", " + jsonValue.SecondColor[0] + "\n");
                                logger.Log(userInput + ": " + jsonValue.FirstColor[4] + ", " + jsonValue.SecondColor[0]);
                                break;
                        }
                        case "22":
                            {
                                Console.WriteLine(jsonValue.FirstColor[4] + ", " + jsonValue.SecondColor[1] + "\n");
                                logger.Log(userInput + ": " + jsonValue.FirstColor[4] + ", " + jsonValue.SecondColor[1]);
                                break;
                        }
                        case "23":
                            {
                                Console.WriteLine(jsonValue.FirstColor[4] + ", " + jsonValue.SecondColor[2] + "\n");
                                logger.Log(userInput + ": " + jsonValue.FirstColor[4] + ", " + jsonValue.SecondColor[2]);
                                break;
                        }
                        case "24":
                            {
                                Console.WriteLine(jsonValue.FirstColor[4] + ", " + jsonValue.SecondColor[3] + "\n");
                                logger.Log(userInput + ": " + jsonValue.FirstColor[4] + ", " + jsonValue.SecondColor[3]);
                                break;
                            }
                        case "25":
                            {
                                Console.WriteLine(jsonValue.FirstColor[4] + ", " + jsonValue.SecondColor[4] + "\n");
                                logger.Log(userInput + ": " + jsonValue.FirstColor[4] + ", " + jsonValue.SecondColor[4]);
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
                                if (userInput != "exit" || int.Parse(userInput) > 1 || int.Parse(userInput) < 25)
                                {
                                    Console.WriteLine("Only numbers between 1 and 25 can be used.\n");
                                    logger.Log(userInput);
                                }
                            break;
                            }
                    }
                } while (userInput != "exit");
            }
        }
    }


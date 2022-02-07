using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.IO;

namespace TwistedPair
{
    public class ReadColors : Colors
    {
        public static Colors Read(string path)
        {
            using (StreamReader file = new StreamReader(@"C:\Users\Tony\source\repos\TwistedPair\coloredPairs.json"))
            {
                try
                {
                    string jsonFile = file.ReadToEnd();

                    return JsonConvert.DeserializeObject<Colors>(jsonFile);
                }
                catch (Exception)
                {
                    Console.WriteLine("Problem reading file");

                    return null;
                }
            }
        }
    }
}
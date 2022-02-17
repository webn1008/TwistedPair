using Newtonsoft.Json;
using System;
using System.IO;

namespace TwistedPair
{
    public class ReadColors
    {
        protected static string fileName;

        public static Colors Read(string path)
        {

            string fileName = "coloredPairs.json";
            _ = Path.Combine(Environment.CurrentDirectory, @"net5.0\", fileName);
            using (StreamReader file = new StreamReader(fileName))
            {
                string jsonFile = file.ReadToEnd();

                return JsonConvert.DeserializeObject<Colors>(jsonFile);
            }
        }
    }
}
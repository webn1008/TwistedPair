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
            using (StreamReader file = new StreamReader(@"C:\Users\Tony\Documents\coloredPairs.json"))
            {
                try
                {
                    string jsonFile = file.ReadToEnd();


                    var serializerSettings = new JsonSerializerSettings
                    {
                        ContractResolver = new CamelCasePropertyNamesContractResolver()
                    };

                    return JsonConvert.DeserializeObject<Colors>(jsonFile, serializerSettings);
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
using Newtonsoft.Json;
using System;
using System.IO;
using System.Linq;

namespace TwistedPair
{
    public class ReadColors : Colors
    {
        protected static string fileName;

        public static Colors Read(string path)
        {
            try
            {
                string fileName = "coloredPairs.json";

                path = Path.Combine(Environment.CurrentDirectory, @"net5.0\", fileName);
                using (StreamReader file = new StreamReader(fileName))
                {
                    string jsonFile = file.ReadToEnd();

                    return JsonConvert.DeserializeObject<Colors>(jsonFile);
                }
            }
            catch (Exception ex)
            {
                ReportError(ex);
                throw;
            }

            static void ReportError(Exception? ex)
            {
                 throw new InvalidOperationException("File not found. Program will close.");
            }
        }
    }
}
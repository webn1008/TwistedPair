using System;
using System.IO;

namespace TwistedPair
{
    class Logger : LogBase
    {
        private String CurrentDirectory
        {
            get;
            set;
        }

        private String FileName
        {
            get;
            set;
        }

        private String FilePath
        {
            get;
            set;
        }

        public Logger()
        {
            CurrentDirectory = Directory.GetCurrentDirectory();
            FileName = "Log.txt";
            FilePath = CurrentDirectory + "/" + FileName;

        }

        public override void Log(string Messsage)
        {
            using StreamWriter w = File.AppendText(FilePath);
            w.Write("\r\nLog Entry: ");
            w.WriteLine("{0} {1}", DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());
            w.WriteLine("  userInput {0}", Messsage);
            w.WriteLine("-----------------------------------------------");
        }
    }
}

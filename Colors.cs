namespace TwistedPair
{
    partial class Program
    {
        public class Colors
        {
            private string firstColor;
            private string secondColor;
        }

        public class jsonColors
        {
            public IList<string> firstColor { get; set; }
            public IList<string> secondColor { get; set; }
        }
    }
}

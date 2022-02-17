using Newtonsoft.Json;
using System.Collections.Generic;

namespace TwistedPair
{
    public class Colors
    {
        public Colors() { }

        [JsonProperty("firstColor")]
        public List<string> FirstColor { get; set; }

        [JsonProperty("secondColor")]
        public List<string> SecondColor { get; set; }
    }

}

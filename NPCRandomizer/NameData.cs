using System;
using System.Collections.Generic;
using System.Text;

namespace NPCRandomizer
{
    internal class NameData
    {
        internal string Culture { get; set; }
        internal List<string> Male { get; set; }
        internal List<string> Female { get; set; }
        internal string Combiner { get; set; }
        internal List<string> Family { get; set; }
        internal string Base { get; set; }

        private Random r = new Random();

        private string RandomName(string gender)
        {
            switch (gender)
            {
                case "male":
                    return r.Choice(Male);
                case "female":
                    return r.Choice(Female);
                default:
                    return r.Choice(Male);
            }
        }

        internal string GetName(string gender)
        {
            var given = RandomName(gender);
            return $"{given} {Combiner} {r.Choice(Family)}";
        }


    }
}

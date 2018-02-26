using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NPCRandomizer
{
    internal class NationData
    {
        internal string Name { get; set; }
        internal List<NamedRange> Races { get; set; }

        internal string GetRace()
        {
            var roll = r.NextDouble();
            return Races.First(x => x.Matches(roll)).Name;
        }

        private Random r = new Random();
    }
}

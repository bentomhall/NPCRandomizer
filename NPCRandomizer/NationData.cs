using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NPCRandomizer
{
    public class NationData
    {
        public string Name { get; set; }
        public List<NamedRange> Races { get; set; }

        public string GetRace()
        {
            var roll = r.NextDouble();
            return Races.First(x => x.Matches(roll)).Name;
        }

        private Random r = new Random();
    }
}

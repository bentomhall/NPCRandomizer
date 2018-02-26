using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NPCRandomizer
{
    internal class CultureData
    {
        internal string Race { get; set; }
        internal string Nation { get; set; }
        internal string Culture { get; set; }
        internal List<NamedRange> Gender { get; set; }
        internal List<string> Religiosity { get; set; }
        internal List<NamedRange> Subrace { get; set; }

        internal bool Matches(string race, string nation)
        {
            return (race == Race && nation == Nation);
        }

        internal string GetGender()
        {
            var roll = r.NextDouble();
            return Gender.First(x => x.Matches(roll)).Name;
        }

        internal string GetReligion()
        {
            return r.Choice(Religiosity);
        }

        internal string GetSubrace()
        {
            if (Subrace.Count == 0)
            {
                return "";
            }
            var roll = r.NextDouble();
            return Subrace.First(x => x.Matches(roll)).Name;
        }

        private Random r = new Random();
    }
}

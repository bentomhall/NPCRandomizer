using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NPCRandomizer
{
    public class CultureData
    {
        public string Race { get; set; }
        public string Nation { get; set; }
        public string Culture { get; set; }
        public List<NamedRange> Gender { get; set; }
        public List<string> Religiosity { get; set; }
        public List<NamedRange> Subrace { get; set; }

        public bool Matches(string race, string nation)
        {
            return (race == Race && nation == Nation);
        }

        public string GetGender()
        {
            var roll = r.NextDouble();
            return Gender.First(x => x.Matches(roll)).Name;
        }

        public string GetReligion()
        {
            return r.Choice(Religiosity);
        }

        public string GetSubrace()
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

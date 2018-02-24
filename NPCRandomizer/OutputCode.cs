using System;
using System.Collections.Generic;
using System.Text;

namespace NPCRandomizer
{
    public partial class PersonOutput
    {
        public List<PersonData> People { get; set; }
        public string Nation { get; set; }

        public PersonOutput(List<PersonData> npcs)
        {
            People = npcs;
            Nation = npcs[0].Nation;
        }
    }
}

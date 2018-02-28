﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NPCRandomizer
{
    public class NationData
    {
        public string Name { get; set; }
        public Dictionary<string, double> Races { get; set; }
        private WeightedChoiceSet races;

        public string GetRace()
        {
            if (races == null)
            {
                races = new WeightedChoiceSet(Races);
            }
            var roll = r.NextDouble();
            return races.Match(roll);
        }

        private Random r = new Random();
    }
}

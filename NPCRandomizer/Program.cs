using System;
using System.Collections.Generic;

namespace NPCRandomizer
{
    class Program
    {
        static int Main(string[] args)
        {
            var nameFile = "npc_names.json";
            var nationFile = "nations.json";
            var cultureFile = "races.json";
            var generator = new Generator(nameFile, cultureFile, nationFile);
            //generator.Create("Council", 5);
            generator.Create(args[0], int.Parse(args[1]));
            return 0;
        }
    }

    public static class Extension
    {
        public static string Choice(this Random r, List<string> lst)
        {
            if (lst.Count == 0)
            {
                return "";
            }
            var index = r.Next(0, lst.Count);
            return lst[index];
        }
    }
}

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
            Console.WriteLine("Welcome to the NPC Generator");
            var nation = GetNation();
            var number = GetNumber();
            generator.Create(nation, number);
            return 0;
        }

        static string GetNation()
        {
            Console.Write("Please enter the (case-sensitive) name of the nation to generate NPCs for: ");
            return Console.ReadLine();
        }

        static int GetNumber()
        {
            Console.Write("Number of NPCs to create (at least 1): ");
            if (int.TryParse(Console.ReadLine(), out int number))
            {
                return number; 
            } else
            {
                return 1;
            }
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

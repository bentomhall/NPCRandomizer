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
            var validNations = generator.GetValidNations();
            Console.WriteLine("Welcome to the NPC Generator");
            var nation = GetNation(validNations);
            var number = GetNumber();
            Console.WriteLine(new string('-', 30));
            Console.WriteLine($"Now Generating {number} NPCs for {nation}");
            generator.Create(nation, number);
            return 0;
        }

        static string GetNation(IEnumerable<string> validNations)
        {
            Console.WriteLine("Valid nation choices are: ");
            Console.WriteLine(String.Join(Environment.NewLine, validNations));
            Console.WriteLine(new string('-', 30));
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NPCRandomizer
{
    class Generator
    {
        public Generator(string nameDataFile, string cultureFile, string nationFile)
        {
            cultures = ConfigurationLoader.GetConfig<List<CultureData>>(cultureFile);
            names = ConfigurationLoader.GetConfig<List<NameData>>(nameDataFile);
            personalities = ConfigurationLoader.GetConfig<List<string>>("personality.json");
            professions = ConfigurationLoader.GetConfig<List<string>>("professions.json");
            nations = ConfigurationLoader.GetConfig<List<NationData>>(nationFile);
        }

        public void Create(string nation, int number)
        {
            var index = 0;
            while (index < number)
            {
                var npc = GenerateNPC(nation);
                npcs.Add(npc);
                Console.WriteLine($"Created NPC {index} of {number}: {npc.Name}");
                index++;
            }
            Save(nation);
            return;
        }

        private PersonData GenerateNPC(string nation)
        {
            
            var race = nations.First(x => x.Name == nation).GetRace();
            var culture = cultures.First(x => x.Matches(race, nation));
            var gender = culture.GetGender();
            var religion = culture.GetReligion();
            var subrace = culture.GetSubrace();
            var nameList = names.First(x => x.Culture == culture.Culture);
            var name = nameList.GetName(gender);
            var age = r.Choice(new List<string>() { "young", "middle-aged", "old", "ancient" });
            return new PersonData()
            {
                Name = name,
                Nation = nation,
                Culture = culture.Culture,
                Gender = gender,
                Religion = religion,
                Race = race,
                Subrace = subrace,
                Personality = r.Choice(personalities),
                Profession = r.Choice(professions),
                Age = age
            };
            
        }

        public void Save(string nation)
        {
            var template = new PersonOutput(npcs);
            var text = template.TransformText();
            var filename = nation + System.IO.Path.GetRandomFileName() + ".html"; 
            System.IO.File.WriteAllText(filename, text);
            return;
        }

        private List<PersonData> npcs = new List<PersonData>();
        private List<CultureData> cultures;
        private List<NameData> names;
        private List<string> personalities;
        private List<string> professions;
        private List<NationData> nations;
        private Random r = new Random();
    }
}

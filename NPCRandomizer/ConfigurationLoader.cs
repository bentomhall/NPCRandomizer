using System;
using System.Collections.Generic;
using Newtonsoft.Json;
namespace NPCRandomizer
{

    public static class ConfigurationLoader
    {
        public static T GetConfig<T>(string filename)
        {
            var text = System.IO.File.ReadAllText(filename);
            return JsonConvert.DeserializeObject<T>(text);
        }
    }
}

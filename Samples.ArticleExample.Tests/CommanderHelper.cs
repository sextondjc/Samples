using Drapper;
using Drapper.Configuration;
using Drapper.Configuration.Json;
using Newtonsoft.Json;
using System.IO;

namespace Samples.ArticleExample.Tests
{
    public static class CommanderHelper
    {
        /// <summary>
        /// Creates an instance of the IDbCommander, similar to how you might
        /// from an IoC framework.
        /// </summary>
        /// <returns></returns>
        public static IDbCommander CreateCommander()
        {
            var settings = JsonConvert.DeserializeObject<Settings>(File.ReadAllText("Drapper.Settings.json"));
            var reader = new JsonFileCommandReader(settings);
            var connector = new DbConnector(settings);
            return new DbCommander(connector, reader);
        }
    }
}

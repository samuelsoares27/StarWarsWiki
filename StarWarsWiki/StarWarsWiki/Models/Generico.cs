using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace StarWarsWiki.Models
{
    public class Generico
    {
        [JsonProperty("created")]
        public string Criado { get; set; }

        [JsonProperty("edited")]
        public string Editado { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }
}

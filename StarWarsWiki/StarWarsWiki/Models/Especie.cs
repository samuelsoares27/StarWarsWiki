using Newtonsoft.Json;
using StarWarsWiki.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Star_Wars.Models
{
    public class Especie : Generico
    {
        [JsonProperty("name")]
        public string Nome { get; set; }

        [JsonProperty("classification")]
        public string Classificacao { get; set; }

        [JsonProperty("designation")]
        public string Designacao { get; set; }

        [JsonProperty("average_height")]
        public string AlturaMedia { get; set; }

        [JsonProperty("skin_colors")]
        public string CoresDePele { get; set; }

        [JsonProperty("hair_colors")]
        public string CoresDeCabelo { get; set; }

        [JsonProperty("eye_colors")]
        public string CoresDeOlhos { get; set; }

        [JsonProperty("average_lifespan")]
        public string VidaMedia { get; set; }

        [JsonProperty("homeworld")]
        public string PlanetaCasa { get; set; }

        [JsonProperty("language")]
        public string Idioma { get; set; }

        [JsonProperty("people")]
        public List<string> Pessoas { get; set; }

        [JsonProperty("films")]
        public List<string> Filmes { get; set; }
    }
}
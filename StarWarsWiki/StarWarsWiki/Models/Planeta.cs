using Newtonsoft.Json;
using StarWarsWiki.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Star_Wars.Models
{
    public class Planeta : Generico
    {
        [JsonProperty("name")]
        public string Nome { get; set; }

        [JsonProperty("rotation_period")]
        public string PeriodoRotacao { get; set; }

        [JsonProperty("orbital_period")]
        public string PeriodoOrbital { get; set; }

        [JsonProperty("diameter")]
        public string Diametro { get; set; }

        [JsonProperty("climate")]
        public string Clima { get; set; }

        [JsonProperty("gravity")]
        public string Gravidade { get; set; }

        [JsonProperty("terrain")]
        public string Terreno { get; set; }

        [JsonProperty("surface_water")]
        public string AguaSuperficie { get; set; }

        [JsonProperty("population")]
        public string Populacao { get; set; }

        [JsonProperty("residents")]
        public List<string> Residentes { get; set; }

        [JsonProperty("films")]
        public List<string> Filmes { get; set; }
    }
}
using Newtonsoft.Json;
using StarWarsWiki.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Star_Wars.Models
{
    public class Pessoa : Generico
    {
        [JsonProperty("name")]
        public string Nome { get; set; }

        [JsonProperty("height")]
        public string Altura { get; set; }

        [JsonProperty("mass")]
        public string Peso { get; set; }

        [JsonProperty("hair_color")]
        public string CorCabelo { get; set; }

        [JsonProperty("skin_color")]
        public string CorPele { get; set; }

        [JsonProperty("eye_color")]
        public string CorOlhos { get; set; }

        [JsonProperty("birth_year")]
        public string AnoNascimento { get; set; }

        [JsonProperty("gender")]
        public string Genero { get; set; }

        [JsonProperty("homeworld")]
        public string PlanetaNatal { get; set; }

        [JsonProperty("films")]
        public List<string> Filmes { get; set; }

        [JsonProperty("species")]
        public List<string> Especies { get; set; }

        [JsonProperty("vehicles")]
        public List<string> Veiculos { get; set; }

        [JsonProperty("starships")]
        public List<string> Naves { get; set; }

    }
}
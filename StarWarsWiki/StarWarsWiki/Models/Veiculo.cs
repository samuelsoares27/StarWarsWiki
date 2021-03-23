using Newtonsoft.Json;
using StarWarsWiki.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Star_Wars.Models
{
    public class Veiculo : Generico
    {
        [JsonProperty("name")]
        public string Nome { get; set; }

        [JsonProperty("model")]
        public string Modelo { get; set; }

        [JsonProperty("manufacturer")]
        public string Fabricante { get; set; }

        [JsonProperty("cost_in_credits")]
        public string CustoCreditos { get; set; }

        [JsonProperty("length")]
        public string Tamanho { get; set; }

        [JsonProperty("max_atmosphering_speed")]
        public string VelocidadeMaximaAtmosfera { get; set; }

        [JsonProperty("crew")]
        public string Equipe { get; set; }

        [JsonProperty("passengers")]
        public string Passageiros { get; set; }

        [JsonProperty("cargo_capacity")]
        public string CapacidadeCarga { get; set; }

        [JsonProperty("consumables")]
        public string Consumivel { get; set; }

        [JsonProperty("vehicle_class")]
        public string ClasseVeiculo { get; set; }

        [JsonProperty("pilots")]
        public List<string> Pilotos { get; set; }

        [JsonProperty("films")]
        public List<string> Filmes { get; set; }

    }
}
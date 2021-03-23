using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Star_Wars.Models
{
    class Lista<T> where T : class
    {
        [JsonProperty("count")]
        public Int64 Quantidade { get; set; }

        [JsonProperty("next")]
        public string Proximo { get; set; }

        [JsonProperty("previous")]
        public string Anterior { get; set; }

        [JsonProperty("results")]
        public List<T> Resultado { get; set; }
    }
}

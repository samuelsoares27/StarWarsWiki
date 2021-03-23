using Firebase.Storage;
using Newtonsoft.Json;
using Star_Wars.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace StarWarsWiki.Services
{
    class ApiSWServices
    {
        private readonly FirebaseStorage firebaseStorage = new FirebaseStorage("starwarswiki-45260.appspot.com");   
        private HttpClient client = new HttpClient();

        public async Task<List<Lista<Veiculo>>> GetListaVeiculosAsync(Enum api)
        {
            try
            {
                Lista<Veiculo> lista = new Lista<Veiculo>();
                List<Lista<Veiculo>> Lista = new List<Lista<Veiculo>>();
                string url = "https://swapi.dev/api/" + api.ToString() + "/";

                lista = JsonConvert.DeserializeObject<Lista<Veiculo>>(await client.GetStringAsync(url));
                var paginas = GetQuantidadePaginas(api, lista.Quantidade);

                for (int i = 1; i < paginas; i++)
                {
                    Lista.Add(JsonConvert.DeserializeObject<Lista<Veiculo>>(await client.GetStringAsync(url + "?page=" + i)));
                }

                return Lista;

            }
            catch (Exception e)
            {
                if (e.Source != null)
                    Console.WriteLine("IOException source: {0}", e.Source);
                throw e;
            }


        }

        public async Task<List<Lista<Nave>>> GetListaNavesAsync(Enum api)
        {
            try
            {
                Lista<Nave> lista = new Lista<Nave>();
                List<Lista<Nave>> Lista = new List<Lista<Nave>>();
                string url = "https://swapi.dev/api/" + api.ToString() + "/";

                lista = JsonConvert.DeserializeObject<Lista<Nave>>(await client.GetStringAsync(url));
                var paginas = GetQuantidadePaginas(api, lista.Quantidade);

                for (int i = 1; i < paginas; i++)
                {
                    Lista.Add(JsonConvert.DeserializeObject<Lista<Nave>>(await client.GetStringAsync(url + "?page=" + i)));
                }

                return Lista;

            }
            catch (Exception e)
            {
                if (e.Source != null)
                    Console.WriteLine("IOException source: {0}", e.Source);
                throw e;
            }


        }

        public async Task<List<Lista<Pessoa>>> GetListaPessoasAsync(Enum api)
        {
            try
            {
                Lista<Pessoa> lista = new Lista<Pessoa>();
                List<Lista<Pessoa>> Lista = new List<Lista<Pessoa>>();
                string url = "https://swapi.dev/api/" + api.ToString() + "/";

                lista = JsonConvert.DeserializeObject<Lista<Pessoa>>(await client.GetStringAsync(url));
                var paginas = GetQuantidadePaginas(api, lista.Quantidade);

                for (int i = 1; i < paginas; i++)
                {
                    Lista.Add(JsonConvert.DeserializeObject<Lista<Pessoa>>(await client.GetStringAsync(url + "?page=" + i)));
                }

                return Lista;

            }
            catch (Exception e)
            {
                if (e.Source != null)
                    Console.WriteLine("IOException source: {0}", e.Source);
                throw e;
            }


        }

        public async Task<List<Lista<Especie>>> GetListaEspecieAsync(Enum api)
        {
            try
            {
                Lista<Especie> lista = new Lista<Especie>();
                List<Lista<Especie>> Lista = new List<Lista<Especie>>();
                string url = "https://swapi.dev/api/" + api.ToString() + "/";

                lista = JsonConvert.DeserializeObject<Lista<Especie>>(await client.GetStringAsync(url));
                var paginas = GetQuantidadePaginas(api, lista.Quantidade);

                for (int i = 1; i < paginas; i++)
                {
                    Lista.Add(JsonConvert.DeserializeObject<Lista<Especie>>(await client.GetStringAsync(url + "?page=" + i)));
                }

                return Lista;

            }
            catch (Exception e)
            {
                if (e.Source != null)
                    Console.WriteLine("IOException source: {0}", e.Source);
                throw e;
            }


        }

        public async Task<List<Lista<Planeta>>> GetListaPlanetaAsync(Enum api)
        {
            try
            {
                Lista<Planeta> lista = new Lista<Planeta>();
                List<Lista<Planeta>> Lista = new List<Lista<Planeta>>();
                string url = "https://swapi.dev/api/" + api.ToString() + "/";

                lista = JsonConvert.DeserializeObject<Lista<Planeta>>(await client.GetStringAsync(url));
                var paginas = GetQuantidadePaginas(api, lista.Quantidade);

                for (int i = 1; i < paginas; i++)
                {
                    Lista.Add(JsonConvert.DeserializeObject<Lista<Planeta>>(await client.GetStringAsync(url + "?page=" + i)));
                }

                return Lista;

            }
            catch (Exception e)
            {
                if (e.Source != null)
                    Console.WriteLine("IOException source: {0}", e.Source);
                throw e;
            }


        }

        public double GetQuantidadePaginas(Enum api, Int64 quantidade)
        {

            try
            {
                if (quantidade % 10 == 0)
                {
                    return quantidade / 10;

                }
                else
                {
                    double divisao = quantidade / 10;
                    return Math.Truncate(divisao) + 1;
                }

            }
            catch (Exception e)
            {
                if (e.Source != null)
                    Console.WriteLine("IOException source: {0}", e.Source);
                throw;
            }
        }

        public async Task<string> GetImagemAsync(string nome, Enum api) {

            try
            {
                string pasta = "";
                string entrada = api.ToString();
                switch (entrada)
                {
                    case "people":
                        pasta = "pessoas";
                        break;
                    case "planets":
                        pasta = "planetas";
                        break;
                    case "films":
                        pasta = "filmes";
                        break;
                    case "species":
                        pasta = "especies";
                        break;
                    case "vehicles":
                        pasta = "veiculos";
                        break;
                    case "starships":
                        pasta = "naves";
                        break;
                    default:
                        pasta = "Sem valor";
                        break;
                }

                var storageImage = await firebaseStorage
                    .Child(pasta)
                    .Child(nome + ".png")
                    .GetDownloadUrlAsync();

                return storageImage;

            }
            catch (Exception e)
            {
                if (e.Source != null)
                    Console.WriteLine("IOException source: {0}", e.Source);
                throw;
            }
        }

    }
}

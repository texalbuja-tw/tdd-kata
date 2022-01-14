using System;
using System.Net.Http;
using PokeApi.Model;

namespace PokeApi.Service
{
    public class PokemonService
    {
        private HttpClient _httpClient;

        public PokemonService(HttpClient httpClient)
        {
            this._httpClient = httpClient;
        }

        public Pokemon GetPokemon(int pokemonNumber)
        {
            return new Pokemon();
        }
    }
}
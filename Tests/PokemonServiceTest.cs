using System.Net.Http;
using Moq;
using PokeApi.Service;
using Xunit;

namespace Tests
{
    public class PokemonServiceTest
    {
        [Fact]
        public void ShouldNotGetPokemonNameWhenNumberIsNotProvided()
        {
            // Arrange
            var mockHttpClient = new Mock<HttpClient>();
            var pokemonService = new PokemonService(mockHttpClient.Object);

            //var mockHttpClient.SetupRequest("https://pokeapi.com/api/v2/pokemon");
            
            // Act
            var pokemon = pokemonService.GetPokemon("Pikachu");

            // Assert
        }
    }
}
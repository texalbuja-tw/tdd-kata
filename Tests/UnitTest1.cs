using Xunit;
using PokeApi.Model;
using Moq;
using PokeApi.Service;
using Moq.Contrib.HttpClient;
using System.Net.Http;

namespace Tests
{
    public class PokemonClientTest
    {
        [Fact]
        public void ShouldReturnPokemonNameGivenANumber()
        {
            // Arrange
            string pokemonNumber = "25";
            var expectedPokemon = new Pokemon { name = "Pikachu" };

            var handler = new Mock<HttpMessageHandler>();
            var client = handler.CreateClient();
            //client.SetupRequest(HttpMethod.Get, "{name: 'Pikachu'}");
            var pokemonService = new PokemonService(client);
            
            // Act
            
            var actualPokemon = pokemonService.GetPokemon(pokemonNumber);

            // Assert
            Assert.Equal(actualPokemon.name, expectedPokemon.name);
        }
    }
}

using OpenWeatherAPI;
using System;
using System.Threading.Tasks;
using Xunit;

namespace OpenWeatherAPITests
{
    public class OpenWeatherProcessorTests
    {
        private OpenWeatherProcessor _sut;
        //Afficher le message de l’exception dans l’erreur que ApiKey est vide ou null.
        [Fact]
        public async Task GetOneCallAsync_IfApiKeyEmptyOrNull_ThrowArgumentException()
        {
            _sut = OpenWeatherProcessor.Instance;
            await Assert.ThrowsAsync<ArgumentException>(() => _sut.GetOneCallAsync());

        }
        //Afficher le message de l’exception dans l’erreur que ApiKey est vide ou null.
        [Fact]
        public async Task GetCurrentWeatherAsync_IfApiKeyEmptyOrNull_ThrowArgumentExceptionnAsync()
        {
            _sut = OpenWeatherProcessor.Instance;
            await Assert.ThrowsAsync<ArgumentException>(() => _sut.GetCurrentWeatherAsync());
        }
        //Afficher le message de l’exception dans l’erreur que le client http n’est pas initialisé.
        [Fact]
        public async Task GetOneCallAsync_IfApiHelperNotInitialized_ThrowArgumentExceptionAsync()
        {
            _sut = OpenWeatherProcessor.Instance;
            await Assert.ThrowsAsync<ArgumentException>(() => _sut.GetOneCallAsync());
        }
        //Afficher le message de l’exception dans l’erreur que le client http n’est pas initialisé
        [Fact]
        public async Task GetCurrentWeatherAsync_IfApiHelperNotInitialized_ThrowArgumentExceptionAsync()
        {
            _sut = OpenWeatherProcessor.Instance;
            await Assert.ThrowsAsync<ArgumentException>(() => _sut.GetCurrentWeatherAsync());
        }
    }
}

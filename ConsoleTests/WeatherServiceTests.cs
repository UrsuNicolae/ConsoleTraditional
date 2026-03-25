using ConsoleAppTraditional.UTs;
using Moq;

namespace ConsoleTests
{
    public class WeatherServiceTests
    {
        [Theory]
        [InlineData("Chisinau", 9, "Cold")]
        [InlineData("Bucuresti", 8, "Cold")]
        [InlineData("Roma", 15, "Moderate")]
        [InlineData("Paris", 19, "Moderate")]
        [InlineData("Dubai", 30, "Hot")]
        [InlineData("Kairo", 40, "Hot")]
        public void AnalyzeWeatherShouldReturnColdForWeatherLestThan10(string city, int grade, string expected)
        {
            var weatherServiceMock = new Mock<IWeatherService>();
            weatherServiceMock.Setup(_ => _.GetTemperature(city)).Returns(grade);
            var weatherAnalyzer = new WeatherAnalyzer(weatherServiceMock.Object);
            var temperature = weatherAnalyzer.AnalyzeWeather(city);
            Assert.Equal(expected, temperature);
            weatherServiceMock.Verify(_ => _.GetTemperature(city), Times.Once);
        }

        [Theory]
        [InlineData("Chisinau")]
        [InlineData("Bucuresti")]
        [InlineData("Roma")]
        [InlineData("Paris")]
        [InlineData("Dubai")]
        [InlineData("Kairo")]
        public void AnalyzeWeatherThrowIfWeatherServiceThrows(string city)
        {
            var weatherServiceMock = new Mock<IWeatherService>();
            weatherServiceMock.Setup(_ => _.GetTemperature(It.IsAny<string>())).Throws(new Exception());
            var weatherAnalyzer = new WeatherAnalyzer(weatherServiceMock.Object);
            Assert.Throws<Exception>(() => weatherAnalyzer.AnalyzeWeather(city));
            weatherServiceMock.Verify(_ => _.GetTemperature(city), Times.Once);
        }
    }
}

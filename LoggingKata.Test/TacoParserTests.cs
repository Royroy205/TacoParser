using System;
using Xunit;

namespace LoggingKata.Test
{
    public class TacoParserTests
    {
        [Fact]
        public void ShouldDoSomething()
        {
            // TODO: Complete Something, if anything

            //Arrange
            var tacoParser = new TacoParser();

            //Act
            var actual = tacoParser.Parse("34.073638, -84.677017, Taco Bell Acwort...");

            //Assert
            Assert.NotNull(actual);

        }

        [Theory]
        [InlineData("34.073638, -84.677017, Taco Bell Acwort...", -84.677017)]
        [InlineData("31.597099,-84.176122,Taco Bell Albany...", -84.176122 )]
        [InlineData("32.571331,-85.499655,Taco Bell Auburn...", -85.499655)]
        [InlineData("34.280205,-86.217115,Taco Bell Albertvill...", -86.217115)]
        public void ShouldParseLongitude(string line, double expected)
        {
            // TODO: Complete - "line" represents input data we will Parse to
            //       extract the Longitude.  Your .csv file will have many of these lines,
            //       each representing a TacoBell location

            //Arrange
            var tacoParser =new TacoParser();

            //Act
            var actual = tacoParser.Parse(line).Location.Longitude;
            //Assert
            Assert.Equal(expected, actual);

        }
        //TODO: Create a test ShouldParseLatitude
        [Theory]
        [InlineData("34.073638, -84.677017, Taco Bell Acwort...", 34.073638)]
        [InlineData("31.597099,-84.176122,Taco Bell Albany...", 31.597099)]
        [InlineData("32.571331,-85.499655,Taco Bell Auburn...", 32.571331)]
        [InlineData("34.280205,-86.217115,Taco Bell Albertvill...", 34.280205)]
        public void ShouldParseLongLatitude(string line, double expected)
        {
            //Arrange
            var tacoParser =new TacoParser();

            //Act
            var actual = tacoParser.Parse(line).Location.Latitude;
            //Assert
            Assert.Equal(expected, actual);

        }


       

    }
}

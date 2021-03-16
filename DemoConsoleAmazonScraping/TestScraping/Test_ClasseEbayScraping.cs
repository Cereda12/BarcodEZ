using Xunit;
using FluentAssertions;
using DemoConsoleScraping;

namespace TestScraping
{
    public class Test_ClasseEbayScraping
    {
        [Fact]
        public void WebResponseTest()
        {
            //Arrange
            var ping = new System.Net.NetworkInformation.Ping();

            //Act
            var result = ping.Send("www.ebay.it");

            //Assert
            result.Status.Should().Be(System.Net.NetworkInformation.IPStatus.Success);
        }
    }
}

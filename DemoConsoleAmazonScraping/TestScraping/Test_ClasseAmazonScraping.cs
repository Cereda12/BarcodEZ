using System.Net;
using Xunit;
using FluentAssertions;

namespace TestScraping
{
    public class Test_ClasseAmazonScraping
    {
        [Fact]
        public void WebResponseTest()
        {
            //Arrange
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("www.amazon.it");

            //Act
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            //Assert
            response.Should().Be(request.GetResponse());
        }
    }
}

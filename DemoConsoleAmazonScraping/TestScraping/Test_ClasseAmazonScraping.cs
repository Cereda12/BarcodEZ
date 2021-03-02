using System.Net;
using Xunit;
using FluentAssertions;
using DemoConsoleAmazonScraping;

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
        [Fact]
        public void Layout1Test()
        {
            //Arrange
            string url= "https://www.amazon.it/Eastpak-Astuccio-Unisex-Taglia-5x22x9/dp/B000VZK4FK/ref=mp_s_a_1_2?dchild=1&keywords=eastpak+astuccio&qid=1612001436&sr=8-2";
            string html = string.Empty;
            result = string.Empty;

            //Act
            html=AmazonScraping.GetRequest(url);
            result = AmazonScraping.DataParse(html);

            //Assert

        }
    }
}
